namespace WindowsFormsApp1
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TxtTotalDistRecorrida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvUbicaciones = new System.Windows.Forms.DataGridView();
            this.TipoUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaRecorrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnUbicacionNueva = new System.Windows.Forms.Button();
            this.BtnMercancia = new System.Windows.Forms.Button();
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
            this.BtnConfigurarTransporte = new System.Windows.Forms.Button();
            this.CmbEntradaSalidaMercancia = new System.Windows.Forms.ComboBox();
            this.CmbViaEntradaSalida = new System.Windows.Forms.ComboBox();
            this.GBTransporte = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbInternacional = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GBTransporte.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // TxtTotalDistRecorrida
            // 
            this.TxtTotalDistRecorrida.Location = new System.Drawing.Point(461, 63);
            this.TxtTotalDistRecorrida.Name = "TxtTotalDistRecorrida";
            this.TxtTotalDistRecorrida.Size = new System.Drawing.Size(121, 20);
            this.TxtTotalDistRecorrida.TabIndex = 3;
            this.TxtTotalDistRecorrida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotalDistRecorrida_KeyPress);
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
            this.label6.Location = new System.Drawing.Point(16, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "UBICACIONES";
            // 
            // DgvUbicaciones
            // 
            this.DgvUbicaciones.AllowUserToAddRows = false;
            this.DgvUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUbicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoUbicacion,
            this.DistanciaRecorrida,
            this.TipoEstacion,
            this.idUbicacion,
            this.Modificar});
            this.DgvUbicaciones.Location = new System.Drawing.Point(12, 190);
            this.DgvUbicaciones.Name = "DgvUbicaciones";
            this.DgvUbicaciones.RowHeadersVisible = false;
            this.DgvUbicaciones.Size = new System.Drawing.Size(776, 150);
            this.DgvUbicaciones.TabIndex = 13;
            this.DgvUbicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUbicaciones_CellContentClick);
            this.DgvUbicaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGUbicaciones_CellDoubleClick);
            this.DgvUbicaciones.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvUbicaciones_CellPainting);
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
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            // 
            // BtnUbicacionNueva
            // 
            this.BtnUbicacionNueva.Location = new System.Drawing.Point(110, 153);
            this.BtnUbicacionNueva.Name = "BtnUbicacionNueva";
            this.BtnUbicacionNueva.Size = new System.Drawing.Size(144, 23);
            this.BtnUbicacionNueva.TabIndex = 14;
            this.BtnUbicacionNueva.Text = "Añadir Ubicación";
            this.BtnUbicacionNueva.UseVisualStyleBackColor = true;
            this.BtnUbicacionNueva.Click += new System.EventHandler(this.BtnUbicacionNueva_Click);
            // 
            // BtnMercancia
            // 
            this.BtnMercancia.Location = new System.Drawing.Point(119, 362);
            this.BtnMercancia.Name = "BtnMercancia";
            this.BtnMercancia.Size = new System.Drawing.Size(144, 23);
            this.BtnMercancia.TabIndex = 16;
            this.BtnMercancia.Text = "Añadir Mercancia";
            this.BtnMercancia.UseVisualStyleBackColor = true;
            this.BtnMercancia.Click += new System.EventHandler(this.BtnMercancia_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 367);
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 400);
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
            this.textBox6.Location = new System.Drawing.Point(542, 373);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(108, 20);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(672, 373);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(106, 20);
            this.textBox7.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "NumTotalMercancias:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(671, 353);
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
            // BtnConfigurarTransporte
            // 
            this.BtnConfigurarTransporte.Location = new System.Drawing.Point(19, 26);
            this.BtnConfigurarTransporte.Name = "BtnConfigurarTransporte";
            this.BtnConfigurarTransporte.Size = new System.Drawing.Size(144, 23);
            this.BtnConfigurarTransporte.TabIndex = 28;
            this.BtnConfigurarTransporte.Text = "Configurar Transporte";
            this.BtnConfigurarTransporte.UseVisualStyleBackColor = true;
            this.BtnConfigurarTransporte.Click += new System.EventHandler(this.BtnConfigurarTransporte_Click);
            // 
            // CmbEntradaSalidaMercancia
            // 
            this.CmbEntradaSalidaMercancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEntradaSalidaMercancia.FormattingEnabled = true;
            this.CmbEntradaSalidaMercancia.Items.AddRange(new object[] {
            "ENTRADA",
            "SALIDA"});
            this.CmbEntradaSalidaMercancia.Location = new System.Drawing.Point(461, 33);
            this.CmbEntradaSalidaMercancia.Name = "CmbEntradaSalidaMercancia";
            this.CmbEntradaSalidaMercancia.Size = new System.Drawing.Size(121, 21);
            this.CmbEntradaSalidaMercancia.TabIndex = 29;
            // 
            // CmbViaEntradaSalida
            // 
            this.CmbViaEntradaSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbViaEntradaSalida.FormattingEnabled = true;
            this.CmbViaEntradaSalida.Location = new System.Drawing.Point(134, 61);
            this.CmbViaEntradaSalida.Name = "CmbViaEntradaSalida";
            this.CmbViaEntradaSalida.Size = new System.Drawing.Size(121, 21);
            this.CmbViaEntradaSalida.TabIndex = 30;
            // 
            // GBTransporte
            // 
            this.GBTransporte.Controls.Add(this.BtnConfigurarTransporte);
            this.GBTransporte.Location = new System.Drawing.Point(15, 569);
            this.GBTransporte.Name = "GBTransporte";
            this.GBTransporte.Size = new System.Drawing.Size(179, 63);
            this.GBTransporte.TabIndex = 31;
            this.GBTransporte.TabStop = false;
            this.GBTransporte.Text = "Transporte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbInternacional);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbViaEntradaSalida);
            this.groupBox1.Controls.Add(this.TxtTotalDistRecorrida);
            this.groupBox1.Controls.Add(this.CmbEntradaSalidaMercancia);
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
            // CmbInternacional
            // 
            this.CmbInternacional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbInternacional.FormattingEnabled = true;
            this.CmbInternacional.Location = new System.Drawing.Point(134, 33);
            this.CmbInternacional.Name = "CmbInternacional";
            this.CmbInternacional.Size = new System.Drawing.Size(121, 21);
            this.CmbInternacional.TabIndex = 31;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(692, 595);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 33;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBTransporte);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnMercancia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnUbicacionNueva);
            this.Controls.Add(this.DgvUbicaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Name = "FrmPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GBTransporte.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TxtTotalDistRecorrida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvUbicaciones;
        private System.Windows.Forms.Button BtnUbicacionNueva;
        private System.Windows.Forms.Button BtnMercancia;
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
        private System.Windows.Forms.Button BtnConfigurarTransporte;
        private System.Windows.Forms.ComboBox CmbEntradaSalidaMercancia;
        private System.Windows.Forms.ComboBox CmbViaEntradaSalida;
        private System.Windows.Forms.GroupBox GBTransporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CmbInternacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaRecorrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUbicacion;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
    }
}

