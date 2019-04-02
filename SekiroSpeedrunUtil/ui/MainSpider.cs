using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MemoryLibrary;
using MetroFramework;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.ui {
    public partial class FormMain {

        private List<Item> _inventory = new List<Item>();

        private bool _spiderInitialized;

        private void InitializeSpider() {
            itemGrid.CellValueChanged += SpiderCellValueChange;
            itemGrid.CellEndEdit += SpiderCellEndEdit;
            _spiderInitialized = true;
        }

        private void SpiderCellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var columnIndex = e.ColumnIndex;
            var rowIndex = e.RowIndex;
            var spiderIndex = Convert.ToInt32(itemGrid.Rows[rowIndex].Cells[0].Value);
            var itemName = itemGrid.Rows[rowIndex].Cells[1].Value.ToString();
            var spiderItem = _inventory[spiderIndex];

            if (columnIndex == 1) {
                try {
                    var item = itemName.Item();

                    if (item == null) {
                        MetroMessageBox.Show(this, $"Item not found! {itemName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    itemGrid.Rows[rowIndex].Cells[1].Value = itemName;

                    spiderItem.Id1 = item.Id1;
                    spiderItem.Id2 = item.Id2;
                    spiderItem.SekiroItem.Id1 = item.Id1;
                    spiderItem.SekiroItem.Id2 = item.Id2;
                } catch (Exception ex) {
                    itemGrid.Rows[rowIndex].Cells[1].Value = itemName;
                    MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            spiderItem.SekiroItem.Quantity = Convert.ToInt32(itemGrid.Rows[rowIndex].Cells[2].Value.ToString(), 10);
        }

        private void SpiderCellValueChange(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void BtnSpider_Click(object sender, EventArgs e) {
            if (!_spiderInitialized) InitializeSpider();
            _inventory.Clear();
            var sekiro = Utils.Sekiro();
            if (sekiro == null) return;


            var emptyItem = new SekiroItem() {
                Id1 = 0,
                Id2 = 0xFFFFFFFF,
                Quantity = 0,
                Garbage = 0
            };

            var itemCount = 0;
            IntPtr address;

            var remoteProc = RemoteProc.Instance();
            if (remoteProc == null) return;

            address = Defs.PointerByName("inventory").GetAddress(remoteProc);
            var invStart = address.ToInt64();
            var invEnd = invStart + 4800;

            Diag.WriteLine($"Inv Start: {address.ToString("X")}");
            var spiderIndex = 0;
            while (address.ToInt64() < invEnd) {
                var sekiroItem = remoteProc.Read<SekiroItem>(address);
                address += 16;
                var item = sekiroItem.ToItem();
                item.SpiderIndex = spiderIndex;
                spiderIndex++;
                _inventory.Add(item);
                if (sekiroItem.Equals(emptyItem)) continue;
                itemCount++;
            }

            Diag.WriteLine($"Inv End: {address.ToString("X")}");
            Diag.WriteLine($"Spidered {itemCount} items");

            var currentRow = 0;
            itemGrid.RowCount = itemCount;
            foreach (var item in _inventory) {
                if (item.Empty) continue;
                itemGrid.CurrentCell = itemGrid.Rows[currentRow].Cells[0];
                itemGrid.CurrentCell.Value = item.SpiderIndex;
                itemGrid.CurrentCell = itemGrid.Rows[currentRow].Cells[1];
                var cbox = (DataGridViewComboBoxCell)itemGrid.CurrentCell;
                foreach (var defi in Defs.Items) {
                    cbox.Items.Add(defi.Name);
                }
                cbox.Items.Add("Unknown");
                cbox.Value = item.Name;

                itemGrid.CurrentCell = itemGrid.Rows[currentRow].Cells[2];
                itemGrid.CurrentCell.Value = item.SekiroItem.Quantity;
                itemGrid.CurrentCell = itemGrid.Rows[currentRow].Cells[3];
                itemGrid.CurrentCell.Value = "Not Implemented";
                currentRow++;
            }
        }

        private void BtnSaveSpider_Click(object sender, EventArgs e) {
            if (!_spiderInitialized) {
                MetroMessageBox.Show(this, "You should spider something first!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try {
                var remoteProc = RemoteProc.Instance();
                if (remoteProc == null) return;

                var address = Defs.PointerByName("inventory").GetAddress(remoteProc);
                foreach (var item in _inventory) {
                    remoteProc.Write(address, item.SekiroItem);
                    address += 16;
                }
            } catch (Exception ex) {
                Diag.WriteLine(ex.Message);
                MessageBox.Show($"Failed to save inventory :( \n{ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            MetroMessageBox.Show(this,
                "Inventory saved! Do something that forces the game to reparse your inventory such as warping or saving and loading",
                ":o", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private byte[] GetBytes(SekiroItem sekiroItem) {
            var size = Marshal.SizeOf(sekiroItem);
            var arr = new byte[size];

            var ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(sekiroItem, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }
    }
}