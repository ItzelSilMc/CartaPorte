namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGUbicaciones = new System.Windows.Forms.DataGridView();
            this.TipoUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaRecorrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumTotalMercancias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMercancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargoPorTasacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimensiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoEnKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorMercancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalleMercancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.GBTransporte = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GBTransporte.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(461, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "INVOICE_ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Transporte Internal*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Entrada Salida Mercancía:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ViaEntradaSalida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TotalDisRec:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "UBICACIONES";
            // 
            // dataGUbicaciones
            // 
            this.dataGUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGUbicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoUbicacion,
            this.DistanciaRecorrida,
            this.TipoEstacion,
            this.idUbicacion});
            this.dataGUbicaciones.Location = new System.Drawing.Point(21, 246);
            this.dataGUbicaciones.Name = "dataGUbicaciones";
            this.dataGUbicaciones.Size = new System.Drawing.Size(776, 150);
            this.dataGUbicaciones.TabIndex = 13;
            this.dataGUbicaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGUbicaciones_CellDoubleClick);
            // 
            // TipoUbicacion
            // 
            this.TipoUbicacion.HeaderText = "TipoUbicacion";
            this.TipoUbicacion.Name = "TipoUbicacion";
            // 
            // DistanciaRecorrida
            // 
            this.DistanciaRecorrida.HeaderText = "DistanciaRecorrida";
            this.DistanciaRecorrida.Name = "DistanciaRecorrida";
            // 
            // TipoEstacion
            // 
            this.TipoEstacion.HeaderText = "TipoEstacion";
            this.TipoEstacion.Name = "TipoEstacion";
            // 
            // idUbicacion
            // 
            this.idUbicacion.HeaderText = "idUbicacion";
            this.idUbicacion.Name = "idUbicacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Añadir Ubicación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Añadir Mercancia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "MERCANCIAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumTotalMercancias,
            this.idMercancia,
            this.CargoPorTasacion,
            this.Cantidad,
            this.Dimensiones,
            this.PesoEnKg,
            this.ValorMercancia,
            this.IdDetalleMercancia});
            this.dataGridView1.Location = new System.Drawing.Point(15, 452);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // NumTotalMercancias
            // 
            this.NumTotalMercancias.HeaderText = "NumTotalMercancias";
            this.NumTotalMercancias.Name = "NumTotalMercancias";
            // 
            // idMercancia
            // 
            this.idMercancia.HeaderText = "idMercancia";
            this.idMercancia.Name = "idMercancia";
            // 
            // CargoPorTasacion
            // 
            this.CargoPorTasacion.HeaderText = "CargoPorTasacion";
            this.CargoPorTasacion.Name = "CargoPorTasacion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // Dimensiones
            // 
            this.Dimensiones.HeaderText = "Dimensiones";
            this.Dimensiones.Name = "Dimensiones";
            // 
            // PesoEnKg
            // 
            this.PesoEnKg.HeaderText = "PesoEnKg";
            this.PesoEnKg.Name = "PesoEnKg";
            this.PesoEnKg.Width = 70;
            // 
            // ValorMercancia
            // 
            this.ValorMercancia.HeaderText = "ValorMercancia";
            this.ValorMercancia.Name = "ValorMercancia";
            this.ValorMercancia.Width = 70;
            // 
            // IdDetalleMercancia
            // 
            this.IdDetalleMercancia.HeaderText = "IdDetalleMercancia";
            this.IdDetalleMercancia.Name = "IdDetalleMercancia";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(542, 425);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(108, 20);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(672, 425);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(106, 20);
            this.textBox7.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "NumTotalMercancias:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(680, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "CargoPorTasacion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 565);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Configurar Transporte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ENTRADA",
            "SALIDA"});
            this.comboBox1.Location = new System.Drawing.Point(461, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // GBTransporte
            // 
            this.GBTransporte.Controls.Add(this.button3);
            this.GBTransporte.Location = new System.Drawing.Point(15, 621);
            this.GBTransporte.Name = "GBTransporte";
            this.GBTransporte.Size = new System.Drawing.Size(179, 63);
            this.GBTransporte.TabIndex = 31;
            this.GBTransporte.TabStop = false;
            this.GBTransporte.Text = "Transporte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 96);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carta Porte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 785);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBTransporte);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGUbicaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.Text = "f";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GBTransporte.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGUbicaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaRecorrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUbicacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTotalMercancias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMercancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CargoPorTasacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimensiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoEnKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorMercancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleMercancia;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox GBTransporte;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

