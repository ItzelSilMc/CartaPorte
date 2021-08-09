
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
            this.PNTransporteAereo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.transporteAereoControl1 = new WindowsFormsApp1.ControlesAereo.TransporteAereoControl();
            this.PNGeneral.SuspendLayout();
            this.PNTransporteAereo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNGeneral
            // 
            this.PNGeneral.AutoScroll = true;
            this.PNGeneral.Controls.Add(this.panel1);
            this.PNGeneral.Controls.Add(this.PNTransporteAereo);
            this.PNGeneral.Location = new System.Drawing.Point(2, 2);
            this.PNGeneral.Name = "PNGeneral";
            this.PNGeneral.Size = new System.Drawing.Size(690, 548);
            this.PNGeneral.TabIndex = 0;
            // 
            // PNTransporteAereo
            // 
            this.PNTransporteAereo.Controls.Add(this.transporteAereoControl1);
            this.PNTransporteAereo.Location = new System.Drawing.Point(11, 11);
            this.PNTransporteAereo.Name = "PNTransporteAereo";
            this.PNTransporteAereo.Size = new System.Drawing.Size(667, 256);
            this.PNTransporteAereo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 41);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transporte Aereo";
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
            this.ClientSize = new System.Drawing.Size(704, 562);
            this.Controls.Add(this.PNGeneral);
            this.Name = "FrmTransporteAereo";
            this.Load += new System.EventHandler(this.FrmTransporteAereo_Load);
            this.PNGeneral.ResumeLayout(false);
            this.PNTransporteAereo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNGeneral;
        private System.Windows.Forms.Panel PNTransporteAereo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ControlesAereo.TransporteAereoControl transporteAereoControl1;
    }
}