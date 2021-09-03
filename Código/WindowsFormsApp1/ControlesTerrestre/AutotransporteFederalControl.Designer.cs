
namespace WindowsFormsApp1.ControlesTerrestre
{
    partial class AutotransporteFederalControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.configFederal = new System.Windows.Forms.ComboBox();
            this.TxtNumeroPolizaSeguro = new System.Windows.Forms.TextBox();
            this.TxtNombreAseguradora = new System.Windows.Forms.TextBox();
            this.TxtNumeroPermisoSCT = new System.Windows.Forms.TextBox();
            this.CmbPermisoSCT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textConfig = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textConfig);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.configFederal);
            this.groupBox1.Controls.Add(this.TxtNumeroPolizaSeguro);
            this.groupBox1.Controls.Add(this.TxtNombreAseguradora);
            this.groupBox1.Controls.Add(this.TxtNumeroPermisoSCT);
            this.groupBox1.Controls.Add(this.CmbPermisoSCT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seleciona Configuración Federal:";
            // 
            // configFederal
            // 
            this.configFederal.FormattingEnabled = true;
            this.configFederal.Location = new System.Drawing.Point(180, 20);
            this.configFederal.Name = "configFederal";
            this.configFederal.Size = new System.Drawing.Size(263, 21);
            this.configFederal.TabIndex = 8;
            this.configFederal.SelectedIndexChanged += new System.EventHandler(this.configFederal_SelectedIndexChanged);
            // 
            // TxtNumeroPolizaSeguro
            // 
            this.TxtNumeroPolizaSeguro.Location = new System.Drawing.Point(488, 81);
            this.TxtNumeroPolizaSeguro.MaxLength = 30;
            this.TxtNumeroPolizaSeguro.Name = "TxtNumeroPolizaSeguro";
            this.TxtNumeroPolizaSeguro.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroPolizaSeguro.TabIndex = 7;
            this.TxtNumeroPolizaSeguro.Visible = false;
            // 
            // TxtNombreAseguradora
            // 
            this.TxtNombreAseguradora.Location = new System.Drawing.Point(327, 80);
            this.TxtNombreAseguradora.MaxLength = 50;
            this.TxtNombreAseguradora.Name = "TxtNombreAseguradora";
            this.TxtNombreAseguradora.Size = new System.Drawing.Size(116, 20);
            this.TxtNombreAseguradora.TabIndex = 6;
            // 
            // TxtNumeroPermisoSCT
            // 
            this.TxtNumeroPermisoSCT.Location = new System.Drawing.Point(175, 80);
            this.TxtNumeroPermisoSCT.MaxLength = 50;
            this.TxtNumeroPermisoSCT.Name = "TxtNumeroPermisoSCT";
            this.TxtNumeroPermisoSCT.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroPermisoSCT.TabIndex = 5;
            // 
            // CmbPermisoSCT
            // 
            this.CmbPermisoSCT.FormattingEnabled = true;
            this.CmbPermisoSCT.Location = new System.Drawing.Point(11, 80);
            this.CmbPermisoSCT.Name = "CmbPermisoSCT";
            this.CmbPermisoSCT.Size = new System.Drawing.Size(158, 21);
            this.CmbPermisoSCT.TabIndex = 4;
            this.CmbPermisoSCT.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de póliza\r\nde seguro*:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de\r\naseguradora*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de permiso\r\nde la SCT*:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permiso de la SCT*:";
            // 
            // textConfig
            // 
            this.textConfig.Location = new System.Drawing.Point(11, 80);
            this.textConfig.Name = "textConfig";
            this.textConfig.Size = new System.Drawing.Size(136, 20);
            this.textConfig.TabIndex = 10;
            // 
            // AutotransporteFederalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AutotransporteFederalControl";
            this.Size = new System.Drawing.Size(605, 110);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumeroPermisoSCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumeroPolizaSeguro;
        private System.Windows.Forms.TextBox TxtNombreAseguradora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox configFederal;
        private System.Windows.Forms.ComboBox CmbPermisoSCT;
        private System.Windows.Forms.TextBox textConfig;
    }
}
