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
            this.ComboTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumRegIDTrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResidenciaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NavegacionTrafico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUbicacionNueva = new System.Windows.Forms.Button();
            this.BtnMercancia = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimensiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoEnKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorMercancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMercancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoTara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPiezas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalleMercancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textTotalMercancias = new System.Windows.Forms.TextBox();
            this.textTasacion = new System.Windows.Forms.TextBox();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCarga = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textPesoBruto = new System.Windows.Forms.TextBox();
            this.textUnidadPeso = new System.Windows.Forms.TextBox();
            this.textPesoTotal = new System.Windows.Forms.TextBox();
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
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            this.ComboTipo,
            this.rfc,
            this.Nombre,
            this.NumRegIDTrib,
            this.ResidenciaFiscal,
            this.NumEstacion,
            this.NombreEstacion,
            this.NavegacionTrafico,
            this.FechaHora,
            this.IdDomicilio});
            this.DgvUbicaciones.Location = new System.Drawing.Point(12, 190);
            this.DgvUbicaciones.Name = "DgvUbicaciones";
            this.DgvUbicaciones.RowHeadersVisible = false;
            this.DgvUbicaciones.Size = new System.Drawing.Size(929, 120);
            this.DgvUbicaciones.TabIndex = 13;
            this.DgvUbicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUbicaciones_CellContentClick);
            this.DgvUbicaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGUbicaciones_CellDoubleClick);
            this.DgvUbicaciones.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvUbicaciones_CellPainting);
            // 
            // ComboTipo
            // 
            this.ComboTipo.HeaderText = "Tipo de Estación";
            this.ComboTipo.Items.AddRange(new object[] {
            "02-Intermedia",
            "03-Destino Final"});
            this.ComboTipo.Name = "ComboTipo";
            // 
            // rfc
            // 
            this.rfc.HeaderText = "RFC";
            this.rfc.Name = "rfc";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // NumRegIDTrib
            // 
            this.NumRegIDTrib.HeaderText = "NumRegIDTrib";
            this.NumRegIDTrib.Name = "NumRegIDTrib";
            // 
            // ResidenciaFiscal
            // 
            this.ResidenciaFiscal.HeaderText = "ResidenciaFiscal";
            this.ResidenciaFiscal.Name = "ResidenciaFiscal";
            // 
            // NumEstacion
            // 
            this.NumEstacion.HeaderText = "NumEstacion";
            this.NumEstacion.Name = "NumEstacion";
            // 
            // NombreEstacion
            // 
            this.NombreEstacion.HeaderText = "NombreEstación";
            this.NombreEstacion.Name = "NombreEstacion";
            // 
            // NavegacionTrafico
            // 
            this.NavegacionTrafico.HeaderText = "NavegacionTrafico";
            this.NavegacionTrafico.Name = "NavegacionTrafico";
            // 
            // FechaHora
            // 
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            // 
            // IdDomicilio
            // 
            this.IdDomicilio.HeaderText = "ID_Domicilio";
            this.IdDomicilio.Name = "IdDomicilio";
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
            this.BtnMercancia.Location = new System.Drawing.Point(118, 346);
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
            this.label7.Location = new System.Drawing.Point(24, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "MERCANCIAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Dimensiones,
            this.PesoEnKg,
            this.ValorMercancia,
            this.idMercancia,
            this.unidadPeso,
            this.pesoBruto,
            this.pesoNeto,
            this.pesoTara,
            this.numPiezas,
            this.IdDetalleMercancia});
            this.dataGridView1.Location = new System.Drawing.Point(12, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(929, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // idMercancia
            // 
            this.idMercancia.HeaderText = "idMercancia";
            this.idMercancia.Name = "idMercancia";
            // 
            // unidadPeso
            // 
            this.unidadPeso.HeaderText = "Unidad de Peso";
            this.unidadPeso.Name = "unidadPeso";
            // 
            // pesoBruto
            // 
            this.pesoBruto.HeaderText = "Peso Bruto";
            this.pesoBruto.Name = "pesoBruto";
            // 
            // pesoNeto
            // 
            this.pesoNeto.HeaderText = "Peso Neto";
            this.pesoNeto.Name = "pesoNeto";
            // 
            // pesoTara
            // 
            this.pesoTara.HeaderText = "Peso Tara";
            this.pesoTara.Name = "pesoTara";
            // 
            // numPiezas
            // 
            this.numPiezas.HeaderText = "No. Piezas";
            this.numPiezas.Name = "numPiezas";
            // 
            // IdDetalleMercancia
            // 
            this.IdDetalleMercancia.HeaderText = "IdDetalleMercancia";
            this.IdDetalleMercancia.Name = "IdDetalleMercancia";
            // 
            // textTotalMercancias
            // 
            this.textTotalMercancias.Enabled = false;
            this.textTotalMercancias.Location = new System.Drawing.Point(344, 348);
            this.textTotalMercancias.Name = "textTotalMercancias";
            this.textTotalMercancias.Size = new System.Drawing.Size(108, 20);
            this.textTotalMercancias.TabIndex = 18;
            // 
            // textTasacion
            // 
            this.textTasacion.Location = new System.Drawing.Point(470, 348);
            this.textTasacion.Name = "textTasacion";
            this.textTasacion.Size = new System.Drawing.Size(106, 20);
            this.textTasacion.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "NumTotalMercancias:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "CargoPorTasacion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 526);
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
            this.BtnConfigurarTransporte.Text = "Configurar transporte";
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
            this.GBTransporte.Location = new System.Drawing.Point(15, 530);
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
            this.groupBox1.Size = new System.Drawing.Size(643, 96);
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
            this.BtnGuardar.Location = new System.Drawing.Point(864, 556);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 33;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(788, 153);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(153, 23);
            this.btnCarga.TabIndex = 35;
            this.btnCarga.Text = "Configuración catálogos";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(599, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Peso Bruto Total:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(725, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Unidad de Peso:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(830, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Peso Total:";
            // 
            // textPesoBruto
            // 
            this.textPesoBruto.Location = new System.Drawing.Point(595, 348);
            this.textPesoBruto.Name = "textPesoBruto";
            this.textPesoBruto.Size = new System.Drawing.Size(106, 20);
            this.textPesoBruto.TabIndex = 39;
            // 
            // textUnidadPeso
            // 
            this.textUnidadPeso.Location = new System.Drawing.Point(718, 348);
            this.textUnidadPeso.Name = "textUnidadPeso";
            this.textUnidadPeso.Size = new System.Drawing.Size(106, 20);
            this.textUnidadPeso.TabIndex = 40;
            // 
            // textPesoTotal
            // 
            this.textPesoTotal.Location = new System.Drawing.Point(833, 348);
            this.textPesoTotal.Name = "textPesoTotal";
            this.textPesoTotal.Size = new System.Drawing.Size(106, 20);
            this.textPesoTotal.TabIndex = 41;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 601);
            this.Controls.Add(this.textPesoTotal);
            this.Controls.Add(this.textUnidadPeso);
            this.Controls.Add(this.textPesoBruto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBTransporte);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textTasacion);
            this.Controls.Add(this.textTotalMercancias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnMercancia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnUbicacionNueva);
            this.Controls.Add(this.DgvUbicaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox textTotalMercancias;
        private System.Windows.Forms.TextBox textTasacion;
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
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimensiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoEnKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorMercancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMercancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoTara;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPiezas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleMercancia;
        private System.Windows.Forms.TextBox textPesoTotal;
        private System.Windows.Forms.TextBox textUnidadPeso;
        private System.Windows.Forms.TextBox textPesoBruto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRegIDTrib;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResidenciaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NavegacionTrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDomicilio;
    }
}

