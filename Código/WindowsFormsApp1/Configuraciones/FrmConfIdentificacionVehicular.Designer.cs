
namespace WindowsFormsApp1.Configuraciones
{
    partial class FrmConfIdentificacionVehicular
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
            this.identificacionVehicularControl1 = new WindowsFormsApp1.ControlesTerrestre.IdentificacionVehicularControl();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // identificacionVehicularControl1
            // 
            this.identificacionVehicularControl1.Location = new System.Drawing.Point(12, 12);
            this.identificacionVehicularControl1.Name = "identificacionVehicularControl1";
            this.identificacionVehicularControl1.Size = new System.Drawing.Size(584, 81);
            this.identificacionVehicularControl1.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(500, 99);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmConfIdentificacionVehicular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 135);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.identificacionVehicularControl1);
            this.Name = "FrmConfIdentificacionVehicular";
            this.Text = "FrmConfIdentificacionVehicular";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesTerrestre.IdentificacionVehicularControl identificacionVehicularControl1;
        private System.Windows.Forms.Button BtnGuardar;
    }
}