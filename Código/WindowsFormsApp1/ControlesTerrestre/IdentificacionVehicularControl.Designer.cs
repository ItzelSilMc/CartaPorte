
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
            this.TxtAñoModelo = new System.Windows.Forms.TextBox();
            this.TxtPlacaVehicular = new System.Windows.Forms.TextBox();
            this.CmbConfigVehicular = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBIdentificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBIdentificacion
            // 
            this.GBIdentificacion.Controls.Add(this.TxtAñoModelo);
            this.GBIdentificacion.Controls.Add(this.TxtPlacaVehicular);
            this.GBIdentificacion.Controls.Add(this.CmbConfigVehicular);
            this.GBIdentificacion.Controls.Add(this.label3);
            this.GBIdentificacion.Controls.Add(this.label2);
            this.GBIdentificacion.Controls.Add(this.label1);
            this.GBIdentificacion.Location = new System.Drawing.Point(4, -2);
            this.GBIdentificacion.Name = "GBIdentificacion";
            this.GBIdentificacion.Size = new System.Drawing.Size(452, 77);
            this.GBIdentificacion.TabIndex = 0;
            this.GBIdentificacion.TabStop = false;
            // 
            // TxtAñoModelo
            // 
            this.TxtAñoModelo.Location = new System.Drawing.Point(337, 45);
            this.TxtAñoModelo.Name = "TxtAñoModelo";
            this.TxtAñoModelo.Size = new System.Drawing.Size(100, 20);
            this.TxtAñoModelo.TabIndex = 5;
            // 
            // TxtPlacaVehicular
            // 
            this.TxtPlacaVehicular.Location = new System.Drawing.Point(188, 45);
            this.TxtPlacaVehicular.Name = "TxtPlacaVehicular";
            this.TxtPlacaVehicular.Size = new System.Drawing.Size(100, 20);
            this.TxtPlacaVehicular.TabIndex = 4;
            // 
            // CmbConfigVehicular
            // 
            this.CmbConfigVehicular.FormattingEnabled = true;
            this.CmbConfigVehicular.Location = new System.Drawing.Point(10, 45);
            this.CmbConfigVehicular.Name = "CmbConfigVehicular";
            this.CmbConfigVehicular.Size = new System.Drawing.Size(157, 21);
            this.CmbConfigVehicular.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año modelo\r\nvehículo motor*:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa vehículo motor*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración vehicular*:";
            // 
            // IdentificacionVehicularControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBIdentificacion);
            this.Name = "IdentificacionVehicularControl";
            this.Size = new System.Drawing.Size(463, 81);
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
    }
}
