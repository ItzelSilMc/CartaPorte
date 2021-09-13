
namespace WindowsFormsApp1.ControlesGenerales
{
    partial class BotonesPersonasControl
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
            this.BtnTransportista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNotificado = new System.Windows.Forms.Button();
            this.BtnPropietario = new System.Windows.Forms.Button();
            this.BtnArrendatario = new System.Windows.Forms.Button();
            this.BtnEmbarcador = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTransportista
            // 
            this.BtnTransportista.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransportista.Enabled = false;
            this.BtnTransportista.Location = new System.Drawing.Point(0, 0);
            this.BtnTransportista.Name = "BtnTransportista";
            this.BtnTransportista.Size = new System.Drawing.Size(89, 60);
            this.BtnTransportista.TabIndex = 0;
            this.BtnTransportista.Text = "Seleccionar transportista";
            this.BtnTransportista.UseVisualStyleBackColor = true;
            this.BtnTransportista.Click += new System.EventHandler(this.BtnTransportista_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnNotificado);
            this.panel1.Controls.Add(this.BtnPropietario);
            this.panel1.Controls.Add(this.BtnArrendatario);
            this.panel1.Controls.Add(this.BtnEmbarcador);
            this.panel1.Controls.Add(this.BtnTransportista);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 303);
            this.panel1.TabIndex = 1;
            // 
            // BtnNotificado
            // 
            this.BtnNotificado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNotificado.Location = new System.Drawing.Point(0, 240);
            this.BtnNotificado.Name = "BtnNotificado";
            this.BtnNotificado.Size = new System.Drawing.Size(89, 60);
            this.BtnNotificado.TabIndex = 4;
            this.BtnNotificado.Text = "Seleccionar notificado";
            this.BtnNotificado.UseVisualStyleBackColor = true;
            this.BtnNotificado.Click += new System.EventHandler(this.BtnNotificado_Click);
            // 
            // BtnPropietario
            // 
            this.BtnPropietario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPropietario.Enabled = false;
            this.BtnPropietario.Location = new System.Drawing.Point(0, 180);
            this.BtnPropietario.Name = "BtnPropietario";
            this.BtnPropietario.Size = new System.Drawing.Size(89, 60);
            this.BtnPropietario.TabIndex = 3;
            this.BtnPropietario.Text = "Seleccionar propietario";
            this.BtnPropietario.UseVisualStyleBackColor = true;
            this.BtnPropietario.Click += new System.EventHandler(this.BtnPropietario_Click);
            // 
            // BtnArrendatario
            // 
            this.BtnArrendatario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnArrendatario.Enabled = false;
            this.BtnArrendatario.Location = new System.Drawing.Point(0, 120);
            this.BtnArrendatario.Name = "BtnArrendatario";
            this.BtnArrendatario.Size = new System.Drawing.Size(89, 60);
            this.BtnArrendatario.TabIndex = 2;
            this.BtnArrendatario.Text = "Seleccionar arrendatario";
            this.BtnArrendatario.UseVisualStyleBackColor = true;
            this.BtnArrendatario.Click += new System.EventHandler(this.BtnArrendatario_Click);
            // 
            // BtnEmbarcador
            // 
            this.BtnEmbarcador.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmbarcador.Enabled = false;
            this.BtnEmbarcador.Location = new System.Drawing.Point(0, 60);
            this.BtnEmbarcador.Name = "BtnEmbarcador";
            this.BtnEmbarcador.Size = new System.Drawing.Size(89, 60);
            this.BtnEmbarcador.TabIndex = 1;
            this.BtnEmbarcador.Text = "Seleccionar embarcador";
            this.BtnEmbarcador.UseVisualStyleBackColor = true;
            this.BtnEmbarcador.Click += new System.EventHandler(this.BtnEmbarcador_Click);
            // 
            // BotonesPersonasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "BotonesPersonasControl";
            this.Size = new System.Drawing.Size(93, 307);
            this.Load += new System.EventHandler(this.BotonesPersonasControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnTransportista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPropietario;
        private System.Windows.Forms.Button BtnArrendatario;
        private System.Windows.Forms.Button BtnEmbarcador;
        private System.Windows.Forms.Button BtnNotificado;
    }
}
