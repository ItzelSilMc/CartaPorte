
namespace WindowsFormsApp1.Configuraciones
{
    partial class FrmMenuPersonas
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnNotificado = new System.Windows.Forms.Button();
            this.BtnArrendatario = new System.Windows.Forms.Button();
            this.BtnPropietario = new System.Windows.Forms.Button();
            this.BtnOperador = new System.Windows.Forms.Button();
            this.BtnEmbarcador = new System.Windows.Forms.Button();
            this.BtnTransportista = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.BtnNotificado);
            this.panel1.Controls.Add(this.BtnArrendatario);
            this.panel1.Controls.Add(this.BtnPropietario);
            this.panel1.Controls.Add(this.BtnOperador);
            this.panel1.Controls.Add(this.BtnEmbarcador);
            this.panel1.Controls.Add(this.BtnTransportista);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 519);
            this.panel1.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(0, 445);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(169, 74);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnNotificado
            // 
            this.BtnNotificado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNotificado.Location = new System.Drawing.Point(0, 370);
            this.BtnNotificado.Name = "BtnNotificado";
            this.BtnNotificado.Size = new System.Drawing.Size(169, 74);
            this.BtnNotificado.TabIndex = 5;
            this.BtnNotificado.Text = "Notificado";
            this.BtnNotificado.UseVisualStyleBackColor = true;
            this.BtnNotificado.Click += new System.EventHandler(this.BtnNotificado_Click);
            // 
            // BtnArrendatario
            // 
            this.BtnArrendatario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnArrendatario.Enabled = false;
            this.BtnArrendatario.Location = new System.Drawing.Point(0, 296);
            this.BtnArrendatario.Name = "BtnArrendatario";
            this.BtnArrendatario.Size = new System.Drawing.Size(169, 74);
            this.BtnArrendatario.TabIndex = 4;
            this.BtnArrendatario.Text = "Arrendatario";
            this.BtnArrendatario.UseVisualStyleBackColor = true;
            // 
            // BtnPropietario
            // 
            this.BtnPropietario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPropietario.Enabled = false;
            this.BtnPropietario.Location = new System.Drawing.Point(0, 222);
            this.BtnPropietario.Name = "BtnPropietario";
            this.BtnPropietario.Size = new System.Drawing.Size(169, 74);
            this.BtnPropietario.TabIndex = 3;
            this.BtnPropietario.Text = "Propietario";
            this.BtnPropietario.UseVisualStyleBackColor = true;
            // 
            // BtnOperador
            // 
            this.BtnOperador.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOperador.Location = new System.Drawing.Point(0, 148);
            this.BtnOperador.Name = "BtnOperador";
            this.BtnOperador.Size = new System.Drawing.Size(169, 74);
            this.BtnOperador.TabIndex = 2;
            this.BtnOperador.Text = "Operador";
            this.BtnOperador.UseVisualStyleBackColor = true;
            this.BtnOperador.Click += new System.EventHandler(this.BtnOperador_Click);
            // 
            // BtnEmbarcador
            // 
            this.BtnEmbarcador.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmbarcador.Enabled = false;
            this.BtnEmbarcador.Location = new System.Drawing.Point(0, 74);
            this.BtnEmbarcador.Name = "BtnEmbarcador";
            this.BtnEmbarcador.Size = new System.Drawing.Size(169, 74);
            this.BtnEmbarcador.TabIndex = 1;
            this.BtnEmbarcador.Text = "Embarcador";
            this.BtnEmbarcador.UseVisualStyleBackColor = true;
            this.BtnEmbarcador.Click += new System.EventHandler(this.BtnEmbarcador_Click);
            // 
            // BtnTransportista
            // 
            this.BtnTransportista.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransportista.Enabled = false;
            this.BtnTransportista.Location = new System.Drawing.Point(0, 0);
            this.BtnTransportista.Name = "BtnTransportista";
            this.BtnTransportista.Size = new System.Drawing.Size(169, 74);
            this.BtnTransportista.TabIndex = 0;
            this.BtnTransportista.Text = "Transportista";
            this.BtnTransportista.UseVisualStyleBackColor = true;
            this.BtnTransportista.Click += new System.EventHandler(this.BtnTransportista_Click);
            // 
            // FrmMenuPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 525);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPersonas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnTransportista;
        private System.Windows.Forms.Button BtnArrendatario;
        private System.Windows.Forms.Button BtnPropietario;
        private System.Windows.Forms.Button BtnOperador;
        private System.Windows.Forms.Button BtnEmbarcador;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnNotificado;
    }
}