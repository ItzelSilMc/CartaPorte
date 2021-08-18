
namespace WindowsFormsApp1
{
    partial class FrmTransporteTerrestre
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfigurarOperador = new System.Windows.Forms.Button();
            this.remolqueControl1 = new WindowsFormsApp1.ControlesTerrestre.RemolqueControl();
            this.identificacionVehicularControl1 = new WindowsFormsApp1.ControlesTerrestre.IdentificacionVehicularControl();
            this.autotransporteFederalControl1 = new WindowsFormsApp1.ControlesTerrestre.AutotransporteFederalControl();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BtnTransportista = new System.Windows.Forms.Button();
            this.BtnEmbarcador = new System.Windows.Forms.Button();
            this.BtnArrendatario = new System.Windows.Forms.Button();
            this.BtnPropietario = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 404);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.remolqueControl1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(5, 290);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(604, 108);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(1, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(603, 35);
            this.panel7.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remolque";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.identificacionVehicularControl1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(5, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 131);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(603, 35);
            this.panel5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificador Vehicular";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.autotransporteFederalControl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(4, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 132);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 35);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autotransporte Federal:";
            // 
            // BtnConfigurarOperador
            // 
            this.BtnConfigurarOperador.Location = new System.Drawing.Point(500, 422);
            this.BtnConfigurarOperador.Name = "BtnConfigurarOperador";
            this.BtnConfigurarOperador.Size = new System.Drawing.Size(121, 23);
            this.BtnConfigurarOperador.TabIndex = 1;
            this.BtnConfigurarOperador.Text = "Configurar operador";
            this.BtnConfigurarOperador.UseVisualStyleBackColor = true;
            this.BtnConfigurarOperador.Click += new System.EventHandler(this.BtnConfigurarOperador_Click);
            // 
            // remolqueControl1
            // 
            this.remolqueControl1.Location = new System.Drawing.Point(143, 45);
            this.remolqueControl1.Name = "remolqueControl1";
            this.remolqueControl1.Size = new System.Drawing.Size(275, 62);
            this.remolqueControl1.TabIndex = 4;
            // 
            // identificacionVehicularControl1
            // 
            this.identificacionVehicularControl1.Location = new System.Drawing.Point(76, 44);
            this.identificacionVehicularControl1.Name = "identificacionVehicularControl1";
            this.identificacionVehicularControl1.Size = new System.Drawing.Size(463, 81);
            this.identificacionVehicularControl1.TabIndex = 3;
            // 
            // autotransporteFederalControl1
            // 
            this.autotransporteFederalControl1.Location = new System.Drawing.Point(-1, 44);
            this.autotransporteFederalControl1.Name = "autotransporteFederalControl1";
            this.autotransporteFederalControl1.Size = new System.Drawing.Size(605, 86);
            this.autotransporteFederalControl1.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.BtnGuardar);
            this.panel8.Controls.Add(this.BtnPropietario);
            this.panel8.Controls.Add(this.BtnArrendatario);
            this.panel8.Controls.Add(this.BtnEmbarcador);
            this.panel8.Controls.Add(this.BtnTransportista);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(634, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(89, 450);
            this.panel8.TabIndex = 2;
            // 
            // BtnTransportista
            // 
            this.BtnTransportista.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransportista.Location = new System.Drawing.Point(0, 0);
            this.BtnTransportista.Name = "BtnTransportista";
            this.BtnTransportista.Size = new System.Drawing.Size(89, 50);
            this.BtnTransportista.TabIndex = 0;
            this.BtnTransportista.Text = "Añadir transportista";
            this.BtnTransportista.UseVisualStyleBackColor = true;
            this.BtnTransportista.Click += new System.EventHandler(this.BtnTransportista_Click);
            // 
            // BtnEmbarcador
            // 
            this.BtnEmbarcador.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmbarcador.Location = new System.Drawing.Point(0, 50);
            this.BtnEmbarcador.Name = "BtnEmbarcador";
            this.BtnEmbarcador.Size = new System.Drawing.Size(89, 50);
            this.BtnEmbarcador.TabIndex = 1;
            this.BtnEmbarcador.Text = "Añadir Embarcador";
            this.BtnEmbarcador.UseVisualStyleBackColor = true;
            this.BtnEmbarcador.Click += new System.EventHandler(this.BtnEmbarcador_Click);
            // 
            // BtnArrendatario
            // 
            this.BtnArrendatario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnArrendatario.Location = new System.Drawing.Point(0, 100);
            this.BtnArrendatario.Name = "BtnArrendatario";
            this.BtnArrendatario.Size = new System.Drawing.Size(89, 50);
            this.BtnArrendatario.TabIndex = 2;
            this.BtnArrendatario.Text = "Añadir arrendatario";
            this.BtnArrendatario.UseVisualStyleBackColor = true;
            this.BtnArrendatario.Click += new System.EventHandler(this.BtnArrendatario_Click);
            // 
            // BtnPropietario
            // 
            this.BtnPropietario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPropietario.Location = new System.Drawing.Point(0, 150);
            this.BtnPropietario.Name = "BtnPropietario";
            this.BtnPropietario.Size = new System.Drawing.Size(89, 50);
            this.BtnPropietario.TabIndex = 3;
            this.BtnPropietario.Text = "Añadir propietario";
            this.BtnPropietario.UseVisualStyleBackColor = true;
            this.BtnPropietario.Click += new System.EventHandler(this.BtnPropietario_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnGuardar.Location = new System.Drawing.Point(0, 400);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(89, 50);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmTransporteTerrestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.BtnConfigurarOperador);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTransporteTerrestre";
            this.Load += new System.EventHandler(this.FrmTransporteTerrestre_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private ControlesTerrestre.RemolqueControl remolqueControl1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private ControlesTerrestre.IdentificacionVehicularControl identificacionVehicularControl1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private ControlesTerrestre.AutotransporteFederalControl autotransporteFederalControl1;
        private System.Windows.Forms.Button BtnConfigurarOperador;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BtnTransportista;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnPropietario;
        private System.Windows.Forms.Button BtnArrendatario;
        private System.Windows.Forms.Button BtnEmbarcador;
    }
}