
namespace WindowsFormsApp1
{
    partial class FrmUbicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUbicaciones));
            this.GBOrigen = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbNumeroEstacion = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CmbTipoEstaciones = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.domicilioControl1 = new WindowsFormsApp1.DomicilioControl();
            this.GBOrigen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBOrigen
            // 
            this.GBOrigen.AutoSize = true;
            this.GBOrigen.Controls.Add(this.textBox4);
            this.GBOrigen.Controls.Add(this.textBox3);
            this.GBOrigen.Controls.Add(this.textBox2);
            this.GBOrigen.Controls.Add(this.label7);
            this.GBOrigen.Controls.Add(this.label6);
            this.GBOrigen.Controls.Add(this.label4);
            this.GBOrigen.Controls.Add(this.dateTimePicker2);
            this.GBOrigen.Controls.Add(this.dateTimePicker1);
            this.GBOrigen.Controls.Add(this.CmbNumeroEstacion);
            this.GBOrigen.Controls.Add(this.textBox1);
            this.GBOrigen.Controls.Add(this.CmbTipoEstaciones);
            this.GBOrigen.Controls.Add(this.domicilioControl1);
            this.GBOrigen.Controls.Add(this.label5);
            this.GBOrigen.Controls.Add(this.label3);
            this.GBOrigen.Controls.Add(this.label2);
            this.GBOrigen.Controls.Add(this.label1);
            this.GBOrigen.Location = new System.Drawing.Point(13, 12);
            this.GBOrigen.Name = "GBOrigen";
            this.GBOrigen.Size = new System.Drawing.Size(611, 390);
            this.GBOrigen.TabIndex = 0;
            this.GBOrigen.TabStop = false;
            this.GBOrigen.Text = "Ubicacion";
            this.GBOrigen.AutoSizeChanged += new System.EventHandler(this.GBOrigen_AutoSizeChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(362, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre Remitente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "RFC Remitente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha y hora";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(185, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // CmbNumeroEstacion
            // 
            this.CmbNumeroEstacion.FormattingEnabled = true;
            this.CmbNumeroEstacion.Location = new System.Drawing.Point(184, 38);
            this.CmbNumeroEstacion.Name = "CmbNumeroEstacion";
            this.CmbNumeroEstacion.Size = new System.Drawing.Size(146, 21);
            this.CmbNumeroEstacion.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // CmbTipoEstaciones
            // 
            this.CmbTipoEstaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoEstaciones.FormattingEnabled = true;
            this.CmbTipoEstaciones.Location = new System.Drawing.Point(32, 38);
            this.CmbTipoEstaciones.Name = "CmbTipoEstaciones";
            this.CmbTipoEstaciones.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoEstaciones.TabIndex = 6;
            this.CmbTipoEstaciones.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre de estacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número Estacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distancia recorrida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de estacion*:";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(628, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 414);
            this.panel1.TabIndex = 3;
            // 
            // domicilioControl1
            // 
            this.domicilioControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.domicilioControl1.Location = new System.Drawing.Point(3, 187);
            this.domicilioControl1.Name = "domicilioControl1";
            this.domicilioControl1.Size = new System.Drawing.Size(605, 200);
            this.domicilioControl1.TabIndex = 5;
            // 
            // FrmUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(710, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GBOrigen);
            this.Name = "FrmUbicaciones";
            this.Text = "Ubicaciones";
            this.Load += new System.EventHandler(this.FrmUbicaciones_Load);
            this.GBOrigen.ResumeLayout(false);
            this.GBOrigen.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBOrigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CmbTipoEstaciones;
        private DomicilioControl domicilioControl1;
        private System.Windows.Forms.ComboBox CmbNumeroEstacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}