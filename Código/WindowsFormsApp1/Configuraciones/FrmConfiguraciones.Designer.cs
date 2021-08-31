
namespace WindowsFormsApp1
{
    partial class FrmConfiguraciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnPersonas = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnTransporteMaritimo = new System.Windows.Forms.Button();
            this.BtnAutotransporte = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.BtnPersonas);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtnTransporteMaritimo);
            this.panel1.Controls.Add(this.BtnAutotransporte);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 362);
            this.panel1.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(0, 295);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(163, 59);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnPersonas
            // 
            this.BtnPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonas.Location = new System.Drawing.Point(0, 236);
            this.BtnPersonas.Name = "BtnPersonas";
            this.BtnPersonas.Size = new System.Drawing.Size(163, 59);
            this.BtnPersonas.TabIndex = 10;
            this.BtnPersonas.Text = "Personas\r\n(Notificado, transporstista, etc.)\r\n\r\n";
            this.BtnPersonas.UseVisualStyleBackColor = true;
            this.BtnPersonas.Click += new System.EventHandler(this.BtnPersonas_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "Transporte ferroviario";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Transporte aereo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnTransporteMaritimo
            // 
            this.BtnTransporteMaritimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransporteMaritimo.Location = new System.Drawing.Point(0, 59);
            this.BtnTransporteMaritimo.Name = "BtnTransporteMaritimo";
            this.BtnTransporteMaritimo.Size = new System.Drawing.Size(163, 59);
            this.BtnTransporteMaritimo.TabIndex = 1;
            this.BtnTransporteMaritimo.Text = "Transporte Maritimo";
            this.BtnTransporteMaritimo.UseVisualStyleBackColor = true;
            // 
            // BtnAutotransporte
            // 
            this.BtnAutotransporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAutotransporte.Location = new System.Drawing.Point(0, 0);
            this.BtnAutotransporte.Name = "BtnAutotransporte";
            this.BtnAutotransporte.Size = new System.Drawing.Size(163, 59);
            this.BtnAutotransporte.TabIndex = 0;
            this.BtnAutotransporte.Text = "Autotransporte federal";
            this.BtnAutotransporte.UseVisualStyleBackColor = true;
            this.BtnAutotransporte.Click += new System.EventHandler(this.BtnAutotransporte_Click);
            // 
            // FrmConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 369);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguraciones";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnTransporteMaritimo;
        private System.Windows.Forms.Button BtnAutotransporte;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnPersonas;
    }
}