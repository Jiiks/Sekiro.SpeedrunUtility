using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using SekiroSpeedrunUtil.injects;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.ui {
    public partial class FormMain {

        public void InitItemInjector() {
            for (var i = 0; i < injectorGrid.RowCount; i++) {
                var cbox = (DataGridViewComboBoxCell)injectorGrid.Rows[i].Cells[0];
                foreach (var defi in Defs.Items) {
                    cbox.Items.Add(defi.Name);
                }

                injectorGrid.Rows[i].Cells[1].Value = 1;
            }
            injectorGrid.UserAddedRow += InjectorGridOnUserAddedRow;
        }

        private void InjectorGridOnRowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            for (var i = e.RowIndex; i < e.RowCount; i++) {
                var cbox = (DataGridViewComboBoxCell)injectorGrid.Rows[i].Cells[0];
                foreach (var defi in Defs.Items) {
                    cbox.Items.Add(defi.Name);
                }
            }
        }

        private static void InjectorGridOnUserAddedRow(object sender, DataGridViewRowEventArgs e) {
            var cbox = (DataGridViewComboBoxCell) e.Row.Cells[0];
            foreach (var defi in Defs.Items) {
                cbox.Items.Add(defi.Name);
            }
            e.Row.Cells[1].Value = 1;
        }

        private void InjectItems_Click(object sender, EventArgs e) {
            var items = new List<Item>();
            for (var i = 0; i < injectorGrid.RowCount; i++) {
                var cbox = (DataGridViewComboBoxCell)injectorGrid.Rows[i].Cells[0];
                if(cbox.Value == null) continue;
                var item = Defs.ItemByName(cbox.Value.ToString());
                if (item == null) continue;

                var consumable = BitConverter.GetBytes(item.Id2)[3] == 0x40;
                var quantity = 1;
                if (consumable) {
                    try {
                        var quantityString = injectorGrid.Rows[i].Cells[1].Value.ToString();
                        int.TryParse(quantityString, out quantity);
                    } catch {
                        Diag.WriteLine($"[Item Injecter] Invalid quantity for {cbox.Value}");
                    }
                }

                try {
                    new AddItem(new Item {
                        Id1 = item.Id1,
                        Id2 = item.Id2,
                        Consumable = consumable
                    }, quantity).Execute();

                    MetroMessageBox.Show(this, "Items Injected!", ":3", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                } catch (Exception ex) {
                    MetroMessageBox.Show(this, ex.Message, "Failed to inject items :(", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
