
namespace WindowsFormsApp1.Configuraciones
{
    partial class FrmConfRemolque
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
            this.remolqueControl1 = new WindowsFormsApp1.ControlesTerrestre.RemolqueControl();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remolqueControl1
            // 
            this.remolqueControl1.Location = new System.Drawing.Point(0, 0);
            this.remolqueControl1.Name = "remolqueControl1";
            this.remolqueControl1.Size = new System.Drawing.Size(322, 78);
            this.remolqueControl1.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(187, 84);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmConfRemolque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 133);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.remolqueControl1);
            this.Name = "FrmConfRemolque";
            this.Text = "Remolque";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesTerrestre.RemolqueControl remolqueControl1;
        private System.Windows.Forms.Button BtnGuardar;
    }
}