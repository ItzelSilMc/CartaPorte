
namespace WindowsFormsApp1
{
    partial class FrmAdministracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGrid
            // 
            this.PnlGrid.AutoSize = true;
            this.PnlGrid.Location = new System.Drawing.Point(40, 27);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(609, 226);
            this.PnlGrid.TabIndex = 0;
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.Location = new System.Drawing.Point(17, 20);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(75, 23);
            this.BtnAñadir.TabIndex = 1;
            this.BtnAñadir.Text = "Añadir";
            this.BtnAñadir.UseVisualStyleBackColor = true;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAñadir);
            this.panel1.Location = new System.Drawing.Point(40, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 55);
            this.panel1.TabIndex = 2;
            // 
            // FrmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(733, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlGrid);
            this.Name = "FrmAdministracion";
            this.Text = "Administración -";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.Panel panel1;
    }
}