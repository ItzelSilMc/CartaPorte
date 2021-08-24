
namespace WindowsFormsApp1.ControlesFerroviario
{
    partial class CarroControlControl
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
            this.GBCarro = new System.Windows.Forms.GroupBox();
            this.TxtToneladasNetoCarro = new System.Windows.Forms.TextBox();
            this.TxtGuiaCarro = new System.Windows.Forms.TextBox();
            this.TxtMatriculaCarro = new System.Windows.Forms.TextBox();
            this.CmbTipoCarro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GBCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCarro
            // 
            this.GBCarro.Controls.Add(this.TxtToneladasNetoCarro);
            this.GBCarro.Controls.Add(this.TxtGuiaCarro);
            this.GBCarro.Controls.Add(this.TxtMatriculaCarro);
            this.GBCarro.Controls.Add(this.CmbTipoCarro);
            this.GBCarro.Controls.Add(this.label4);
            this.GBCarro.Controls.Add(this.label3);
            this.GBCarro.Controls.Add(this.label2);
            this.GBCarro.Controls.Add(this.label1);
            this.GBCarro.Location = new System.Drawing.Point(3, 3);
            this.GBCarro.Name = "GBCarro";
            this.GBCarro.Size = new System.Drawing.Size(583, 59);
            this.GBCarro.TabIndex = 0;
            this.GBCarro.TabStop = false;
            // 
            // TxtToneladasNetoCarro
            // 
            this.TxtToneladasNetoCarro.Location = new System.Drawing.Point(439, 32);
            this.TxtToneladasNetoCarro.Name = "TxtToneladasNetoCarro";
            this.TxtToneladasNetoCarro.Size = new System.Drawing.Size(100, 20);
            this.TxtToneladasNetoCarro.TabIndex = 7;
            // 
            // TxtGuiaCarro
            // 
            this.TxtGuiaCarro.Location = new System.Drawing.Point(313, 32);
            this.TxtGuiaCarro.Name = "TxtGuiaCarro";
            this.TxtGuiaCarro.Size = new System.Drawing.Size(100, 20);
            this.TxtGuiaCarro.TabIndex = 6;
            // 
            // TxtMatriculaCarro
            // 
            this.TxtMatriculaCarro.Location = new System.Drawing.Point(194, 31);
            this.TxtMatriculaCarro.Name = "TxtMatriculaCarro";
            this.TxtMatriculaCarro.Size = new System.Drawing.Size(100, 20);
            this.TxtMatriculaCarro.TabIndex = 5;
            // 
            // CmbTipoCarro
            // 
            this.CmbTipoCarro.FormattingEnabled = true;
            this.CmbTipoCarro.Location = new System.Drawing.Point(25, 31);
            this.CmbTipoCarro.Name = "CmbTipoCarro";
            this.CmbTipoCarro.Size = new System.Drawing.Size(152, 21);
            this.CmbTipoCarro.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tonaladas netas del carro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guia del carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricula carro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo carro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // CarroControlControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBCarro);
            this.Name = "CarroControlControl";
            this.Size = new System.Drawing.Size(592, 68);
            this.Load += new System.EventHandler(this.CarroControlControl_Load);
            this.GBCarro.ResumeLayout(false);
            this.GBCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCarro;
        private System.Windows.Forms.TextBox TxtMatriculaCarro;
        private System.Windows.Forms.ComboBox CmbTipoCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtToneladasNetoCarro;
        private System.Windows.Forms.TextBox TxtGuiaCarro;
        private System.Windows.Forms.Label label5;
    }
}
