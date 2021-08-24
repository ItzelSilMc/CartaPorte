
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
            this.PnBotonesLaterales = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.botonesPersonasControl1 = new WindowsFormsApp1.ControlesGenerales.BotonesPersonasControl();
            this.transporteAereoControl1 = new WindowsFormsApp1.ControlesAereo.TransporteAereoControl();
            this.PNGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PNTransporteAereo.SuspendLayout();
            this.PnBotonesLaterales.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNGeneral
            // 
            this.PNGeneral.AutoScroll = true;
            this.PNGeneral.Controls.Add(this.panel1);
            this.PNGeneral.Controls.Add(this.PNTransporteAereo);
            this.PNGeneral.Location = new System.Drawing.Point(2, 2);
            this.PNGeneral.Name = "PNGeneral";
            this.PNGeneral.Size = new System.Drawing.Size(552, 275);
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
            // PnBotonesLaterales
            // 
            this.PnBotonesLaterales.Controls.Add(this.botonesPersonasControl1);
            this.PnBotonesLaterales.Controls.Add(this.BtnGuardar);
            this.PnBotonesLaterales.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnBotonesLaterales.Location = new System.Drawing.Point(562, 0);
            this.PnBotonesLaterales.Name = "PnBotonesLaterales";
            this.PnBotonesLaterales.Size = new System.Drawing.Size(90, 304);
            this.PnBotonesLaterales.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnGuardar.Location = new System.Drawing.Point(0, 254);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 50);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // botonesPersonasControl1
            // 
            this.botonesPersonasControl1.AutoSize = true;
            this.botonesPersonasControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonesPersonasControl1.Location = new System.Drawing.Point(0, 0);
            this.botonesPersonasControl1.Name = "botonesPersonasControl1";
            this.botonesPersonasControl1.Size = new System.Drawing.Size(90, 244);
            this.botonesPersonasControl1.TabIndex = 3;
            this.botonesPersonasControl1.Load += new System.EventHandler(this.botonesPersonasControl1_Load);
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
            this.ClientSize = new System.Drawing.Size(652, 304);
            this.Controls.Add(this.PnBotonesLaterales);
            this.Controls.Add(this.PNGeneral);
            this.Name = "FrmTransporteAereo";
            this.Load += new System.EventHandler(this.FrmTransporteAereo_Load);
            this.PNGeneral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PNTransporteAereo.ResumeLayout(false);
            this.PnBotonesLaterales.ResumeLayout(false);
            this.PnBotonesLaterales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNGeneral;
        private System.Windows.Forms.Panel PNTransporteAereo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ControlesAereo.TransporteAereoControl transporteAereoControl1;
        private System.Windows.Forms.Panel PnBotonesLaterales;
        private System.Windows.Forms.Button BtnGuardar;
        private ControlesGenerales.BotonesPersonasControl botonesPersonasControl1;
    }
}