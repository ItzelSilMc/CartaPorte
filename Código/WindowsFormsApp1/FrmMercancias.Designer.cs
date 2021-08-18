
namespace WindowsFormsApp1
{
    partial class FrmMercancias
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GBMercancias = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtNumTotalMercancias = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PNMercancias = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GBMercancias.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso bruto total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidad de peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso neto total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número total de mercancías*:";
            // 
            // GBMercancias
            // 
            this.GBMercancias.Controls.Add(this.comboBox1);
            this.GBMercancias.Controls.Add(this.TxtNumTotalMercancias);
            this.GBMercancias.Controls.Add(this.textBox3);
            this.GBMercancias.Controls.Add(this.textBox1);
            this.GBMercancias.Controls.Add(this.label1);
            this.GBMercancias.Controls.Add(this.label4);
            this.GBMercancias.Controls.Add(this.label2);
            this.GBMercancias.Controls.Add(this.label3);
            this.GBMercancias.Location = new System.Drawing.Point(12, 24);
            this.GBMercancias.Name = "GBMercancias";
            this.GBMercancias.Size = new System.Drawing.Size(561, 100);
            this.GBMercancias.TabIndex = 4;
            this.GBMercancias.TabStop = false;
            this.GBMercancias.Text = "Mercancías";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // TxtNumTotalMercancias
            // 
            this.TxtNumTotalMercancias.Location = new System.Drawing.Point(404, 57);
            this.TxtNumTotalMercancias.Name = "TxtNumTotalMercancias";
            this.TxtNumTotalMercancias.Size = new System.Drawing.Size(100, 20);
            this.TxtNumTotalMercancias.TabIndex = 7;
            this.TxtNumTotalMercancias.Leave += new System.EventHandler(this.TxtNumTotalMercancias_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // PNMercancias
            // 
            this.PNMercancias.AutoScroll = true;
            this.PNMercancias.Location = new System.Drawing.Point(13, 146);
            this.PNMercancias.Name = "PNMercancias";
            this.PNMercancias.Size = new System.Drawing.Size(778, 241);
            this.PNMercancias.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(700, 406);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmMercancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.PNMercancias);
            this.Controls.Add(this.GBMercancias);
            this.Name = "FrmMercancias";
            this.GBMercancias.ResumeLayout(false);
            this.GBMercancias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GBMercancias;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtNumTotalMercancias;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PNMercancias;
        private System.Windows.Forms.Button BtnGuardar;
    }
}