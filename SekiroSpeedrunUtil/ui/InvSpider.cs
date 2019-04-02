using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using MemoryLibrary;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace SekiroSpeedrunUtil.ui {
    public partial class InvSpider : MetroForm {

        private IReadOnlyCollection<byte[]> _items;

        public InvSpider(IReadOnlyCollection<byte[]> items) {
            InitializeComponent();

            _items = items;

            itemGrid.ColumnCount = 4;
            itemGrid.RowCount = items.Count;

            itemGrid.CellValueChanged += ItemGridOnCellValueChanged;
            itemGrid.CellEndEdit += ItemGridOnCellEndEdit;

            var currentRow = 0;

            foreach (var bytes in items) {
                var id = BitConverter.ToInt16(bytes, 0);
                var quantity = BitConverter.ToInt32(bytes, 8);

                itemGrid.CurrentCell = itemGrid.Rows[currentRow].Cells[0];
                itemGrid.CurrentCell.Value = id.ToString("X");
                itemGrid.CurrentCell = itemGrid.Rows[currentRow].Cells[1];

                var cbox = (DataGridViewComboBoxCell)itemGrid.CurrentCell;
                foreach (var item in Defs.Items) {
                    cbox.Items.Add(item.Name);
                }

                cbox.Items.Add("Unknown");

                var existingItem = Defs.ItemById(id);
                cbox.Value = existingItem != null ? existingItem.Name : "Unknown";

                itemGrid.Rows[currentRow].Cells[2].Value = 0;

                itemGrid.CurrentCell = itemGrid.Rows[currentRow].Cells[2];
                itemGrid.CurrentCell.Value = quantity.ToString();
                itemGrid.CurrentCell = itemGrid.Rows[currentRow].Cells[3];
                itemGrid.CurrentCell.Value = "Unknown";


                currentRow++;
            }
        }

        private void ItemGridOnCellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var columnIndex = e.ColumnIndex;
            var rowIndex = e.RowIndex;
            var cell = itemGrid.Rows[rowIndex].Cells[columnIndex];

            if (columnIndex == 1) {

                try {
                    var itemName = itemGrid.Rows[rowIndex].Cells[1].Value.ToString();
                    var item = itemName.Item();

                    if (item == null) {
                        MetroMessageBox.Show(this, $"Item not found! {itemName}", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    var idHex = item.Id1.ToString("X");
                    itemGrid.Rows[rowIndex].Cells[0].Value = idHex;
                } catch (Exception ex) {
                    MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ItemGridOnCellValueChanged(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void InvSpider_Load(object sender, EventArgs e) {


        }

        private void BtnSave_Click(object sender, EventArgs e) {
            // We have to rewrite the entire inventory so first let's build it

            var invBytes = new List<byte[]>();

            try {
                for (var currentRow = 0; currentRow < itemGrid.RowCount; currentRow++) {
                    var itemName = itemGrid.Rows[currentRow].Cells[1].Value.ToString();
                    var item = Defs.ItemByName(itemName);
                    var initialItem = _items.ElementAt(currentRow);
                    if (item == null) {
                        invBytes.Add(initialItem);
                        continue;
                    }

                    var id0Bytes = BitConverter.GetBytes(item.Id1).Concat(new byte[] { 0x00, 0xB0 }).ToArray();
                    var id2Bytes = BitConverter.GetBytes(item.Id1).Concat(new byte[] { 0x00, 0x40 }).ToArray();
                    var quantityBytes = BitConverter.GetBytes(Convert.ToInt32(itemGrid.Rows[currentRow].Cells[2].Value.ToString(), 10));
                    //var someIdBytes = BitConverter.GetBytes(item.Id2).ToArray().Take(3);
                    var indexBytes = initialItem.Skip(12).Take(4);
                    var actualFinalBytes = id0Bytes.Concat(id2Bytes).Concat(quantityBytes).Concat(indexBytes).ToArray();

                    invBytes.Add(actualFinalBytes);

                }
            } catch (Exception ex) {
                Debug.WriteLine(ex);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            Debug.WriteLine("SPIDER");
            foreach (var bytese in invBytes) {
                Debug.WriteLine(BitConverter.ToString(bytese).Replace("-", " "));
            }

            Debug.WriteLine("=========");

            Debug.WriteLine("MEMORY");
            foreach (var bytese in _items) {
                Debug.WriteLine(BitConverter.ToString(bytese).Replace("-", " "));
            }

            Debug.WriteLine("Trying to write spider");

            using (var remoteProc = new RemoteProcess(Utils.Sekiro())) {
                var address = remoteProc.Read<IntPtr>(new IntPtr(0x143B49D10)) + 0x2E30;
                remoteProc.WriteBytes(address, invBytes.SelectMany(b => b).ToArray());
            }
        }
    }
}