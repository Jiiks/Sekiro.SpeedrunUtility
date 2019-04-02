namespace SekiroSpeedrunUtil.ui
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnTest = new MetroFramework.Controls.MetroButton();
            this.cboxAreaTeleport = new MetroFramework.Controls.MetroComboBox();
            this.btnReloadSetups = new MetroFramework.Controls.MetroButton();
            this.btnAddSetup = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnEditSetup = new MetroFramework.Controls.MetroButton();
            this.btnLoadSetup = new MetroFramework.Controls.MetroButton();
            this.btnRemoveSetup = new MetroFramework.Controls.MetroButton();
            this.cboxCustomTeleport = new MetroFramework.Controls.MetroComboBox();
            this.btnLoadCurrentCoords = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cboxBossTeleport = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboxIdolTeleport = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnTeleportToCoordinates = new MetroFramework.Controls.MetroButton();
            this.coordZ = new MetroFramework.Controls.MetroTextBox();
            this.coordY = new MetroFramework.Controls.MetroTextBox();
            this.coordX = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.lblPosZ = new MetroFramework.Controls.MetroLabel();
            this.lblPosY = new MetroFramework.Controls.MetroLabel();
            this.lblPosX = new MetroFramework.Controls.MetroLabel();
            this.btnCoordTeleport = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblGlobalStatus = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cboxLastIdol = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnDebug = new MetroFramework.Controls.MetroButton();
            this.btnInventorySpider = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.lblPosture = new MetroFramework.Controls.MetroLabel();
            this.lblHealth = new MetroFramework.Controls.MetroLabel();
            this.lblIgt = new MetroFramework.Controls.MetroLabel();
            this.lblLoading = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.updateLink = new MetroFramework.Controls.MetroLink();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.cbOverlayMode = new MetroFramework.Controls.MetroCheckBox();
            this.cbToastSounds = new MetroFramework.Controls.MetroCheckBox();
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.pageHotkeys = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.hotkeyLoadQuick = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.hotkeyLoadSave = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.hotkeyBackupSave = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.hotkeyTeleportToCoordinates = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.hotkeySaveCurrentCoordinates = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tabSaveManager = new MetroFramework.Controls.MetroTabPage();
            this.smPseudoReadonly = new MetroFramework.Controls.MetroCheckBox();
            this.smQuickSave = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.smDelete = new MetroFramework.Controls.MetroButton();
            this.smLoad = new MetroFramework.Controls.MetroButton();
            this.smSave = new MetroFramework.Controls.MetroButton();
            this.smOpenSavesDir = new MetroFramework.Controls.MetroButton();
            this.smDelProfile = new MetroFramework.Controls.MetroButton();
            this.smProfiles = new MetroFramework.Controls.MetroComboBox();
            this.smSavesList = new MetroFramework.Controls.MetroListView();
            this.smAddProfile = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.RenderFlags = new MetroFramework.Controls.MetroPanel();
            this.AllFlags = new MetroFramework.Controls.MetroPanel();
            this.PlayerFlags = new MetroFramework.Controls.MetroPanel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnSpider = new MetroFramework.Controls.MetroButton();
            this.btnSaveSpider = new MetroFramework.Controls.MetroButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.itemGrid = new MetroFramework.Controls.MetroGrid();
            this.SpiderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpiderName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SpiderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpiderStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tbDebug = new MetroFramework.Controls.MetroTextBox();
            this.toast = new MetroFramework.Controls.MetroPanel();
            this.toastMsg = new MetroFramework.Controls.MetroLabel();
            this.btnInfo = new MetroFramework.Controls.MetroLink();
            this.lblTinyTitle = new MetroFramework.Controls.MetroLabel();
            this.groupBox4.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pageHotkeys.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.tabSaveManager.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.toast.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(861, 175);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTest.UseSelectable = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // cboxAreaTeleport
            // 
            this.cboxAreaTeleport.FormattingEnabled = true;
            this.cboxAreaTeleport.ItemHeight = 23;
            this.cboxAreaTeleport.Location = new System.Drawing.Point(71, 12);
            this.cboxAreaTeleport.Name = "cboxAreaTeleport";
            this.cboxAreaTeleport.Size = new System.Drawing.Size(201, 29);
            this.cboxAreaTeleport.Style = MetroFramework.MetroColorStyle.Teal;
            this.cboxAreaTeleport.TabIndex = 1;
            this.cboxAreaTeleport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboxAreaTeleport.UseSelectable = true;
            this.cboxAreaTeleport.SelectedIndexChanged += new System.EventHandler(this.CboxAreaTeleport_SelectedIndexChanged);
            // 
            // btnReloadSetups
            // 
            this.btnReloadSetups.Enabled = false;
            this.btnReloadSetups.Location = new System.Drawing.Point(137, 198);
            this.btnReloadSetups.Name = "btnReloadSetups";
            this.btnReloadSetups.Size = new System.Drawing.Size(50, 23);
            this.btnReloadSetups.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnReloadSetups.TabIndex = 22;
            this.btnReloadSetups.Text = "Reload";
            this.btnReloadSetups.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReloadSetups.UseSelectable = true;
            // 
            // btnAddSetup
            // 
            this.btnAddSetup.Enabled = false;
            this.btnAddSetup.Location = new System.Drawing.Point(191, 198);
            this.btnAddSetup.Name = "btnAddSetup";
            this.btnAddSetup.Size = new System.Drawing.Size(23, 23);
            this.btnAddSetup.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAddSetup.TabIndex = 8;
            this.btnAddSetup.Text = "+";
            this.btnAddSetup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddSetup.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 168);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Setups";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnEditSetup
            // 
            this.btnEditSetup.Enabled = false;
            this.btnEditSetup.Location = new System.Drawing.Point(220, 198);
            this.btnEditSetup.Name = "btnEditSetup";
            this.btnEditSetup.Size = new System.Drawing.Size(23, 23);
            this.btnEditSetup.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEditSetup.TabIndex = 19;
            this.btnEditSetup.Text = "e";
            this.btnEditSetup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEditSetup.UseSelectable = true;
            // 
            // btnLoadSetup
            // 
            this.btnLoadSetup.Enabled = false;
            this.btnLoadSetup.Location = new System.Drawing.Point(71, 198);
            this.btnLoadSetup.Name = "btnLoadSetup";
            this.btnLoadSetup.Size = new System.Drawing.Size(60, 23);
            this.btnLoadSetup.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnLoadSetup.TabIndex = 21;
            this.btnLoadSetup.Text = "Load";
            this.btnLoadSetup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLoadSetup.UseSelectable = true;
            // 
            // btnRemoveSetup
            // 
            this.btnRemoveSetup.Enabled = false;
            this.btnRemoveSetup.Location = new System.Drawing.Point(249, 198);
            this.btnRemoveSetup.Name = "btnRemoveSetup";
            this.btnRemoveSetup.Size = new System.Drawing.Size(23, 23);
            this.btnRemoveSetup.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnRemoveSetup.TabIndex = 20;
            this.btnRemoveSetup.Text = "-";
            this.btnRemoveSetup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemoveSetup.UseSelectable = true;
            // 
            // cboxCustomTeleport
            // 
            this.cboxCustomTeleport.Enabled = false;
            this.cboxCustomTeleport.FormattingEnabled = true;
            this.cboxCustomTeleport.ItemHeight = 23;
            this.cboxCustomTeleport.Location = new System.Drawing.Point(71, 163);
            this.cboxCustomTeleport.Name = "cboxCustomTeleport";
            this.cboxCustomTeleport.Size = new System.Drawing.Size(201, 29);
            this.cboxCustomTeleport.Style = MetroFramework.MetroColorStyle.Teal;
            this.cboxCustomTeleport.TabIndex = 18;
            this.cboxCustomTeleport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboxCustomTeleport.UseSelectable = true;
            // 
            // btnLoadCurrentCoords
            // 
            this.btnLoadCurrentCoords.Location = new System.Drawing.Point(191, 227);
            this.btnLoadCurrentCoords.Name = "btnLoadCurrentCoords";
            this.btnLoadCurrentCoords.Size = new System.Drawing.Size(81, 27);
            this.btnLoadCurrentCoords.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnLoadCurrentCoords.TabIndex = 7;
            this.btnLoadCurrentCoords.Text = "Current";
            this.btnLoadCurrentCoords.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLoadCurrentCoords.UseSelectable = true;
            this.btnLoadCurrentCoords.Click += new System.EventHandler(this.BtnLoadCurrentCoords_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 87);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Boss";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cboxBossTeleport
            // 
            this.cboxBossTeleport.FormattingEnabled = true;
            this.cboxBossTeleport.ItemHeight = 23;
            this.cboxBossTeleport.Location = new System.Drawing.Point(71, 82);
            this.cboxBossTeleport.Name = "cboxBossTeleport";
            this.cboxBossTeleport.Size = new System.Drawing.Size(201, 29);
            this.cboxBossTeleport.Style = MetroFramework.MetroColorStyle.Teal;
            this.cboxBossTeleport.TabIndex = 16;
            this.cboxBossTeleport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboxBossTeleport.UseSelectable = true;
            this.cboxBossTeleport.SelectedIndexChanged += new System.EventHandler(this.CboxBossTeleport_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Idol";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cboxIdolTeleport
            // 
            this.cboxIdolTeleport.FormattingEnabled = true;
            this.cboxIdolTeleport.ItemHeight = 23;
            this.cboxIdolTeleport.Location = new System.Drawing.Point(71, 47);
            this.cboxIdolTeleport.Name = "cboxIdolTeleport";
            this.cboxIdolTeleport.Size = new System.Drawing.Size(201, 29);
            this.cboxIdolTeleport.Style = MetroFramework.MetroColorStyle.Teal;
            this.cboxIdolTeleport.TabIndex = 14;
            this.cboxIdolTeleport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboxIdolTeleport.UseSelectable = true;
            this.cboxIdolTeleport.SelectedIndexChanged += new System.EventHandler(this.CboxIdolTeleport_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Area";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnTeleportToCoordinates
            // 
            this.btnTeleportToCoordinates.Location = new System.Drawing.Point(191, 260);
            this.btnTeleportToCoordinates.Name = "btnTeleportToCoordinates";
            this.btnTeleportToCoordinates.Size = new System.Drawing.Size(81, 27);
            this.btnTeleportToCoordinates.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnTeleportToCoordinates.TabIndex = 13;
            this.btnTeleportToCoordinates.Text = "Teleport";
            this.btnTeleportToCoordinates.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTeleportToCoordinates.UseSelectable = true;
            this.btnTeleportToCoordinates.Click += new System.EventHandler(this.BtnTeleportToCoordinates_Click);
            // 
            // coordZ
            // 
            // 
            // 
            // 
            this.coordZ.CustomButton.Image = null;
            this.coordZ.CustomButton.Location = new System.Drawing.Point(13, 2);
            this.coordZ.CustomButton.Name = "";
            this.coordZ.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.coordZ.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.coordZ.CustomButton.TabIndex = 1;
            this.coordZ.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.coordZ.CustomButton.UseSelectable = true;
            this.coordZ.CustomButton.Visible = false;
            this.coordZ.Lines = new string[0];
            this.coordZ.Location = new System.Drawing.Point(154, 279);
            this.coordZ.MaxLength = 32767;
            this.coordZ.Name = "coordZ";
            this.coordZ.PasswordChar = '\0';
            this.coordZ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.coordZ.SelectedText = "";
            this.coordZ.SelectionLength = 0;
            this.coordZ.SelectionStart = 0;
            this.coordZ.ShortcutsEnabled = true;
            this.coordZ.Size = new System.Drawing.Size(31, 20);
            this.coordZ.Style = MetroFramework.MetroColorStyle.Teal;
            this.coordZ.TabIndex = 12;
            this.coordZ.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.coordZ.UseSelectable = true;
            this.coordZ.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.coordZ.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // coordY
            // 
            // 
            // 
            // 
            this.coordY.CustomButton.Image = null;
            this.coordY.CustomButton.Location = new System.Drawing.Point(13, 2);
            this.coordY.CustomButton.Name = "";
            this.coordY.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.coordY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.coordY.CustomButton.TabIndex = 1;
            this.coordY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.coordY.CustomButton.UseSelectable = true;
            this.coordY.CustomButton.Visible = false;
            this.coordY.Lines = new string[0];
            this.coordY.Location = new System.Drawing.Point(154, 253);
            this.coordY.MaxLength = 32767;
            this.coordY.Name = "coordY";
            this.coordY.PasswordChar = '\0';
            this.coordY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.coordY.SelectedText = "";
            this.coordY.SelectionLength = 0;
            this.coordY.SelectionStart = 0;
            this.coordY.ShortcutsEnabled = true;
            this.coordY.Size = new System.Drawing.Size(31, 20);
            this.coordY.Style = MetroFramework.MetroColorStyle.Teal;
            this.coordY.TabIndex = 11;
            this.coordY.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.coordY.UseSelectable = true;
            this.coordY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.coordY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // coordX
            // 
            // 
            // 
            // 
            this.coordX.CustomButton.Image = null;
            this.coordX.CustomButton.Location = new System.Drawing.Point(13, 2);
            this.coordX.CustomButton.Name = "";
            this.coordX.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.coordX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.coordX.CustomButton.TabIndex = 1;
            this.coordX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.coordX.CustomButton.UseSelectable = true;
            this.coordX.CustomButton.Visible = false;
            this.coordX.Lines = new string[0];
            this.coordX.Location = new System.Drawing.Point(154, 227);
            this.coordX.MaxLength = 32767;
            this.coordX.Name = "coordX";
            this.coordX.PasswordChar = '\0';
            this.coordX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.coordX.SelectedText = "";
            this.coordX.SelectionLength = 0;
            this.coordX.SelectionStart = 0;
            this.coordX.ShortcutsEnabled = true;
            this.coordX.Size = new System.Drawing.Size(31, 20);
            this.coordX.Style = MetroFramework.MetroColorStyle.Teal;
            this.coordX.TabIndex = 10;
            this.coordX.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.coordX.UseSelectable = true;
            this.coordX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.coordX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.Style = MetroFramework.MetroColorStyle.Teal;
            this.label4.TabIndex = 7;
            this.label4.Text = "X:";
            this.label4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.Style = MetroFramework.MetroColorStyle.Teal;
            this.label3.TabIndex = 9;
            this.label3.Text = "Z:";
            this.label3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.Style = MetroFramework.MetroColorStyle.Teal;
            this.label2.TabIndex = 8;
            this.label2.Text = "Y:";
            this.label2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPosZ
            // 
            this.lblPosZ.AutoSize = true;
            this.lblPosZ.Location = new System.Drawing.Point(14, 61);
            this.lblPosZ.Name = "lblPosZ";
            this.lblPosZ.Size = new System.Drawing.Size(20, 19);
            this.lblPosZ.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblPosZ.TabIndex = 5;
            this.lblPosZ.Text = "Z:";
            this.lblPosZ.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(14, 42);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(20, 19);
            this.lblPosY.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblPosY.TabIndex = 4;
            this.lblPosY.Text = "Y:";
            this.lblPosY.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(14, 23);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(20, 19);
            this.lblPosX.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblPosX.TabIndex = 3;
            this.lblPosX.Text = "X:";
            this.lblPosX.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnCoordTeleport
            // 
            this.btnCoordTeleport.Location = new System.Drawing.Point(6, 19);
            this.btnCoordTeleport.Name = "btnCoordTeleport";
            this.btnCoordTeleport.Size = new System.Drawing.Size(121, 23);
            this.btnCoordTeleport.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCoordTeleport.TabIndex = 3;
            this.btnCoordTeleport.Text = "Coordinate";
            this.btnCoordTeleport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCoordTeleport.UseSelectable = true;
            this.btnCoordTeleport.Click += new System.EventHandler(this.BtnCoordTeleport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCoordTeleport);
            this.groupBox4.ForeColor = System.Drawing.Color.Gray;
            this.groupBox4.Location = new System.Drawing.Point(1142, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Debugs";
            // 
            // lblGlobalStatus
            // 
            this.lblGlobalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGlobalStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblGlobalStatus.Location = new System.Drawing.Point(23, 482);
            this.lblGlobalStatus.Name = "lblGlobalStatus";
            this.lblGlobalStatus.Size = new System.Drawing.Size(615, 23);
            this.lblGlobalStatus.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblGlobalStatus.TabIndex = 9;
            this.lblGlobalStatus.Text = "Status";
            this.lblGlobalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGlobalStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.cboxLastIdol);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.btnLoadCurrentCoords);
            this.metroPanel1.Controls.Add(this.btnReloadSetups);
            this.metroPanel1.Controls.Add(this.coordY);
            this.metroPanel1.Controls.Add(this.coordX);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.cboxCustomTeleport);
            this.metroPanel1.Controls.Add(this.btnAddSetup);
            this.metroPanel1.Controls.Add(this.coordZ);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.cboxBossTeleport);
            this.metroPanel1.Controls.Add(this.cboxAreaTeleport);
            this.metroPanel1.Controls.Add(this.btnRemoveSetup);
            this.metroPanel1.Controls.Add(this.btnEditSetup);
            this.metroPanel1.Controls.Add(this.btnTeleportToCoordinates);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cboxIdolTeleport);
            this.metroPanel1.Controls.Add(this.btnLoadSetup);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 10);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(285, 330);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(13, 127);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(57, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "Last Idol";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cboxLastIdol
            // 
            this.cboxLastIdol.FormattingEnabled = true;
            this.cboxLastIdol.ItemHeight = 23;
            this.cboxLastIdol.Items.AddRange(new object[] {
            "Dilapidated Temple",
            "Outskirts Wall - Gate Path",
            "Outskirts Wall - Stairway",
            "Underbridge Valley",
            "Ashina Castle Gate Fortress",
            "Ashina Castle Gate",
            "Ashina Outskirt",
            "Flames of Hatred",
            "Ashina Castle",
            "Upper Tower - Antechamber",
            "Castle Tower Lookout",
            "Upper Tower - Kuro\'s Room",
            "Great Serpent Shrine",
            "Abandoned Dungeon Entrance",
            "Old Grave",
            "Upper Tower - Ashina Dojo",
            "Ashina Reservoir",
            "Near Secret Passage",
            "Underground Waterway",
            "Bottomless Hole",
            "Senpou Temple, Mt. Kongo",
            "Shugendo",
            "Temple Grounds",
            "Main Hall",
            "Inner Sanctum",
            "Sunken Valley Cavern",
            "Bell Demon\'s Temple",
            "Under-Shrine Valley",
            "Sunkey Valley",
            "Gun Fort",
            "Riven Cave",
            "Bodhisattva Valley",
            "Guardian Ape\'s Watering Hole",
            "Ashina Depths",
            "Poison Pool",
            "Guardian Ape\'s Burrow",
            "Hidden Forest",
            "Mibu Village",
            "Water Mill",
            "Wedding Cave Door",
            "Fountainhead Palace",
            "Vermillion Bridge",
            "Mibu Manor",
            "Flover Viewing Stage",
            "Great Sakura",
            "Palace Grounds",
            "Feeding Grounds",
            "Near Pot Noble",
            "Sanctuary",
            "Dragonsping - Hirata Estate",
            "Estate Path",
            "Bamboo Thicket Slope",
            "Hirata Estate - Main Hall",
            "Hirata Audience Chamber",
            "Hirata Estate - Hidden Temple"});
            this.cboxLastIdol.Location = new System.Drawing.Point(71, 122);
            this.cboxLastIdol.Name = "cboxLastIdol";
            this.cboxLastIdol.Size = new System.Drawing.Size(201, 29);
            this.cboxLastIdol.Style = MetroFramework.MetroColorStyle.Teal;
            this.cboxLastIdol.TabIndex = 24;
            this.cboxLastIdol.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboxLastIdol.UseSelectable = true;
            this.cboxLastIdol.SelectedIndexChanged += new System.EventHandler(this.CboxLastIdol_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Teleports";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(550, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Extra";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(1126, 445);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(235, 330);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel2.TabIndex = 23;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(1203, 351);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(20, 20);
            this.btnDebug.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDebug.TabIndex = 29;
            this.btnDebug.Text = "D";
            this.btnDebug.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDebug.UseSelectable = true;
            this.btnDebug.Click += new System.EventHandler(this.BtnDebug_Click);
            // 
            // btnInventorySpider
            // 
            this.btnInventorySpider.Location = new System.Drawing.Point(1005, 262);
            this.btnInventorySpider.Name = "btnInventorySpider";
            this.btnInventorySpider.Size = new System.Drawing.Size(207, 23);
            this.btnInventorySpider.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnInventorySpider.TabIndex = 12;
            this.btnInventorySpider.Text = "Inventory Spider";
            this.btnInventorySpider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnInventorySpider.UseSelectable = true;
            this.btnInventorySpider.Click += new System.EventHandler(this.BtnInventorySpider_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(310, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(31, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Info";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.lblPosture);
            this.metroPanel3.Controls.Add(this.lblHealth);
            this.metroPanel3.Controls.Add(this.lblIgt);
            this.metroPanel3.Controls.Add(this.lblLoading);
            this.metroPanel3.Controls.Add(this.lblPosZ);
            this.metroPanel3.Controls.Add(this.lblPosY);
            this.metroPanel3.Controls.Add(this.lblPosX);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(305, 10);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(230, 330);
            this.metroPanel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel3.TabIndex = 25;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // lblPosture
            // 
            this.lblPosture.AutoSize = true;
            this.lblPosture.Location = new System.Drawing.Point(14, 142);
            this.lblPosture.Name = "lblPosture";
            this.lblPosture.Size = new System.Drawing.Size(55, 19);
            this.lblPosture.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblPosture.TabIndex = 9;
            this.lblPosture.Text = "Posture:";
            this.lblPosture.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(14, 122);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(49, 19);
            this.lblHealth.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblHealth.TabIndex = 8;
            this.lblHealth.Text = "Health:";
            this.lblHealth.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblIgt
            // 
            this.lblIgt.AutoSize = true;
            this.lblIgt.Location = new System.Drawing.Point(14, 101);
            this.lblIgt.Name = "lblIgt";
            this.lblIgt.Size = new System.Drawing.Size(31, 19);
            this.lblIgt.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblIgt.TabIndex = 7;
            this.lblIgt.Text = "IGT:";
            this.lblIgt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(14, 82);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(70, 19);
            this.lblLoading.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblLoading.TabIndex = 6;
            this.lblLoading.Text = "Loading: 0";
            this.lblLoading.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // updateLink
            // 
            this.updateLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateLink.Location = new System.Drawing.Point(644, 482);
            this.updateLink.Name = "updateLink";
            this.updateLink.Size = new System.Drawing.Size(179, 23);
            this.updateLink.Style = MetroFramework.MetroColorStyle.Teal;
            this.updateLink.TabIndex = 27;
            this.updateLink.Text = "[v0.0.0.0 - Check for updates]";
            this.updateLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateLink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.updateLink.UseSelectable = true;
            this.updateLink.Click += new System.EventHandler(this.UpdateLink_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.cbOverlayMode);
            this.mainPanel.Controls.Add(this.cbToastSounds);
            this.mainPanel.Controls.Add(this.metroLabel7);
            this.mainPanel.Controls.Add(this.metroLabel6);
            this.mainPanel.Controls.Add(this.metroLabel5);
            this.mainPanel.Controls.Add(this.metroPanel3);
            this.mainPanel.Controls.Add(this.metroPanel1);
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(5, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(782, 345);
            this.mainPanel.Style = MetroFramework.MetroColorStyle.Teal;
            this.mainPanel.TabIndex = 28;
            this.mainPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // cbOverlayMode
            // 
            this.cbOverlayMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOverlayMode.Location = new System.Drawing.Point(550, 49);
            this.cbOverlayMode.Name = "cbOverlayMode";
            this.cbOverlayMode.Size = new System.Drawing.Size(121, 15);
            this.cbOverlayMode.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbOverlayMode.TabIndex = 35;
            this.cbOverlayMode.Text = "Overlay Mode";
            this.cbOverlayMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbOverlayMode.UseSelectable = true;
            this.cbOverlayMode.CheckedChanged += new System.EventHandler(this.CbOverlayMode_CheckedChanged);
            // 
            // cbToastSounds
            // 
            this.cbToastSounds.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbToastSounds.Checked = true;
            this.cbToastSounds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbToastSounds.Location = new System.Drawing.Point(550, 28);
            this.cbToastSounds.Name = "cbToastSounds";
            this.cbToastSounds.Size = new System.Drawing.Size(121, 15);
            this.cbToastSounds.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbToastSounds.TabIndex = 34;
            this.cbToastSounds.Text = "Toast Sounds";
            this.cbToastSounds.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbToastSounds.UseSelectable = true;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.pageHotkeys);
            this.mainTabControl.Controls.Add(this.tabSaveManager);
            this.mainTabControl.Controls.Add(this.metroTabPage3);
            this.mainTabControl.Controls.Add(this.metroTabPage1);
            this.mainTabControl.Controls.Add(this.metroTabPage2);
            this.mainTabControl.ItemSize = new System.Drawing.Size(50, 30);
            this.mainTabControl.Location = new System.Drawing.Point(23, 73);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 400);
            this.mainTabControl.Style = MetroFramework.MetroColorStyle.Teal;
            this.mainTabControl.TabIndex = 29;
            this.mainTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainTabControl.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.mainPanel);
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseCustomBackColor = true;
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // pageHotkeys
            // 
            this.pageHotkeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pageHotkeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageHotkeys.Controls.Add(this.metroPanel4);
            this.pageHotkeys.HorizontalScrollbarBarColor = true;
            this.pageHotkeys.HorizontalScrollbarHighlightOnWheel = false;
            this.pageHotkeys.HorizontalScrollbarSize = 10;
            this.pageHotkeys.Location = new System.Drawing.Point(4, 34);
            this.pageHotkeys.Name = "pageHotkeys";
            this.pageHotkeys.Size = new System.Drawing.Size(792, 362);
            this.pageHotkeys.TabIndex = 1;
            this.pageHotkeys.Text = "Hotkeys";
            this.pageHotkeys.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pageHotkeys.UseCustomBackColor = true;
            this.pageHotkeys.VerticalScrollbarBarColor = true;
            this.pageHotkeys.VerticalScrollbarHighlightOnWheel = false;
            this.pageHotkeys.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroLabel16);
            this.metroPanel4.Controls.Add(this.hotkeyLoadQuick);
            this.metroPanel4.Controls.Add(this.metroLabel13);
            this.metroPanel4.Controls.Add(this.hotkeyLoadSave);
            this.metroPanel4.Controls.Add(this.metroLabel12);
            this.metroPanel4.Controls.Add(this.hotkeyBackupSave);
            this.metroPanel4.Controls.Add(this.metroLabel11);
            this.metroPanel4.Controls.Add(this.hotkeyTeleportToCoordinates);
            this.metroPanel4.Controls.Add(this.metroLabel10);
            this.metroPanel4.Controls.Add(this.hotkeySaveCurrentCoordinates);
            this.metroPanel4.Controls.Add(this.metroLabel9);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(3, 3);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(783, 348);
            this.metroPanel4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(13, 176);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(120, 19);
            this.metroLabel16.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel16.TabIndex = 21;
            this.metroLabel16.Text = "Load last quicksave";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // hotkeyLoadQuick
            // 
            // 
            // 
            // 
            this.hotkeyLoadQuick.CustomButton.Image = null;
            this.hotkeyLoadQuick.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.hotkeyLoadQuick.CustomButton.Name = "";
            this.hotkeyLoadQuick.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.hotkeyLoadQuick.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hotkeyLoadQuick.CustomButton.TabIndex = 1;
            this.hotkeyLoadQuick.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hotkeyLoadQuick.CustomButton.UseSelectable = true;
            this.hotkeyLoadQuick.CustomButton.Visible = false;
            this.hotkeyLoadQuick.Lines = new string[] {
        "F9"};
            this.hotkeyLoadQuick.Location = new System.Drawing.Point(172, 176);
            this.hotkeyLoadQuick.MaxLength = 32767;
            this.hotkeyLoadQuick.Name = "hotkeyLoadQuick";
            this.hotkeyLoadQuick.PasswordChar = '\0';
            this.hotkeyLoadQuick.ReadOnly = true;
            this.hotkeyLoadQuick.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hotkeyLoadQuick.SelectedText = "";
            this.hotkeyLoadQuick.SelectionLength = 0;
            this.hotkeyLoadQuick.SelectionStart = 0;
            this.hotkeyLoadQuick.ShortcutsEnabled = true;
            this.hotkeyLoadQuick.ShowClearButton = true;
            this.hotkeyLoadQuick.Size = new System.Drawing.Size(146, 20);
            this.hotkeyLoadQuick.Style = MetroFramework.MetroColorStyle.Teal;
            this.hotkeyLoadQuick.TabIndex = 20;
            this.hotkeyLoadQuick.Text = "F9";
            this.hotkeyLoadQuick.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hotkeyLoadQuick.UseSelectable = true;
            this.hotkeyLoadQuick.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hotkeyLoadQuick.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(13, 150);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(141, 19);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel13.TabIndex = 19;
            this.metroLabel13.Text = "Load last selected save";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // hotkeyLoadSave
            // 
            // 
            // 
            // 
            this.hotkeyLoadSave.CustomButton.Image = null;
            this.hotkeyLoadSave.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.hotkeyLoadSave.CustomButton.Name = "";
            this.hotkeyLoadSave.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.hotkeyLoadSave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hotkeyLoadSave.CustomButton.TabIndex = 1;
            this.hotkeyLoadSave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hotkeyLoadSave.CustomButton.UseSelectable = true;
            this.hotkeyLoadSave.CustomButton.Visible = false;
            this.hotkeyLoadSave.Lines = new string[] {
        "F9"};
            this.hotkeyLoadSave.Location = new System.Drawing.Point(172, 150);
            this.hotkeyLoadSave.MaxLength = 32767;
            this.hotkeyLoadSave.Name = "hotkeyLoadSave";
            this.hotkeyLoadSave.PasswordChar = '\0';
            this.hotkeyLoadSave.ReadOnly = true;
            this.hotkeyLoadSave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hotkeyLoadSave.SelectedText = "";
            this.hotkeyLoadSave.SelectionLength = 0;
            this.hotkeyLoadSave.SelectionStart = 0;
            this.hotkeyLoadSave.ShortcutsEnabled = true;
            this.hotkeyLoadSave.ShowClearButton = true;
            this.hotkeyLoadSave.Size = new System.Drawing.Size(146, 20);
            this.hotkeyLoadSave.Style = MetroFramework.MetroColorStyle.Teal;
            this.hotkeyLoadSave.TabIndex = 18;
            this.hotkeyLoadSave.Text = "F9";
            this.hotkeyLoadSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hotkeyLoadSave.UseSelectable = true;
            this.hotkeyLoadSave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hotkeyLoadSave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(13, 124);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(80, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel12.TabIndex = 17;
            this.metroLabel12.Text = "Backup save";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // hotkeyBackupSave
            // 
            // 
            // 
            // 
            this.hotkeyBackupSave.CustomButton.Image = null;
            this.hotkeyBackupSave.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.hotkeyBackupSave.CustomButton.Name = "";
            this.hotkeyBackupSave.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.hotkeyBackupSave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hotkeyBackupSave.CustomButton.TabIndex = 1;
            this.hotkeyBackupSave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hotkeyBackupSave.CustomButton.UseSelectable = true;
            this.hotkeyBackupSave.CustomButton.Visible = false;
            this.hotkeyBackupSave.Lines = new string[] {
        "F8"};
            this.hotkeyBackupSave.Location = new System.Drawing.Point(172, 124);
            this.hotkeyBackupSave.MaxLength = 32767;
            this.hotkeyBackupSave.Name = "hotkeyBackupSave";
            this.hotkeyBackupSave.PasswordChar = '\0';
            this.hotkeyBackupSave.ReadOnly = true;
            this.hotkeyBackupSave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hotkeyBackupSave.SelectedText = "";
            this.hotkeyBackupSave.SelectionLength = 0;
            this.hotkeyBackupSave.SelectionStart = 0;
            this.hotkeyBackupSave.ShortcutsEnabled = true;
            this.hotkeyBackupSave.ShowClearButton = true;
            this.hotkeyBackupSave.Size = new System.Drawing.Size(146, 20);
            this.hotkeyBackupSave.Style = MetroFramework.MetroColorStyle.Teal;
            this.hotkeyBackupSave.TabIndex = 16;
            this.hotkeyBackupSave.Text = "F8";
            this.hotkeyBackupSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hotkeyBackupSave.UseSelectable = true;
            this.hotkeyBackupSave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hotkeyBackupSave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(13, 98);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(145, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Teleport to coordinates";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // hotkeyTeleportToCoordinates
            // 
            // 
            // 
            // 
            this.hotkeyTeleportToCoordinates.CustomButton.Image = null;
            this.hotkeyTeleportToCoordinates.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.hotkeyTeleportToCoordinates.CustomButton.Name = "";
            this.hotkeyTeleportToCoordinates.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.hotkeyTeleportToCoordinates.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hotkeyTeleportToCoordinates.CustomButton.TabIndex = 1;
            this.hotkeyTeleportToCoordinates.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hotkeyTeleportToCoordinates.CustomButton.UseSelectable = true;
            this.hotkeyTeleportToCoordinates.CustomButton.Visible = false;
            this.hotkeyTeleportToCoordinates.Lines = new string[] {
        "F2"};
            this.hotkeyTeleportToCoordinates.Location = new System.Drawing.Point(172, 98);
            this.hotkeyTeleportToCoordinates.MaxLength = 32767;
            this.hotkeyTeleportToCoordinates.Name = "hotkeyTeleportToCoordinates";
            this.hotkeyTeleportToCoordinates.PasswordChar = '\0';
            this.hotkeyTeleportToCoordinates.ReadOnly = true;
            this.hotkeyTeleportToCoordinates.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hotkeyTeleportToCoordinates.SelectedText = "";
            this.hotkeyTeleportToCoordinates.SelectionLength = 0;
            this.hotkeyTeleportToCoordinates.SelectionStart = 0;
            this.hotkeyTeleportToCoordinates.ShortcutsEnabled = true;
            this.hotkeyTeleportToCoordinates.ShowClearButton = true;
            this.hotkeyTeleportToCoordinates.Size = new System.Drawing.Size(146, 20);
            this.hotkeyTeleportToCoordinates.Style = MetroFramework.MetroColorStyle.Teal;
            this.hotkeyTeleportToCoordinates.TabIndex = 14;
            this.hotkeyTeleportToCoordinates.Text = "F2";
            this.hotkeyTeleportToCoordinates.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hotkeyTeleportToCoordinates.UseSelectable = true;
            this.hotkeyTeleportToCoordinates.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hotkeyTeleportToCoordinates.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(13, 70);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(153, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "Save current coordinates";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // hotkeySaveCurrentCoordinates
            // 
            // 
            // 
            // 
            this.hotkeySaveCurrentCoordinates.CustomButton.Image = null;
            this.hotkeySaveCurrentCoordinates.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.hotkeySaveCurrentCoordinates.CustomButton.Name = "";
            this.hotkeySaveCurrentCoordinates.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.hotkeySaveCurrentCoordinates.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hotkeySaveCurrentCoordinates.CustomButton.TabIndex = 1;
            this.hotkeySaveCurrentCoordinates.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hotkeySaveCurrentCoordinates.CustomButton.UseSelectable = true;
            this.hotkeySaveCurrentCoordinates.CustomButton.Visible = false;
            this.hotkeySaveCurrentCoordinates.Lines = new string[] {
        "F1"};
            this.hotkeySaveCurrentCoordinates.Location = new System.Drawing.Point(172, 70);
            this.hotkeySaveCurrentCoordinates.MaxLength = 32767;
            this.hotkeySaveCurrentCoordinates.Name = "hotkeySaveCurrentCoordinates";
            this.hotkeySaveCurrentCoordinates.PasswordChar = '\0';
            this.hotkeySaveCurrentCoordinates.ReadOnly = true;
            this.hotkeySaveCurrentCoordinates.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hotkeySaveCurrentCoordinates.SelectedText = "";
            this.hotkeySaveCurrentCoordinates.SelectionLength = 0;
            this.hotkeySaveCurrentCoordinates.SelectionStart = 0;
            this.hotkeySaveCurrentCoordinates.ShortcutsEnabled = true;
            this.hotkeySaveCurrentCoordinates.ShowClearButton = true;
            this.hotkeySaveCurrentCoordinates.Size = new System.Drawing.Size(146, 20);
            this.hotkeySaveCurrentCoordinates.Style = MetroFramework.MetroColorStyle.Teal;
            this.hotkeySaveCurrentCoordinates.TabIndex = 12;
            this.hotkeySaveCurrentCoordinates.Text = "F1";
            this.hotkeySaveCurrentCoordinates.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hotkeySaveCurrentCoordinates.UseSelectable = true;
            this.hotkeySaveCurrentCoordinates.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hotkeySaveCurrentCoordinates.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(13, 10);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(269, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "Hotkeys are disabled while this page is active";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabSaveManager
            // 
            this.tabSaveManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tabSaveManager.Controls.Add(this.smPseudoReadonly);
            this.tabSaveManager.Controls.Add(this.smQuickSave);
            this.tabSaveManager.Controls.Add(this.metroLabel15);
            this.tabSaveManager.Controls.Add(this.metroLabel14);
            this.tabSaveManager.Controls.Add(this.smDelete);
            this.tabSaveManager.Controls.Add(this.smLoad);
            this.tabSaveManager.Controls.Add(this.smSave);
            this.tabSaveManager.Controls.Add(this.smOpenSavesDir);
            this.tabSaveManager.Controls.Add(this.smDelProfile);
            this.tabSaveManager.Controls.Add(this.smProfiles);
            this.tabSaveManager.Controls.Add(this.smSavesList);
            this.tabSaveManager.Controls.Add(this.smAddProfile);
            this.tabSaveManager.HorizontalScrollbarBarColor = true;
            this.tabSaveManager.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSaveManager.HorizontalScrollbarSize = 10;
            this.tabSaveManager.Location = new System.Drawing.Point(4, 34);
            this.tabSaveManager.Name = "tabSaveManager";
            this.tabSaveManager.Size = new System.Drawing.Size(792, 362);
            this.tabSaveManager.TabIndex = 2;
            this.tabSaveManager.Text = "Save Manager";
            this.tabSaveManager.UseCustomBackColor = true;
            this.tabSaveManager.VerticalScrollbarBarColor = true;
            this.tabSaveManager.VerticalScrollbarHighlightOnWheel = false;
            this.tabSaveManager.VerticalScrollbarSize = 10;
            // 
            // smPseudoReadonly
            // 
            this.smPseudoReadonly.AutoSize = true;
            this.smPseudoReadonly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.smPseudoReadonly.Location = new System.Drawing.Point(572, 338);
            this.smPseudoReadonly.Name = "smPseudoReadonly";
            this.smPseudoReadonly.Size = new System.Drawing.Size(119, 15);
            this.smPseudoReadonly.Style = MetroFramework.MetroColorStyle.Yellow;
            this.smPseudoReadonly.TabIndex = 33;
            this.smPseudoReadonly.Text = "Pseudo Read-only";
            this.smPseudoReadonly.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smPseudoReadonly.UseSelectable = true;
            this.smPseudoReadonly.CheckedChanged += new System.EventHandler(this.SmPseudoReadonly_CheckedChanged);
            // 
            // smQuickSave
            // 
            // 
            // 
            // 
            this.smQuickSave.CustomButton.Image = null;
            this.smQuickSave.CustomButton.Location = new System.Drawing.Point(77, 2);
            this.smQuickSave.CustomButton.Name = "";
            this.smQuickSave.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.smQuickSave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.smQuickSave.CustomButton.TabIndex = 1;
            this.smQuickSave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.smQuickSave.CustomButton.UseSelectable = true;
            this.smQuickSave.CustomButton.Visible = false;
            this.smQuickSave.Lines = new string[] {
        "quicksave_%"};
            this.smQuickSave.Location = new System.Drawing.Point(697, 304);
            this.smQuickSave.MaxLength = 32767;
            this.smQuickSave.Name = "smQuickSave";
            this.smQuickSave.PasswordChar = '\0';
            this.smQuickSave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.smQuickSave.SelectedText = "";
            this.smQuickSave.SelectionLength = 0;
            this.smQuickSave.SelectionStart = 0;
            this.smQuickSave.ShortcutsEnabled = true;
            this.smQuickSave.Size = new System.Drawing.Size(95, 20);
            this.smQuickSave.Style = MetroFramework.MetroColorStyle.Teal;
            this.smQuickSave.TabIndex = 32;
            this.smQuickSave.Text = "quicksave_%";
            this.smQuickSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smQuickSave.UseSelectable = true;
            this.smQuickSave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.smQuickSave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(512, 303);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(179, 19);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel15.TabIndex = 31;
            this.metroLabel15.Text = "Default name for hotkey save";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel14
            // 
            this.metroLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(235, 301);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(297, 23);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel14.TabIndex = 30;
            this.metroLabel14.Text = "Doubleclick a save to rename";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // smDelete
            // 
            this.smDelete.Location = new System.Drawing.Point(441, 330);
            this.smDelete.Name = "smDelete";
            this.smDelete.Size = new System.Drawing.Size(95, 23);
            this.smDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.smDelete.TabIndex = 20;
            this.smDelete.Text = "Delete";
            this.smDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smDelete.UseSelectable = true;
            this.smDelete.Click += new System.EventHandler(this.SmDelete_Click);
            // 
            // smLoad
            // 
            this.smLoad.Location = new System.Drawing.Point(340, 330);
            this.smLoad.Name = "smLoad";
            this.smLoad.Size = new System.Drawing.Size(95, 23);
            this.smLoad.Style = MetroFramework.MetroColorStyle.Teal;
            this.smLoad.TabIndex = 19;
            this.smLoad.Text = "Load";
            this.smLoad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smLoad.UseSelectable = true;
            this.smLoad.Click += new System.EventHandler(this.SmLoad_Click);
            // 
            // smSave
            // 
            this.smSave.Location = new System.Drawing.Point(239, 330);
            this.smSave.Name = "smSave";
            this.smSave.Size = new System.Drawing.Size(95, 23);
            this.smSave.Style = MetroFramework.MetroColorStyle.Teal;
            this.smSave.TabIndex = 18;
            this.smSave.Text = "Save";
            this.smSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smSave.UseSelectable = true;
            this.smSave.Click += new System.EventHandler(this.SmSave_Click);
            // 
            // smOpenSavesDir
            // 
            this.smOpenSavesDir.Location = new System.Drawing.Point(697, 330);
            this.smOpenSavesDir.Name = "smOpenSavesDir";
            this.smOpenSavesDir.Size = new System.Drawing.Size(95, 23);
            this.smOpenSavesDir.Style = MetroFramework.MetroColorStyle.Teal;
            this.smOpenSavesDir.TabIndex = 17;
            this.smOpenSavesDir.Text = "Open Saves Dir";
            this.smOpenSavesDir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smOpenSavesDir.UseSelectable = true;
            this.smOpenSavesDir.Click += new System.EventHandler(this.SmOpenSavesDir_Click);
            // 
            // smDelProfile
            // 
            this.smDelProfile.Location = new System.Drawing.Point(108, 330);
            this.smDelProfile.Name = "smDelProfile";
            this.smDelProfile.Size = new System.Drawing.Size(95, 23);
            this.smDelProfile.Style = MetroFramework.MetroColorStyle.Teal;
            this.smDelProfile.TabIndex = 16;
            this.smDelProfile.Text = "Del Profile";
            this.smDelProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smDelProfile.UseSelectable = true;
            this.smDelProfile.Click += new System.EventHandler(this.SmDelProfile_Click);
            // 
            // smProfiles
            // 
            this.smProfiles.FormattingEnabled = true;
            this.smProfiles.ItemHeight = 23;
            this.smProfiles.Items.AddRange(new object[] {
            "default"});
            this.smProfiles.Location = new System.Drawing.Point(3, 295);
            this.smProfiles.Name = "smProfiles";
            this.smProfiles.Size = new System.Drawing.Size(200, 29);
            this.smProfiles.Style = MetroFramework.MetroColorStyle.Teal;
            this.smProfiles.TabIndex = 15;
            this.smProfiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smProfiles.UseSelectable = true;
            this.smProfiles.SelectedIndexChanged += new System.EventHandler(this.SmProfiles_SelectedIndexChanged);
            // 
            // smSavesList
            // 
            this.smSavesList.AutoArrange = false;
            this.smSavesList.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.smSavesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smSavesList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.smSavesList.FullRowSelect = true;
            this.smSavesList.LabelEdit = true;
            this.smSavesList.Location = new System.Drawing.Point(0, 14);
            this.smSavesList.MultiSelect = false;
            this.smSavesList.Name = "smSavesList";
            this.smSavesList.OwnerDraw = true;
            this.smSavesList.ShowGroups = false;
            this.smSavesList.Size = new System.Drawing.Size(792, 275);
            this.smSavesList.Style = MetroFramework.MetroColorStyle.Lime;
            this.smSavesList.TabIndex = 14;
            this.smSavesList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smSavesList.UseCompatibleStateImageBehavior = false;
            this.smSavesList.UseCustomBackColor = true;
            this.smSavesList.UseSelectable = true;
            this.smSavesList.View = System.Windows.Forms.View.List;
            // 
            // smAddProfile
            // 
            this.smAddProfile.Location = new System.Drawing.Point(3, 330);
            this.smAddProfile.Name = "smAddProfile";
            this.smAddProfile.Size = new System.Drawing.Size(95, 23);
            this.smAddProfile.Style = MetroFramework.MetroColorStyle.Teal;
            this.smAddProfile.TabIndex = 13;
            this.smAddProfile.Text = "Add Profile";
            this.smAddProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smAddProfile.UseSelectable = true;
            this.smAddProfile.Click += new System.EventHandler(this.SmAddProfile_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage3.Controls.Add(this.RenderFlags);
            this.metroTabPage3.Controls.Add(this.AllFlags);
            this.metroTabPage3.Controls.Add(this.PlayerFlags);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 34);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(792, 362);
            this.metroTabPage3.TabIndex = 4;
            this.metroTabPage3.Text = "Flags";
            this.metroTabPage3.UseCustomBackColor = true;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // RenderFlags
            // 
            this.RenderFlags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RenderFlags.HorizontalScrollbarBarColor = true;
            this.RenderFlags.HorizontalScrollbarHighlightOnWheel = false;
            this.RenderFlags.HorizontalScrollbarSize = 10;
            this.RenderFlags.Location = new System.Drawing.Point(521, 14);
            this.RenderFlags.Name = "RenderFlags";
            this.RenderFlags.Padding = new System.Windows.Forms.Padding(5);
            this.RenderFlags.Size = new System.Drawing.Size(253, 333);
            this.RenderFlags.TabIndex = 46;
            this.RenderFlags.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RenderFlags.VerticalScrollbarBarColor = true;
            this.RenderFlags.VerticalScrollbarHighlightOnWheel = false;
            this.RenderFlags.VerticalScrollbarSize = 10;
            // 
            // AllFlags
            // 
            this.AllFlags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllFlags.HorizontalScrollbarBarColor = true;
            this.AllFlags.HorizontalScrollbarHighlightOnWheel = false;
            this.AllFlags.HorizontalScrollbarSize = 10;
            this.AllFlags.Location = new System.Drawing.Point(262, 14);
            this.AllFlags.Name = "AllFlags";
            this.AllFlags.Padding = new System.Windows.Forms.Padding(5);
            this.AllFlags.Size = new System.Drawing.Size(253, 333);
            this.AllFlags.TabIndex = 45;
            this.AllFlags.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AllFlags.VerticalScrollbarBarColor = true;
            this.AllFlags.VerticalScrollbarHighlightOnWheel = false;
            this.AllFlags.VerticalScrollbarSize = 10;
            // 
            // PlayerFlags
            // 
            this.PlayerFlags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerFlags.HorizontalScrollbarBarColor = true;
            this.PlayerFlags.HorizontalScrollbarHighlightOnWheel = false;
            this.PlayerFlags.HorizontalScrollbarSize = 10;
            this.PlayerFlags.Location = new System.Drawing.Point(3, 14);
            this.PlayerFlags.Name = "PlayerFlags";
            this.PlayerFlags.Padding = new System.Windows.Forms.Padding(5);
            this.PlayerFlags.Size = new System.Drawing.Size(253, 333);
            this.PlayerFlags.TabIndex = 44;
            this.PlayerFlags.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PlayerFlags.VerticalScrollbarBarColor = true;
            this.PlayerFlags.VerticalScrollbarHighlightOnWheel = false;
            this.PlayerFlags.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage1.Controls.Add(this.btnSpider);
            this.metroTabPage1.Controls.Add(this.btnSaveSpider);
            this.metroTabPage1.Controls.Add(this.metroLabel17);
            this.metroTabPage1.Controls.Add(this.itemGrid);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 34);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(792, 362);
            this.metroTabPage1.TabIndex = 5;
            this.metroTabPage1.Text = "Inventory Spider";
            this.metroTabPage1.UseCustomBackColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnSpider
            // 
            this.btnSpider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpider.Location = new System.Drawing.Point(633, 339);
            this.btnSpider.Name = "btnSpider";
            this.btnSpider.Size = new System.Drawing.Size(75, 23);
            this.btnSpider.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSpider.TabIndex = 5;
            this.btnSpider.Text = "Spider";
            this.btnSpider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSpider.UseSelectable = true;
            this.btnSpider.Click += new System.EventHandler(this.BtnSpider_Click);
            // 
            // btnSaveSpider
            // 
            this.btnSaveSpider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSpider.Location = new System.Drawing.Point(714, 339);
            this.btnSaveSpider.Name = "btnSaveSpider";
            this.btnSaveSpider.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSpider.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSaveSpider.TabIndex = 4;
            this.btnSaveSpider.Text = "Save";
            this.btnSaveSpider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSaveSpider.UseSelectable = true;
            this.btnSaveSpider.Click += new System.EventHandler(this.BtnSaveSpider_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel17.Location = new System.Drawing.Point(-4, 324);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(444, 38);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel17.TabIndex = 3;
            this.metroLabel17.Text = "Modifying unknown is not recommended. Adding new items coming soon.\r\nBackup your " +
    "save before saving your shiny new inventory~ :3";
            this.metroLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToAddRows = false;
            this.itemGrid.AllowUserToDeleteRows = false;
            this.itemGrid.AllowUserToResizeRows = false;
            this.itemGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.itemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpiderID,
            this.SpiderName,
            this.SpiderQuantity,
            this.SpiderStorage});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemGrid.EnableHeadersVisualStyles = false;
            this.itemGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.itemGrid.Location = new System.Drawing.Point(3, 3);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.itemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(786, 318);
            this.itemGrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.itemGrid.TabIndex = 2;
            this.itemGrid.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SpiderID
            // 
            this.SpiderID.HeaderText = "SI";
            this.SpiderID.Name = "SpiderID";
            this.SpiderID.ReadOnly = true;
            this.SpiderID.Width = 50;
            // 
            // SpiderName
            // 
            this.SpiderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpiderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpiderName.HeaderText = "Item";
            this.SpiderName.Name = "SpiderName";
            this.SpiderName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SpiderName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SpiderQuantity
            // 
            this.SpiderQuantity.HeaderText = "Quantity";
            this.SpiderQuantity.Name = "SpiderQuantity";
            this.SpiderQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SpiderStorage
            // 
            this.SpiderStorage.HeaderText = "Storage";
            this.SpiderStorage.Name = "SpiderStorage";
            this.SpiderStorage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage2.Controls.Add(this.tbDebug);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 34);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 362);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage2.TabIndex = 6;
            this.metroTabPage2.Text = "Debug";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.UseCustomBackColor = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // tbDebug
            // 
            // 
            // 
            // 
            this.tbDebug.CustomButton.Image = null;
            this.tbDebug.CustomButton.Location = new System.Drawing.Point(438, 2);
            this.tbDebug.CustomButton.Name = "";
            this.tbDebug.CustomButton.Size = new System.Drawing.Size(351, 351);
            this.tbDebug.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDebug.CustomButton.TabIndex = 1;
            this.tbDebug.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDebug.CustomButton.UseSelectable = true;
            this.tbDebug.CustomButton.Visible = false;
            this.tbDebug.Lines = new string[0];
            this.tbDebug.Location = new System.Drawing.Point(0, 3);
            this.tbDebug.MaxLength = 32767;
            this.tbDebug.Multiline = true;
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.PasswordChar = '\0';
            this.tbDebug.ReadOnly = true;
            this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDebug.SelectedText = "";
            this.tbDebug.SelectionLength = 0;
            this.tbDebug.SelectionStart = 0;
            this.tbDebug.ShortcutsEnabled = true;
            this.tbDebug.Size = new System.Drawing.Size(792, 356);
            this.tbDebug.Style = MetroFramework.MetroColorStyle.Red;
            this.tbDebug.TabIndex = 2;
            this.tbDebug.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbDebug.UseSelectable = true;
            this.tbDebug.UseStyleColors = true;
            this.tbDebug.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDebug.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // toast
            // 
            this.toast.Controls.Add(this.toastMsg);
            this.toast.HorizontalScrollbarBarColor = true;
            this.toast.HorizontalScrollbarHighlightOnWheel = false;
            this.toast.HorizontalScrollbarSize = 10;
            this.toast.Location = new System.Drawing.Point(20, 520);
            this.toast.Name = "toast";
            this.toast.Size = new System.Drawing.Size(259, 76);
            this.toast.TabIndex = 22;
            this.toast.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toast.UseCustomBackColor = true;
            this.toast.VerticalScrollbarBarColor = true;
            this.toast.VerticalScrollbarHighlightOnWheel = false;
            this.toast.VerticalScrollbarSize = 10;
            this.toast.Visible = false;
            // 
            // toastMsg
            // 
            this.toastMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toastMsg.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.toastMsg.Location = new System.Drawing.Point(0, 0);
            this.toastMsg.Name = "toastMsg";
            this.toastMsg.Size = new System.Drawing.Size(259, 76);
            this.toastMsg.TabIndex = 2;
            this.toastMsg.Text = "Toast";
            this.toastMsg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toastMsg.UseCustomBackColor = true;
            this.toastMsg.UseCustomForeColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(-1, 5);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(20, 20);
            this.btnInfo.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnInfo.TabIndex = 30;
            this.btnInfo.Text = "?";
            this.btnInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnInfo.UseSelectable = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // lblTinyTitle
            // 
            this.lblTinyTitle.AutoSize = true;
            this.lblTinyTitle.Location = new System.Drawing.Point(20, 6);
            this.lblTinyTitle.Name = "lblTinyTitle";
            this.lblTinyTitle.Size = new System.Drawing.Size(128, 19);
            this.lblTinyTitle.TabIndex = 31;
            this.lblTinyTitle.Text = "Sekiro Speedrun Util";
            this.lblTinyTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTinyTitle.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 515);
            this.Controls.Add(this.lblTinyTitle);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.toast);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.updateLink);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnInventorySpider);
            this.Controls.Add(this.lblGlobalStatus);
            this.Controls.Add(this.metroPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Sekiro Speedrun Util by Jiiks";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox4.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pageHotkeys.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.tabSaveManager.ResumeLayout(false);
            this.tabSaveManager.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.toast.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnTest;
        private MetroFramework.Controls.MetroComboBox cboxAreaTeleport;
        private MetroFramework.Controls.MetroLabel lblPosZ;
        private MetroFramework.Controls.MetroLabel lblPosY;
        private MetroFramework.Controls.MetroLabel lblPosX;
        private MetroFramework.Controls.MetroButton btnCoordTeleport;
        private MetroFramework.Controls.MetroButton btnTeleportToCoordinates;
        private MetroFramework.Controls.MetroTextBox coordZ;
        private MetroFramework.Controls.MetroTextBox coordY;
        private MetroFramework.Controls.MetroTextBox coordX;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroComboBox cboxBossTeleport;
        private MetroFramework.Controls.MetroComboBox cboxIdolTeleport;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnLoadCurrentCoords;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cboxCustomTeleport;
        private MetroFramework.Controls.MetroButton btnRemoveSetup;
        private MetroFramework.Controls.MetroButton btnEditSetup;
        private MetroFramework.Controls.MetroButton btnAddSetup;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnReloadSetups;
        private MetroFramework.Controls.MetroButton btnLoadSetup;
        private MetroFramework.Controls.MetroLabel lblGlobalStatus;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLink updateLink;
        private MetroFramework.Controls.MetroButton btnInventorySpider;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroLabel lblLoading;
        private MetroFramework.Controls.MetroLabel lblIgt;
        private MetroFramework.Controls.MetroButton btnDebug;
        private MetroFramework.Controls.MetroLabel lblPosture;
        private MetroFramework.Controls.MetroLabel lblHealth;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cboxLastIdol;
        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private MetroFramework.Controls.MetroTabPage tabPage1;
        private MetroFramework.Controls.MetroTabPage pageHotkeys;
        private MetroFramework.Controls.MetroTabPage tabSaveManager;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox hotkeySaveCurrentCoordinates;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox hotkeyTeleportToCoordinates;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox hotkeyLoadSave;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox hotkeyBackupSave;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroPanel PlayerFlags;
        private MetroFramework.Controls.MetroPanel AllFlags;
        private MetroFramework.Controls.MetroPanel RenderFlags;
        private MetroFramework.Controls.MetroButton smAddProfile;
        private MetroFramework.Controls.MetroListView smSavesList;
        private MetroFramework.Controls.MetroButton smDelProfile;
        private MetroFramework.Controls.MetroComboBox smProfiles;
        private MetroFramework.Controls.MetroButton smOpenSavesDir;
        private MetroFramework.Controls.MetroButton smSave;
        private MetroFramework.Controls.MetroButton smLoad;
        private MetroFramework.Controls.MetroButton smDelete;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox smQuickSave;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroCheckBox smPseudoReadonly;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox hotkeyLoadQuick;
        private MetroFramework.Controls.MetroPanel toast;
        private MetroFramework.Controls.MetroLabel toastMsg;
        private MetroFramework.Controls.MetroCheckBox cbToastSounds;
        private MetroFramework.Controls.MetroGrid itemGrid;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroButton btnSpider;
        private MetroFramework.Controls.MetroButton btnSaveSpider;
        private MetroFramework.Controls.MetroTextBox tbDebug;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpiderID;
        private System.Windows.Forms.DataGridViewComboBoxColumn SpiderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpiderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpiderStorage;
        private MetroFramework.Controls.MetroLink btnInfo;
        private MetroFramework.Controls.MetroCheckBox cbOverlayMode;
        private MetroFramework.Controls.MetroLabel lblTinyTitle;
    }
}