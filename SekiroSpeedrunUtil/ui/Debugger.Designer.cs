namespace SekiroSpeedrunUtil.ui
{
    partial class Debugger
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
            this.debugTextbox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // debugTextbox
            // 
            // 
            // 
            // 
            this.debugTextbox.CustomButton.Image = null;
            this.debugTextbox.CustomButton.Location = new System.Drawing.Point(392, 2);
            this.debugTextbox.CustomButton.Name = "";
            this.debugTextbox.CustomButton.Size = new System.Drawing.Size(365, 365);
            this.debugTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.debugTextbox.CustomButton.TabIndex = 1;
            this.debugTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.debugTextbox.CustomButton.UseSelectable = true;
            this.debugTextbox.CustomButton.Visible = false;
            this.debugTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugTextbox.Lines = new string[] {
        "Debug"};
            this.debugTextbox.Location = new System.Drawing.Point(20, 60);
            this.debugTextbox.MaxLength = 32767;
            this.debugTextbox.Multiline = true;
            this.debugTextbox.Name = "debugTextbox";
            this.debugTextbox.PasswordChar = '\0';
            this.debugTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.debugTextbox.SelectedText = "";
            this.debugTextbox.SelectionLength = 0;
            this.debugTextbox.SelectionStart = 0;
            this.debugTextbox.ShortcutsEnabled = true;
            this.debugTextbox.Size = new System.Drawing.Size(760, 370);
            this.debugTextbox.Style = MetroFramework.MetroColorStyle.Red;
            this.debugTextbox.TabIndex = 0;
            this.debugTextbox.Text = "Debug";
            this.debugTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.debugTextbox.UseSelectable = true;
            this.debugTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.debugTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Debugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debugTextbox);
            this.Name = "Debugger";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Debugger";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox debugTextbox;
    }
}