
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
            this.TxtNumeroPolizaSeguro = new System.Windows.Forms.TextBox();
            this.TxtNombreAseguradora = new System.Windows.Forms.TextBox();
            this.TxtNumeroPermisoSCT = new System.Windows.Forms.TextBox();
            this.CmbPermisoSCT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(597, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TxtNumeroPolizaSeguro
            // 
            this.TxtNumeroPolizaSeguro.Location = new System.Drawing.Point(487, 47);
            this.TxtNumeroPolizaSeguro.Name = "TxtNumeroPolizaSeguro";
            this.TxtNumeroPolizaSeguro.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroPolizaSeguro.TabIndex = 7;
            // 
            // TxtNombreAseguradora
            // 
            this.TxtNombreAseguradora.Location = new System.Drawing.Point(326, 46);
            this.TxtNombreAseguradora.Name = "TxtNombreAseguradora";
            this.TxtNombreAseguradora.Size = new System.Drawing.Size(116, 20);
            this.TxtNombreAseguradora.TabIndex = 6;
            // 
            // TxtNumeroPermisoSCT
            // 
            this.TxtNumeroPermisoSCT.Location = new System.Drawing.Point(174, 46);
            this.TxtNumeroPermisoSCT.Name = "TxtNumeroPermisoSCT";
            this.TxtNumeroPermisoSCT.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroPermisoSCT.TabIndex = 5;
            // 
            // CmbPermisoSCT
            // 
            this.CmbPermisoSCT.FormattingEnabled = true;
            this.CmbPermisoSCT.Location = new System.Drawing.Point(10, 46);
            this.CmbPermisoSCT.Name = "CmbPermisoSCT";
            this.CmbPermisoSCT.Size = new System.Drawing.Size(139, 21);
            this.CmbPermisoSCT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de póliza\r\nde seguro*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de\r\naseguradora*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de permiso\r\nde la SCT*:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permiso de la SCT*:";
            // 
            // AutotransporteFederalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AutotransporteFederalControl";
            this.Size = new System.Drawing.Size(605, 86);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumeroPermisoSCT;
        private System.Windows.Forms.ComboBox CmbPermisoSCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumeroPolizaSeguro;
        private System.Windows.Forms.TextBox TxtNombreAseguradora;
    }
}
