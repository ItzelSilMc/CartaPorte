
namespace WindowsFormsApp1.ControlesTerrestre
{
    partial class RemolqueControl
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
            this.GBRemolque = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRemolque = new System.Windows.Forms.ComboBox();
            this.TxtPlacaRemolque = new System.Windows.Forms.TextBox();
            this.CmbTipoRemolque = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textTipoRemolque = new System.Windows.Forms.TextBox();
            this.GBRemolque.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBRemolque
            // 
            this.GBRemolque.Controls.Add(this.textTipoRemolque);
            this.GBRemolque.Controls.Add(this.label3);
            this.GBRemolque.Controls.Add(this.comboRemolque);
            this.GBRemolque.Controls.Add(this.TxtPlacaRemolque);
            this.GBRemolque.Controls.Add(this.CmbTipoRemolque);
            this.GBRemolque.Controls.Add(this.label2);
            this.GBRemolque.Controls.Add(this.label1);
            this.GBRemolque.Location = new System.Drawing.Point(4, 1);
            this.GBRemolque.Name = "GBRemolque";
            this.GBRemolque.Size = new System.Drawing.Size(470, 111);
            this.GBRemolque.TabIndex = 0;
            this.GBRemolque.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccion configuracion remolque:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboRemolque
            // 
            this.comboRemolque.FormattingEnabled = true;
            this.comboRemolque.Location = new System.Drawing.Point(192, 22);
            this.comboRemolque.Name = "comboRemolque";
            this.comboRemolque.Size = new System.Drawing.Size(254, 21);
            this.comboRemolque.TabIndex = 4;
            this.comboRemolque.SelectedIndexChanged += new System.EventHandler(this.comboRemolque_SelectedIndexChanged);
            // 
            // TxtPlacaRemolque
            // 
            this.TxtPlacaRemolque.Location = new System.Drawing.Point(192, 77);
            this.TxtPlacaRemolque.MaxLength = 10;
            this.TxtPlacaRemolque.Name = "TxtPlacaRemolque";
            this.TxtPlacaRemolque.Size = new System.Drawing.Size(100, 20);
            this.TxtPlacaRemolque.TabIndex = 3;
            // 
            // CmbTipoRemolque
            // 
            this.CmbTipoRemolque.FormattingEnabled = true;
            this.CmbTipoRemolque.Location = new System.Drawing.Point(22, 77);
            this.CmbTipoRemolque.Name = "CmbTipoRemolque";
            this.CmbTipoRemolque.Size = new System.Drawing.Size(164, 21);
            this.CmbTipoRemolque.TabIndex = 2;
            this.CmbTipoRemolque.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtipo de remolque*:";
            // 
            // textTipoRemolque
            // 
            this.textTipoRemolque.Location = new System.Drawing.Point(22, 78);
            this.textTipoRemolque.Name = "textTipoRemolque";
            this.textTipoRemolque.Size = new System.Drawing.Size(134, 20);
            this.textTipoRemolque.TabIndex = 6;
            // 
            // RemolqueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBRemolque);
            this.Name = "RemolqueControl";
            this.Size = new System.Drawing.Size(474, 112);
            this.GBRemolque.ResumeLayout(false);
            this.GBRemolque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBRemolque;
        private System.Windows.Forms.TextBox TxtPlacaRemolque;
        private System.Windows.Forms.ComboBox CmbTipoRemolque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRemolque;
        private System.Windows.Forms.TextBox textTipoRemolque;
    }
}
