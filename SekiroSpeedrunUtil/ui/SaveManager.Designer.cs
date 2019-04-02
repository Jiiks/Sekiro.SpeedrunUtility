namespace SekiroSpeedrunUtil.ui
{
    partial class SaveManager
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
            this.listBox1 = new MetroFramework.Controls.MetroListView();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.cbReadonly = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AutoArrange = false;
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBox1.FullRowSelect = true;
            this.listBox1.Location = new System.Drawing.Point(23, 63);
            this.listBox1.MultiSelect = false;
            this.listBox1.Name = "listBox1";
            this.listBox1.OwnerDraw = true;
            this.listBox1.ShowGroups = false;
            this.listBox1.Size = new System.Drawing.Size(237, 260);
            this.listBox1.Style = MetroFramework.MetroColorStyle.Lime;
            this.listBox1.TabIndex = 0;
            this.listBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.listBox1.UseCompatibleStateImageBehavior = false;
            this.listBox1.UseCustomBackColor = true;
            this.listBox1.UseSelectable = true;
            this.listBox1.View = System.Windows.Forms.View.List;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(104, 329);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // cbReadonly
            // 
            this.cbReadonly.AutoSize = true;
            this.cbReadonly.Location = new System.Drawing.Point(23, 358);
            this.cbReadonly.Name = "cbReadonly";
            this.cbReadonly.Size = new System.Drawing.Size(114, 15);
            this.cbReadonly.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbReadonly.TabIndex = 5;
            this.cbReadonly.Text = "Pseudo Readonly";
            this.cbReadonly.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbReadonly.UseSelectable = true;
            this.cbReadonly.CheckedChanged += new System.EventHandler(this.CbReadonly_CheckedChanged);
            // 
            // SaveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 399);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbReadonly);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Name = "SaveManager";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Simple SaveManager";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView listBox1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroCheckBox cbReadonly;
    }
}