using System;
using System.Collections.Generic;
using System.Linq;
using MemoryLibrary;
using SekiroSpeedrunUtil.injects;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.ui {
    public partial class FormMain {
        private void BtnTest_Click(object sender, EventArgs e) {
            var confetti = Defs.ItemByName("divine confetti");
            new AddItem(confetti, 8).Execute();
            // new AddItem()
        }

        private void CboxAreaTeleport_SelectedIndexChanged(object sender, EventArgs e) {
            var area = cboxAreaTeleport.SelectedItem.ToString().Area();
            if (area == null) return;

            Teleporter.Teleport(area);
        }

        private void BtnCoordTeleport_Click(object sender, EventArgs e) {

        }

        private void BtnTeleportToCoordinates_Click(object sender, EventArgs e) {
            var sekiro = Utils.Sekiro();
            if (sekiro == null) return;


            var cx = BitConverter.GetBytes(float.Parse(coordX.Text));
            var cy = BitConverter.GetBytes(float.Parse(coordY.Text));
            var cz = BitConverter.GetBytes(float.Parse(coordZ.Text));

            var full = new byte[cx.Length + cy.Length + cz.Length];

            Buffer.BlockCopy(cx, 0, full, 0, cx.Length);
            Buffer.BlockCopy(cy, 0, full, cx.Length, cy.Length);
            Buffer.BlockCopy(cz, 0, full, cx.Length + cy.Length,
                cx.Length);


            var remoteProc = new RemoteProcess(sekiro);
            var offsets = new byte[] { 0x48, 0x28, 0x80 };
            var addr = new IntPtr(0x143B67DF0);
            addr = offsets.Aggregate(addr, (current, offset) => remoteProc.Read<IntPtr>(current) + offset);
            //remoteProc.Write<byte[]>(addr, full);
            remoteProc.WriteBytes(addr, full);

            Diag.WriteLine(BitConverter.ToString(full).Replace("-", ""));

        }

        private void CboxIdolTeleport_SelectedIndexChanged(object sender, EventArgs e) {
            var idol = cboxIdolTeleport.SelectedItem.ToString().Idol();
            if (idol == null) {
                Diag.WriteLine($"Invalid Idol {cboxIdolTeleport.SelectedItem}");
                return;
            }
            new IdolTeleport(idol).Execute();
        }

        private void CboxBossTeleport_SelectedIndexChanged(object sender, EventArgs e) {
            var boss = cboxBossTeleport.SelectedItem.ToString().Boss();
            if (boss == null) return;
            Teleporter.Teleport(boss);
        }

        private SaveManager _saveManager;
        private void BtnSaveManager_Click(object sender, EventArgs e) {
            if (_saveManager == null) {
                _saveManager = new SaveManager();
                _saveManager.FormClosed += (o, args) => _saveManager = null;
                _saveManager.Show();
                return;
            }
            _saveManager.BringToFront();
        }

        private void BtnLoadCurrentCoords_Click(object sender, System.EventArgs e) {
            try {
                var coords = (Vector3) PlayerPos.Value();
                coordX.Text = coords.X.ToString();
                coordY.Text = coords.Y.ToString();
                coordZ.Text = coords.Z.ToString();
            } catch {
                // Ignored 
            }
        }

        private void BtnDebug_Click(object sender, System.EventArgs e) {
           // _debugger.Show();
        }

        private void BtnInventorySpider_Click(object sender, EventArgs e) {
            var sekiro = Utils.Sekiro();
            if (sekiro == null) return;

            using (var remoteProc = new RemoteProcess(sekiro)) {
                var address = remoteProc.Read<IntPtr>(new IntPtr(0x143B49D10)) + 0x2E30;

                var items = new List<byte[]>();

                while (remoteProc.Read<byte>(address) != (byte)0x0) {
                    var item = remoteProc.ReadBytes(address, 16);
                    items.Add(item);
                    address += 0x10;

                }
                Diag.WriteLine($"Spidered {items.Count} items");

                new InvSpider(items).Show();
            }
        }

        private void CboxLastIdol_SelectedIndexChanged(object sender, System.EventArgs e) {
            Diag.WriteLine("LAST IDOL SET!");
            var idol = cboxLastIdol.SelectedItem.ToString().Idol();
            if (idol == null) return;
            var idolId = idol.Id;

            var remoteProc = RemoteProc.Instance();
            if (remoteProc == null) return;

            var pointer = Defs.PointerByName("LastCommutedIdol");
            if (pointer == null || pointer.BasePtr() == IntPtr.Zero) return;
            remoteProc.Write(pointer.GetAddress(remoteProc), idolId);
        }

    }
}
