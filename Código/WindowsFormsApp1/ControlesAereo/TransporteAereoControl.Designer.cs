
namespace WindowsFormsApp1.ControlesAereo
{
    partial class TransporteAereoControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbPermisoSCT = new System.Windows.Forms.ComboBox();
            this.TxtNumerpPermosoSCT = new System.Windows.Forms.TextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.TxtNombreAseguradora = new System.Windows.Forms.TextBox();
            this.TxtNumeroPolizaSeguro = new System.Windows.Forms.TextBox();
            this.TxtNumeroGuia = new System.Windows.Forms.TextBox();
            this.TxtLugarContrato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permiso de la SCT*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de permiso\r\nde la SCT*:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matricula aeronave*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre de\r\naseguradora*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número de póliza de\r\nseguro*:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número guía*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lugar de contrato";
            // 
            // CmbPermisoSCT
            // 
            this.CmbPermisoSCT.FormattingEnabled = true;
            this.CmbPermisoSCT.Location = new System.Drawing.Point(20, 35);
            this.CmbPermisoSCT.Name = "CmbPermisoSCT";
            this.CmbPermisoSCT.Size = new System.Drawing.Size(121, 21);
            this.CmbPermisoSCT.TabIndex = 7;
            // 
            // TxtNumerpPermosoSCT
            // 
            this.TxtNumerpPermosoSCT.Location = new System.Drawing.Point(187, 35);
            this.TxtNumerpPermosoSCT.Name = "TxtNumerpPermosoSCT";
            this.TxtNumerpPermosoSCT.Size = new System.Drawing.Size(100, 20);
            this.TxtNumerpPermosoSCT.TabIndex = 8;
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(352, 36);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(100, 20);
            this.TxtMatricula.TabIndex = 9;
            // 
            // TxtNombreAseguradora
            // 
            this.TxtNombreAseguradora.Location = new System.Drawing.Point(18, 98);
            this.TxtNombreAseguradora.Name = "TxtNombreAseguradora";
            this.TxtNombreAseguradora.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreAseguradora.TabIndex = 10;
            // 
            // TxtNumeroPolizaSeguro
            // 
            this.TxtNumeroPolizaSeguro.Location = new System.Drawing.Point(182, 98);
            this.TxtNumeroPolizaSeguro.Name = "TxtNumeroPolizaSeguro";
            this.TxtNumeroPolizaSeguro.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroPolizaSeguro.TabIndex = 11;
            // 
            // TxtNumeroGuia
            // 
            this.TxtNumeroGuia.Location = new System.Drawing.Point(352, 98);
            this.TxtNumeroGuia.Name = "TxtNumeroGuia";
            this.TxtNumeroGuia.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroGuia.TabIndex = 12;
            // 
            // TxtLugarContrato
            // 
            this.TxtLugarContrato.Location = new System.Drawing.Point(18, 164);
            this.TxtLugarContrato.Name = "TxtLugarContrato";
            this.TxtLugarContrato.Size = new System.Drawing.Size(100, 20);
            this.TxtLugarContrato.TabIndex = 13;
            // 
            // TransporteAereoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtLugarContrato);
            this.Controls.Add(this.TxtNumeroGuia);
            this.Controls.Add(this.TxtNumeroPolizaSeguro);
            this.Controls.Add(this.TxtNombreAseguradora);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.TxtNumerpPermosoSCT);
            this.Controls.Add(this.CmbPermisoSCT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransporteAereoControl";
            this.Size = new System.Drawing.Size(475, 187);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbPermisoSCT;
        private System.Windows.Forms.TextBox TxtNumerpPermosoSCT;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.TextBox TxtNombreAseguradora;
        private System.Windows.Forms.TextBox TxtNumeroPolizaSeguro;
        private System.Windows.Forms.TextBox TxtNumeroGuia;
        private System.Windows.Forms.TextBox TxtLugarContrato;
    }
}
