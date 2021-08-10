
namespace WindowsFormsApp1
{
    partial class FrmTransporteAereo
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
            this.PNGeneral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PNTransporteAereo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPropietario = new System.Windows.Forms.Button();
            this.BtnArrendatario = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEmbarcador = new System.Windows.Forms.Button();
            this.BtnTransportista = new System.Windows.Forms.Button();
            this.transporteAereoControl1 = new WindowsFormsApp1.ControlesAereo.TransporteAereoControl();
            this.PNGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PNTransporteAereo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNGeneral
            // 
            this.PNGeneral.AutoScroll = true;
            this.PNGeneral.Controls.Add(this.panel1);
            this.PNGeneral.Controls.Add(this.PNTransporteAereo);
            this.PNGeneral.Location = new System.Drawing.Point(2, 2);
            this.PNGeneral.Name = "PNGeneral";
            this.PNGeneral.Size = new System.Drawing.Size(555, 275);
            this.PNGeneral.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 41);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transporte Aereo";
            // 
            // PNTransporteAereo
            // 
            this.PNTransporteAereo.Controls.Add(this.transporteAereoControl1);
            this.PNTransporteAereo.Location = new System.Drawing.Point(11, 11);
            this.PNTransporteAereo.Name = "PNTransporteAereo";
            this.PNTransporteAereo.Size = new System.Drawing.Size(534, 256);
            this.PNTransporteAereo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnPropietario);
            this.panel2.Controls.Add(this.BtnArrendatario);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.BtnEmbarcador);
            this.panel2.Controls.Add(this.BtnTransportista);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(563, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 284);
            this.panel2.TabIndex = 1;
            // 
            // BtnPropietario
            // 
            this.BtnPropietario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPropietario.Location = new System.Drawing.Point(0, 150);
            this.BtnPropietario.Name = "BtnPropietario";
            this.BtnPropietario.Size = new System.Drawing.Size(89, 50);
            this.BtnPropietario.TabIndex = 4;
            this.BtnPropietario.Text = "Añadir propietario";
            this.BtnPropietario.UseVisualStyleBackColor = true;
            this.BtnPropietario.Click += new System.EventHandler(this.BtnPropietario_Click);
            // 
            // BtnArrendatario
            // 
            this.BtnArrendatario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnArrendatario.Location = new System.Drawing.Point(0, 100);
            this.BtnArrendatario.Name = "BtnArrendatario";
            this.BtnArrendatario.Size = new System.Drawing.Size(89, 50);
            this.BtnArrendatario.TabIndex = 3;
            this.BtnArrendatario.Text = "Añadir arrandatario";
            this.BtnArrendatario.UseVisualStyleBackColor = true;
            this.BtnArrendatario.Click += new System.EventHandler(this.BtnArrendatario_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnGuardar.Location = new System.Drawing.Point(0, 234);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(89, 50);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEmbarcador
            // 
            this.BtnEmbarcador.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmbarcador.Location = new System.Drawing.Point(0, 50);
            this.BtnEmbarcador.Name = "BtnEmbarcador";
            this.BtnEmbarcador.Size = new System.Drawing.Size(89, 50);
            this.BtnEmbarcador.TabIndex = 1;
            this.BtnEmbarcador.Text = "Añadir\r\nembarcador";
            this.BtnEmbarcador.UseVisualStyleBackColor = true;
            this.BtnEmbarcador.Click += new System.EventHandler(this.BtnEmbarcador_Click);
            // 
            // BtnTransportista
            // 
            this.BtnTransportista.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransportista.Location = new System.Drawing.Point(0, 0);
            this.BtnTransportista.Name = "BtnTransportista";
            this.BtnTransportista.Size = new System.Drawing.Size(89, 50);
            this.BtnTransportista.TabIndex = 0;
            this.BtnTransportista.Text = "Añadir\r\ntransportista\r\n";
            this.BtnTransportista.UseVisualStyleBackColor = true;
            this.BtnTransportista.Click += new System.EventHandler(this.BtnTransportista_Click);
            // 
            // transporteAereoControl1
            // 
            this.transporteAereoControl1.Location = new System.Drawing.Point(34, 46);
            this.transporteAereoControl1.Name = "transporteAereoControl1";
            this.transporteAereoControl1.Size = new System.Drawing.Size(475, 187);
            this.transporteAereoControl1.TabIndex = 0;
            // 
            // FrmTransporteAereo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 284);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PNGeneral);
            this.Name = "FrmTransporteAereo";
            this.Load += new System.EventHandler(this.FrmTransporteAereo_Load);
            this.PNGeneral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PNTransporteAereo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNGeneral;
        private System.Windows.Forms.Panel PNTransporteAereo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ControlesAereo.TransporteAereoControl transporteAereoControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnArrendatario;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEmbarcador;
        private System.Windows.Forms.Button BtnTransportista;
        private System.Windows.Forms.Button BtnPropietario;
    }
}