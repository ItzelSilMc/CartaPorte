
namespace WindowsFormsApp1
{
    partial class FrmMenuAutotransportes
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
            this.BtnTransporte = new System.Windows.Forms.Button();
            this.BtnIdentificacionVehicular = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnRemolque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTransporte
            // 
            this.BtnTransporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransporte.Location = new System.Drawing.Point(0, 0);
            this.BtnTransporte.Name = "BtnTransporte";
            this.BtnTransporte.Size = new System.Drawing.Size(174, 74);
            this.BtnTransporte.TabIndex = 0;
            this.BtnTransporte.Text = "Autotransporte federal";
            this.BtnTransporte.UseVisualStyleBackColor = true;
            this.BtnTransporte.Click += new System.EventHandler(this.BtnTransporte_Click);
            // 
            // BtnIdentificacionVehicular
            // 
            this.BtnIdentificacionVehicular.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIdentificacionVehicular.Location = new System.Drawing.Point(0, 74);
            this.BtnIdentificacionVehicular.Name = "BtnIdentificacionVehicular";
            this.BtnIdentificacionVehicular.Size = new System.Drawing.Size(174, 74);
            this.BtnIdentificacionVehicular.TabIndex = 1;
            this.BtnIdentificacionVehicular.Text = " Identificación Vehicular";
            this.BtnIdentificacionVehicular.UseVisualStyleBackColor = true;
            this.BtnIdentificacionVehicular.Click += new System.EventHandler(this.BtnIdentificacionVehicular_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(0, 224);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(174, 74);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnRemolque
            // 
            this.BtnRemolque.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRemolque.Location = new System.Drawing.Point(0, 148);
            this.BtnRemolque.Name = "BtnRemolque";
            this.BtnRemolque.Size = new System.Drawing.Size(174, 74);
            this.BtnRemolque.TabIndex = 3;
            this.BtnRemolque.Text = "Remolques";
            this.BtnRemolque.UseVisualStyleBackColor = true;
            this.BtnRemolque.Click += new System.EventHandler(this.BtnRemolque_Click);
            // 
            // FrmMenuAutotransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 298);
            this.Controls.Add(this.BtnRemolque);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIdentificacionVehicular);
            this.Controls.Add(this.BtnTransporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAutotransportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTransporte;
        private System.Windows.Forms.Button BtnIdentificacionVehicular;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnRemolque;
    }
}