﻿
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CmbTipoRemolque = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBRemolque.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBRemolque
            // 
            this.GBRemolque.Controls.Add(this.textBox1);
            this.GBRemolque.Controls.Add(this.CmbTipoRemolque);
            this.GBRemolque.Controls.Add(this.label2);
            this.GBRemolque.Controls.Add(this.label1);
            this.GBRemolque.Location = new System.Drawing.Point(4, 1);
            this.GBRemolque.Name = "GBRemolque";
            this.GBRemolque.Size = new System.Drawing.Size(267, 57);
            this.GBRemolque.TabIndex = 0;
            this.GBRemolque.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // CmbTipoRemolque
            // 
            this.CmbTipoRemolque.FormattingEnabled = true;
            this.CmbTipoRemolque.Location = new System.Drawing.Point(10, 28);
            this.CmbTipoRemolque.Name = "CmbTipoRemolque";
            this.CmbTipoRemolque.Size = new System.Drawing.Size(131, 21);
            this.CmbTipoRemolque.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtipo de remolque*:";
            // 
            // RemolqueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBRemolque);
            this.Name = "RemolqueControl";
            this.Size = new System.Drawing.Size(275, 62);
            this.GBRemolque.ResumeLayout(false);
            this.GBRemolque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBRemolque;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CmbTipoRemolque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
