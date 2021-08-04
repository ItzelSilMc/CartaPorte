
namespace WindowsFormsApp1.ControlesFerroviario
{
    partial class ContenedorFerroviarioControl
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
            this.GBContenedor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CMBTipoContenedor = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GBContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBContenedor
            // 
            this.GBContenedor.Controls.Add(this.textBox2);
            this.GBContenedor.Controls.Add(this.textBox1);
            this.GBContenedor.Controls.Add(this.CMBTipoContenedor);
            this.GBContenedor.Controls.Add(this.label3);
            this.GBContenedor.Controls.Add(this.label2);
            this.GBContenedor.Controls.Add(this.label1);
            this.GBContenedor.Location = new System.Drawing.Point(3, -1);
            this.GBContenedor.Name = "GBContenedor";
            this.GBContenedor.Size = new System.Drawing.Size(485, 78);
            this.GBContenedor.TabIndex = 0;
            this.GBContenedor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de contenedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso del contenedor vacío:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso neto mercancía:";
            // 
            // CMBTipoContenedor
            // 
            this.CMBTipoContenedor.FormattingEnabled = true;
            this.CMBTipoContenedor.Location = new System.Drawing.Point(10, 49);
            this.CMBTipoContenedor.Name = "CMBTipoContenedor";
            this.CMBTipoContenedor.Size = new System.Drawing.Size(147, 21);
            this.CMBTipoContenedor.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(348, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // ContenedorFerroviarioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBContenedor);
            this.Name = "ContenedorFerroviarioControl";
            this.Size = new System.Drawing.Size(499, 83);
            this.GBContenedor.ResumeLayout(false);
            this.GBContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBContenedor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CMBTipoContenedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
