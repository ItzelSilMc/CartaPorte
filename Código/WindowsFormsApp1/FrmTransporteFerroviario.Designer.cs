
namespace WindowsFormsApp1
{
    partial class FrmTransporteFerroviario
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
            this.GBTransporteFerroviario = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnInformacion = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.PnCarro = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.PnDerechosPaso = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.contenedorFerroviarioControl1 = new WindowsFormsApp1.ControlesFerroviario.ContenedorFerroviarioControl();
            this.carroControlControl1 = new WindowsFormsApp1.ControlesFerroviario.CarroControlControl();
            this.derechosPasoControl1 = new WindowsFormsApp1.ControlesFerroviario.DerechosPasoControl();
            this.GBTransporteFerroviario.SuspendLayout();
            this.PnInformacion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PnCarro.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PnDerechosPaso.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBTransporteFerroviario
            // 
            this.GBTransporteFerroviario.Controls.Add(this.textBox3);
            this.GBTransporteFerroviario.Controls.Add(this.textBox2);
            this.GBTransporteFerroviario.Controls.Add(this.textBox1);
            this.GBTransporteFerroviario.Controls.Add(this.CmbTipoServicio);
            this.GBTransporteFerroviario.Controls.Add(this.label4);
            this.GBTransporteFerroviario.Controls.Add(this.label3);
            this.GBTransporteFerroviario.Controls.Add(this.label2);
            this.GBTransporteFerroviario.Controls.Add(this.label1);
            this.GBTransporteFerroviario.Location = new System.Drawing.Point(13, 22);
            this.GBTransporteFerroviario.Name = "GBTransporteFerroviario";
            this.GBTransporteFerroviario.Size = new System.Drawing.Size(658, 100);
            this.GBTransporteFerroviario.TabIndex = 0;
            this.GBTransporteFerroviario.TabStop = false;
            this.GBTransporteFerroviario.Text = "Transporte ferroviario";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(521, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 5;
            // 
            // CmbTipoServicio
            // 
            this.CmbTipoServicio.FormattingEnabled = true;
            this.CmbTipoServicio.Location = new System.Drawing.Point(21, 57);
            this.CmbTipoServicio.Name = "CmbTipoServicio";
            this.CmbTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoServicio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Concesionario*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de la póliza de seguro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la aseguradora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de servicio:";
            // 
            // PnInformacion
            // 
            this.PnInformacion.Controls.Add(this.panel2);
            this.PnInformacion.Controls.Add(this.PnCarro);
            this.PnInformacion.Controls.Add(this.PnDerechosPaso);
            this.PnInformacion.Location = new System.Drawing.Point(34, 128);
            this.PnInformacion.Name = "PnInformacion";
            this.PnInformacion.Size = new System.Drawing.Size(607, 434);
            this.PnInformacion.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contenedorFerroviarioControl1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 138);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(179, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 35);
            this.panel4.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Contenedor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnCarro
            // 
            this.PnCarro.Controls.Add(this.carroControlControl1);
            this.PnCarro.Controls.Add(this.panel3);
            this.PnCarro.Location = new System.Drawing.Point(4, 144);
            this.PnCarro.Name = "PnCarro";
            this.PnCarro.Size = new System.Drawing.Size(603, 120);
            this.PnCarro.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(179, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 35);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Carro";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnDerechosPaso
            // 
            this.PnDerechosPaso.AutoScroll = true;
            this.PnDerechosPaso.Controls.Add(this.derechosPasoControl1);
            this.PnDerechosPaso.Controls.Add(this.panel1);
            this.PnDerechosPaso.Location = new System.Drawing.Point(4, 4);
            this.PnDerechosPaso.Name = "PnDerechosPaso";
            this.PnDerechosPaso.Size = new System.Drawing.Size(603, 134);
            this.PnDerechosPaso.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(176, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 35);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Derecho de paso";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contenedorFerroviarioControl1
            // 
            this.contenedorFerroviarioControl1.Location = new System.Drawing.Point(3, 44);
            this.contenedorFerroviarioControl1.Name = "contenedorFerroviarioControl1";
            this.contenedorFerroviarioControl1.Size = new System.Drawing.Size(499, 83);
            this.contenedorFerroviarioControl1.TabIndex = 3;
            // 
            // carroControlControl1
            // 
            this.carroControlControl1.Location = new System.Drawing.Point(3, 44);
            this.carroControlControl1.Name = "carroControlControl1";
            this.carroControlControl1.Size = new System.Drawing.Size(592, 68);
            this.carroControlControl1.TabIndex = 2;
            // 
            // derechosPasoControl1
            // 
            this.derechosPasoControl1.Location = new System.Drawing.Point(0, 44);
            this.derechosPasoControl1.Name = "derechosPasoControl1";
            this.derechosPasoControl1.Size = new System.Drawing.Size(364, 87);
            this.derechosPasoControl1.TabIndex = 1;
            // 
            // FrmTransporteFerroviario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 574);
            this.Controls.Add(this.PnInformacion);
            this.Controls.Add(this.GBTransporteFerroviario);
            this.Name = "FrmTransporteFerroviario";
            this.Text = "FrmTransporteFerroviario";
            this.Load += new System.EventHandler(this.FrmTransporteFerroviario_Load);
            this.GBTransporteFerroviario.ResumeLayout(false);
            this.GBTransporteFerroviario.PerformLayout();
            this.PnInformacion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PnCarro.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PnDerechosPaso.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBTransporteFerroviario;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CmbTipoServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnInformacion;
        private System.Windows.Forms.Panel PnDerechosPaso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PnCarro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private ControlesFerroviario.DerechosPasoControl derechosPasoControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private ControlesFerroviario.CarroControlControl carroControlControl1;
        private ControlesFerroviario.ContenedorFerroviarioControl contenedorFerroviarioControl1;
    }
}