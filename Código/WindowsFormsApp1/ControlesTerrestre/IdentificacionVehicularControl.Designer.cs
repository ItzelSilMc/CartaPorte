
namespace WindowsFormsApp1.ControlesTerrestre
{
    partial class IdentificacionVehicularControl
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
            this.GBIdentificacion = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboVehiculo = new System.Windows.Forms.ComboBox();
            this.TxtNumPoliza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAñoModelo = new System.Windows.Forms.TextBox();
            this.TxtPlacaVehicular = new System.Windows.Forms.TextBox();
            this.CmbConfigVehicular = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textconfVehiculo = new System.Windows.Forms.TextBox();
            this.GBIdentificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBIdentificacion
            // 
            this.GBIdentificacion.Controls.Add(this.textconfVehiculo);
            this.GBIdentificacion.Controls.Add(this.label5);
            this.GBIdentificacion.Controls.Add(this.comboVehiculo);
            this.GBIdentificacion.Controls.Add(this.TxtNumPoliza);
            this.GBIdentificacion.Controls.Add(this.label4);
            this.GBIdentificacion.Controls.Add(this.TxtAñoModelo);
            this.GBIdentificacion.Controls.Add(this.TxtPlacaVehicular);
            this.GBIdentificacion.Controls.Add(this.CmbConfigVehicular);
            this.GBIdentificacion.Controls.Add(this.label3);
            this.GBIdentificacion.Controls.Add(this.label2);
            this.GBIdentificacion.Controls.Add(this.label1);
            this.GBIdentificacion.Location = new System.Drawing.Point(3, 3);
            this.GBIdentificacion.Name = "GBIdentificacion";
            this.GBIdentificacion.Size = new System.Drawing.Size(573, 109);
            this.GBIdentificacion.TabIndex = 0;
            this.GBIdentificacion.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selecciona configracion vehicular:";
            // 
            // comboVehiculo
            // 
            this.comboVehiculo.FormattingEnabled = true;
            this.comboVehiculo.Location = new System.Drawing.Point(192, 19);
            this.comboVehiculo.Name = "comboVehiculo";
            this.comboVehiculo.Size = new System.Drawing.Size(249, 21);
            this.comboVehiculo.TabIndex = 8;
            this.comboVehiculo.SelectedIndexChanged += new System.EventHandler(this.comboVehiculo_SelectedIndexChanged);
            // 
            // TxtNumPoliza
            // 
            this.TxtNumPoliza.Location = new System.Drawing.Point(461, 77);
            this.TxtNumPoliza.MaxLength = 30;
            this.TxtNumPoliza.Name = "TxtNumPoliza";
            this.TxtNumPoliza.Size = new System.Drawing.Size(100, 20);
            this.TxtNumPoliza.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero poliza seguro";
            // 
            // TxtAñoModelo
            // 
            this.TxtAñoModelo.Location = new System.Drawing.Point(341, 77);
            this.TxtAñoModelo.MaxLength = 4;
            this.TxtAñoModelo.Name = "TxtAñoModelo";
            this.TxtAñoModelo.Size = new System.Drawing.Size(100, 20);
            this.TxtAñoModelo.TabIndex = 5;
            // 
            // TxtPlacaVehicular
            // 
            this.TxtPlacaVehicular.Location = new System.Drawing.Point(192, 77);
            this.TxtPlacaVehicular.MaxLength = 10;
            this.TxtPlacaVehicular.Name = "TxtPlacaVehicular";
            this.TxtPlacaVehicular.Size = new System.Drawing.Size(100, 20);
            this.TxtPlacaVehicular.TabIndex = 4;
            // 
            // CmbConfigVehicular
            // 
            this.CmbConfigVehicular.FormattingEnabled = true;
            this.CmbConfigVehicular.Location = new System.Drawing.Point(14, 77);
            this.CmbConfigVehicular.Name = "CmbConfigVehicular";
            this.CmbConfigVehicular.Size = new System.Drawing.Size(172, 21);
            this.CmbConfigVehicular.TabIndex = 3;
            this.CmbConfigVehicular.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año modelo\r\nvehículo motor*:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa vehículo motor*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración vehicular*:";
            // 
            // textconfVehiculo
            // 
            this.textconfVehiculo.Location = new System.Drawing.Point(14, 77);
            this.textconfVehiculo.Name = "textconfVehiculo";
            this.textconfVehiculo.Size = new System.Drawing.Size(151, 20);
            this.textconfVehiculo.TabIndex = 10;
            // 
            // IdentificacionVehicularControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBIdentificacion);
            this.Name = "IdentificacionVehicularControl";
            this.Size = new System.Drawing.Size(584, 112);
            this.GBIdentificacion.ResumeLayout(false);
            this.GBIdentificacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBIdentificacion;
        private System.Windows.Forms.TextBox TxtAñoModelo;
        private System.Windows.Forms.TextBox TxtPlacaVehicular;
        private System.Windows.Forms.ComboBox CmbConfigVehicular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumPoliza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboVehiculo;
        private System.Windows.Forms.TextBox textconfVehiculo;
    }
}
