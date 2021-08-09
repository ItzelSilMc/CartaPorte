
namespace WindowsFormsApp1.ControlesFerroviario
{
    partial class DerechosPasoControl
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
            this.GBDerechoPaso = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CmbDerechosPaso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBDerechoPaso.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBDerechoPaso
            // 
            this.GBDerechoPaso.Controls.Add(this.textBox1);
            this.GBDerechoPaso.Controls.Add(this.CmbDerechosPaso);
            this.GBDerechoPaso.Controls.Add(this.label2);
            this.GBDerechoPaso.Controls.Add(this.label1);
            this.GBDerechoPaso.Location = new System.Drawing.Point(10, 7);
            this.GBDerechoPaso.Name = "GBDerechoPaso";
            this.GBDerechoPaso.Size = new System.Drawing.Size(345, 69);
            this.GBDerechoPaso.TabIndex = 0;
            this.GBDerechoPaso.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // CmbDerechosPaso
            // 
            this.CmbDerechosPaso.FormattingEnabled = true;
            this.CmbDerechosPaso.Location = new System.Drawing.Point(10, 37);
            this.CmbDerechosPaso.Name = "CmbDerechosPaso";
            this.CmbDerechosPaso.Size = new System.Drawing.Size(149, 21);
            this.CmbDerechosPaso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kilometraje pagado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo derecho de paso:";
            // 
            // DerechosPasoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBDerechoPaso);
            this.Name = "DerechosPasoControl";
            this.Size = new System.Drawing.Size(364, 87);
            this.GBDerechoPaso.ResumeLayout(false);
            this.GBDerechoPaso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDerechoPaso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CmbDerechosPaso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
