namespace WindowsFormsApp1
{
    partial class frmCatalagoUbicaciones
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
            this.dataCatalago = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataUbicacion = new System.Windows.Forms.DataGridView();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumExterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumInterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ADDR_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDR_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZIPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNTRY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataCatalago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUbicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCatalago
            // 
            this.dataCatalago.AllowUserToAddRows = false;
            this.dataCatalago.AllowUserToDeleteRows = false;
            this.dataCatalago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCatalago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ADDR_NO,
            this.NAME,
            this.ADDR_1,
            this.ZIPCODE,
            this.COUNTRY});
            this.dataCatalago.Location = new System.Drawing.Point(43, 178);
            this.dataCatalago.Name = "dataCatalago";
            this.dataCatalago.Size = new System.Drawing.Size(646, 260);
            this.dataCatalago.TabIndex = 0;
            this.dataCatalago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCatalago_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubicaciones";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.WindowText;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(729, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataUbicacion
            // 
            this.dataUbicacion.AllowUserToAddRows = false;
            this.dataUbicacion.AllowUserToDeleteRows = false;
            this.dataUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUbicacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calle,
            this.NumExterior,
            this.NumInterior,
            this.colonia,
            this.localidad,
            this.referencia,
            this.municipio,
            this.estado,
            this.pais,
            this.CP});
            this.dataUbicacion.Location = new System.Drawing.Point(43, 58);
            this.dataUbicacion.Name = "dataUbicacion";
            this.dataUbicacion.Size = new System.Drawing.Size(646, 96);
            this.dataUbicacion.TabIndex = 3;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            // 
            // NumExterior
            // 
            this.NumExterior.HeaderText = "No. Exterior";
            this.NumExterior.Name = "NumExterior";
            this.NumExterior.Width = 50;
            // 
            // NumInterior
            // 
            this.NumInterior.HeaderText = "No. Interior";
            this.NumInterior.Name = "NumInterior";
            this.NumInterior.Width = 50;
            // 
            // colonia
            // 
            this.colonia.HeaderText = "Colonia";
            this.colonia.Name = "colonia";
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            // 
            // referencia
            // 
            this.referencia.HeaderText = "Referencia";
            this.referencia.Name = "referencia";
            // 
            // municipio
            // 
            this.municipio.HeaderText = "Municipio";
            this.municipio.Name = "municipio";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // pais
            // 
            this.pais.HeaderText = "Pais";
            this.pais.Name = "pais";
            // 
            // CP
            // 
            this.CP.HeaderText = "C.P.";
            this.CP.Name = "CP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ubicación Seleccionada:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ADDR_NO
            // 
            this.ADDR_NO.HeaderText = "Dirección";
            this.ADDR_NO.Name = "ADDR_NO";
            // 
            // NAME
            // 
            this.NAME.FillWeight = 150F;
            this.NAME.HeaderText = "Nombre";
            this.NAME.Name = "NAME";
            this.NAME.Width = 150;
            // 
            // ADDR_1
            // 
            this.ADDR_1.FillWeight = 150F;
            this.ADDR_1.HeaderText = "Dirección";
            this.ADDR_1.Name = "ADDR_1";
            this.ADDR_1.Width = 150;
            // 
            // ZIPCODE
            // 
            this.ZIPCODE.HeaderText = "C.P.";
            this.ZIPCODE.Name = "ZIPCODE";
            // 
            // COUNTRY
            // 
            this.COUNTRY.HeaderText = "País";
            this.COUNTRY.Name = "COUNTRY";
            // 
            // frmCatalagoUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataUbicacion);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCatalago);
            this.Name = "frmCatalagoUbicaciones";
            this.Text = "Catálogo de ubicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataCatalago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUbicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCatalago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumExterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumInterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZIPCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUNTRY;
    }
}