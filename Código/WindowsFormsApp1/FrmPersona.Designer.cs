
namespace WindowsFormsApp1
{
    partial class FrmPersona
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
            this.domicilioControl1 = new WindowsFormsApp1.DomicilioControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtResidenciaFiscal = new System.Windows.Forms.TextBox();
            this.TxtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtLicencia = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtRFC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblRFC = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCodigoTransportista = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.domicilioControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 345);
            this.panel1.TabIndex = 0;
            // 
            // domicilioControl1
            // 
            this.domicilioControl1.Location = new System.Drawing.Point(3, 142);
            this.domicilioControl1.Name = "domicilioControl1";
            this.domicilioControl1.Size = new System.Drawing.Size(513, 186);
            this.domicilioControl1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblCodigo);
            this.groupBox1.Controls.Add(this.TxtCodigoTransportista);
            this.groupBox1.Controls.Add(this.TxtResidenciaFiscal);
            this.groupBox1.Controls.Add(this.TxtNumeroIdentificacion);
            this.groupBox1.Controls.Add(this.TxtLicencia);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.TxtRFC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LblRFC);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // TxtResidenciaFiscal
            // 
            this.TxtResidenciaFiscal.Location = new System.Drawing.Point(232, 105);
            this.TxtResidenciaFiscal.Name = "TxtResidenciaFiscal";
            this.TxtResidenciaFiscal.Size = new System.Drawing.Size(167, 20);
            this.TxtResidenciaFiscal.TabIndex = 10;
            // 
            // TxtNumeroIdentificacion
            // 
            this.TxtNumeroIdentificacion.Location = new System.Drawing.Point(19, 105);
            this.TxtNumeroIdentificacion.Name = "TxtNumeroIdentificacion";
            this.TxtNumeroIdentificacion.Size = new System.Drawing.Size(167, 20);
            this.TxtNumeroIdentificacion.TabIndex = 9;
            // 
            // TxtLicencia
            // 
            this.TxtLicencia.Location = new System.Drawing.Point(435, 43);
            this.TxtLicencia.Name = "TxtLicencia";
            this.TxtLicencia.Size = new System.Drawing.Size(100, 20);
            this.TxtLicencia.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(137, 43);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(271, 20);
            this.TxtNombre.TabIndex = 7;
            // 
            // TxtRFC
            // 
            this.TxtRFC.Location = new System.Drawing.Point(19, 43);
            this.TxtRFC.Name = "TxtRFC";
            this.TxtRFC.Size = new System.Drawing.Size(100, 20);
            this.TxtRFC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Residencia fiscal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número de registro o identificacion";
            // 
            // LblRFC
            // 
            this.LblRFC.AutoSize = true;
            this.LblRFC.Location = new System.Drawing.Point(16, 16);
            this.LblRFC.Name = "LblRFC";
            this.LblRFC.Size = new System.Drawing.Size(34, 13);
            this.LblRFC.TabIndex = 0;
            this.LblRFC.Text = "RFC -";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(134, 16);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de licencia";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(564, 364);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtCodigoTransportista
            // 
            this.TxtCodigoTransportista.Location = new System.Drawing.Point(416, 105);
            this.TxtCodigoTransportista.Name = "TxtCodigoTransportista";
            this.TxtCodigoTransportista.Size = new System.Drawing.Size(167, 20);
            this.TxtCodigoTransportista.TabIndex = 11;
            this.TxtCodigoTransportista.Visible = false;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(423, 80);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(103, 13);
            this.LblCodigo.TabIndex = 12;
            this.LblCodigo.Text = "Codigo transportista:";
            this.LblCodigo.Visible = false;
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 398);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPersona";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ControlesTerrestre.IdentificacionVehicularControl identificacionVehicularControl1;
        private DomicilioControl domicilioControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtResidenciaFiscal;
        private System.Windows.Forms.TextBox TxtNumeroIdentificacion;
        private System.Windows.Forms.TextBox TxtLicencia;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtRFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblRFC;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCodigoTransportista;
    }
}