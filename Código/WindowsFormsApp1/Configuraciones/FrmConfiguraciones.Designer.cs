
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
            this.BtnFerroviario = new System.Windows.Forms.Button();
            this.BtnAereo = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.BtnFerroviario);
            this.panel1.Controls.Add(this.BtnAereo);
            this.panel1.Controls.Add(this.BtnTransporteMaritimo);
            this.panel1.Controls.Add(this.BtnAutotransporte);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 535);
            this.panel1.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(0, 434);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(163, 101);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnPersonas
            // 
            this.BtnPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonas.Image = global::WindowsFormsApp1.Properties.Resources.people64;
            this.BtnPersonas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPersonas.Location = new System.Drawing.Point(0, 328);
            this.BtnPersonas.Name = "BtnPersonas";
            this.BtnPersonas.Size = new System.Drawing.Size(163, 106);
            this.BtnPersonas.TabIndex = 10;
            this.BtnPersonas.Text = "Personas\r\n(Notificado, transporstista, etc.)\r\n\r\n";
            this.BtnPersonas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPersonas.UseVisualStyleBackColor = true;
            this.BtnPersonas.Click += new System.EventHandler(this.BtnPersonas_Click);
            // 
            // BtnFerroviario
            // 
            this.BtnFerroviario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFerroviario.Enabled = false;
            this.BtnFerroviario.Image = global::WindowsFormsApp1.Properties.Resources.train64;
            this.BtnFerroviario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFerroviario.Location = new System.Drawing.Point(0, 246);
            this.BtnFerroviario.Name = "BtnFerroviario";
            this.BtnFerroviario.Size = new System.Drawing.Size(163, 82);
            this.BtnFerroviario.TabIndex = 3;
            this.BtnFerroviario.Text = "Transporte ferroviario";
            this.BtnFerroviario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFerroviario.UseVisualStyleBackColor = true;
            // 
            // BtnAereo
            // 
            this.BtnAereo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAereo.Enabled = false;
            this.BtnAereo.Image = global::WindowsFormsApp1.Properties.Resources.airplane64;
            this.BtnAereo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAereo.Location = new System.Drawing.Point(0, 164);
            this.BtnAereo.Name = "BtnAereo";
            this.BtnAereo.Size = new System.Drawing.Size(163, 82);
            this.BtnAereo.TabIndex = 2;
            this.BtnAereo.Text = "Transporte aereo";
            this.BtnAereo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAereo.UseVisualStyleBackColor = true;
            // 
            // BtnTransporteMaritimo
            // 
            this.BtnTransporteMaritimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransporteMaritimo.Enabled = false;
            this.BtnTransporteMaritimo.Image = global::WindowsFormsApp1.Properties.Resources.barco64;
            this.BtnTransporteMaritimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnTransporteMaritimo.Location = new System.Drawing.Point(0, 82);
            this.BtnTransporteMaritimo.Name = "BtnTransporteMaritimo";
            this.BtnTransporteMaritimo.Size = new System.Drawing.Size(163, 82);
            this.BtnTransporteMaritimo.TabIndex = 1;
            this.BtnTransporteMaritimo.Text = "Transporte Maritimo";
            this.BtnTransporteMaritimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTransporteMaritimo.UseVisualStyleBackColor = true;
            // 
            // BtnAutotransporte
            // 
            this.BtnAutotransporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAutotransporte.Image = global::WindowsFormsApp1.Properties.Resources.truck64;
            this.BtnAutotransporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAutotransporte.Location = new System.Drawing.Point(0, 0);
            this.BtnAutotransporte.Name = "BtnAutotransporte";
            this.BtnAutotransporte.Size = new System.Drawing.Size(163, 82);
            this.BtnAutotransporte.TabIndex = 0;
            this.BtnAutotransporte.Text = "Autotransporte federal";
            this.BtnAutotransporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAutotransporte.UseVisualStyleBackColor = true;
            this.BtnAutotransporte.Click += new System.EventHandler(this.BtnAutotransporte_Click);
            // 
            // FrmConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 518);
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
        private System.Windows.Forms.Button BtnFerroviario;
        private System.Windows.Forms.Button BtnAereo;
        private System.Windows.Forms.Button BtnTransporteMaritimo;
        private System.Windows.Forms.Button BtnAutotransporte;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnPersonas;
    }
}