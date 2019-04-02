namespace SekiroSpeedrunUtil.ui
{
    partial class CoordTele
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coordX = new System.Windows.Forms.TextBox();
            this.coordY = new System.Windows.Forms.TextBox();
            this.coordZ = new System.Windows.Forms.TextBox();
            this.btnTeleport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z:";
            // 
            // coordX
            // 
            this.coordX.Location = new System.Drawing.Point(30, 12);
            this.coordX.Name = "coordX";
            this.coordX.Size = new System.Drawing.Size(100, 20);
            this.coordX.TabIndex = 3;
            // 
            // coordY
            // 
            this.coordY.Location = new System.Drawing.Point(30, 38);
            this.coordY.Name = "coordY";
            this.coordY.Size = new System.Drawing.Size(100, 20);
            this.coordY.TabIndex = 4;
            // 
            // coordZ
            // 
            this.coordZ.Location = new System.Drawing.Point(30, 64);
            this.coordZ.Name = "coordZ";
            this.coordZ.Size = new System.Drawing.Size(100, 20);
            this.coordZ.TabIndex = 5;
            // 
            // btnTeleport
            // 
            this.btnTeleport.Location = new System.Drawing.Point(30, 90);
            this.btnTeleport.Name = "btnTeleport";
            this.btnTeleport.Size = new System.Drawing.Size(100, 23);
            this.btnTeleport.TabIndex = 6;
            this.btnTeleport.Text = "Teleport";
            this.btnTeleport.UseVisualStyleBackColor = true;
            this.btnTeleport.Click += new System.EventHandler(this.BtnTeleport_Click);
            // 
            // CoordTele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 123);
            this.Controls.Add(this.btnTeleport);
            this.Controls.Add(this.coordZ);
            this.Controls.Add(this.coordY);
            this.Controls.Add(this.coordX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CoordTele";
            this.Text = "CoordTele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox coordX;
        private System.Windows.Forms.TextBox coordY;
        private System.Windows.Forms.TextBox coordZ;
        private System.Windows.Forms.Button btnTeleport;
    }
}