
namespace WindowsFormsApp1
{
    partial class MercanciaControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbBienes = new System.Windows.Forms.ComboBox();
            this.CmbClaveSTCC = new System.Windows.Forms.ComboBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.CmbClaveUnidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Embalaje = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CmbUnidad = new System.Windows.Forms.ComboBox();
            this.CmbMaterialPeligroso = new System.Windows.Forms.ComboBox();
            this.CmbClaveMaterialPeligroso = new System.Windows.Forms.ComboBox();
            this.CmbEmbalaje = new System.Windows.Forms.ComboBox();
            this.CmbFraccionArancelaria = new System.Windows.Forms.ComboBox();
            this.CmbMoneda = new System.Windows.Forms.ComboBox();
            this.TxtDescripcionEmbalaje = new System.Windows.Forms.TextBox();
            this.TxtPesoEnKG = new System.Windows.Forms.TextBox();
            this.TxtValorMercancia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 31);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mercancia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienes transportados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave STCC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clave unidad:";
            // 
            // CmbBienes
            // 
            this.CmbBienes.FormattingEnabled = true;
            this.CmbBienes.Location = new System.Drawing.Point(6, 76);
            this.CmbBienes.Name = "CmbBienes";
            this.CmbBienes.Size = new System.Drawing.Size(163, 21);
            this.CmbBienes.TabIndex = 6;
            // 
            // CmbClaveSTCC
            // 
            this.CmbClaveSTCC.FormattingEnabled = true;
            this.CmbClaveSTCC.Location = new System.Drawing.Point(177, 77);
            this.CmbClaveSTCC.Name = "CmbClaveSTCC";
            this.CmbClaveSTCC.Size = new System.Drawing.Size(136, 21);
            this.CmbClaveSTCC.TabIndex = 7;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(319, 76);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(215, 20);
            this.TxtDescripcion.TabIndex = 8;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(552, 77);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(46, 20);
            this.TxtCantidad.TabIndex = 9;
            // 
            // CmbClaveUnidad
            // 
            this.CmbClaveUnidad.FormattingEnabled = true;
            this.CmbClaveUnidad.Location = new System.Drawing.Point(624, 77);
            this.CmbClaveUnidad.Name = "CmbClaveUnidad";
            this.CmbClaveUnidad.Size = new System.Drawing.Size(88, 21);
            this.CmbClaveUnidad.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Unidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Material peligroso";
            // 
            // Embalaje
            // 
            this.Embalaje.AutoSize = true;
            this.Embalaje.Location = new System.Drawing.Point(13, 186);
            this.Embalaje.Name = "Embalaje";
            this.Embalaje.Size = new System.Drawing.Size(50, 13);
            this.Embalaje.TabIndex = 13;
            this.Embalaje.Text = "Embalaje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Clave material peligroso:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Descripcion embalaje";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Peso en KG*:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(387, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Fracción arancelaria:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Valor de la mercancía:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(190, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Moneda:";
            // 
            // CmbUnidad
            // 
            this.CmbUnidad.FormattingEnabled = true;
            this.CmbUnidad.Location = new System.Drawing.Point(16, 147);
            this.CmbUnidad.Name = "CmbUnidad";
            this.CmbUnidad.Size = new System.Drawing.Size(118, 21);
            this.CmbUnidad.TabIndex = 20;
            // 
            // CmbMaterialPeligroso
            // 
            this.CmbMaterialPeligroso.FormattingEnabled = true;
            this.CmbMaterialPeligroso.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.CmbMaterialPeligroso.Location = new System.Drawing.Point(154, 146);
            this.CmbMaterialPeligroso.Name = "CmbMaterialPeligroso";
            this.CmbMaterialPeligroso.Size = new System.Drawing.Size(100, 21);
            this.CmbMaterialPeligroso.TabIndex = 21;
            // 
            // CmbClaveMaterialPeligroso
            // 
            this.CmbClaveMaterialPeligroso.FormattingEnabled = true;
            this.CmbClaveMaterialPeligroso.Location = new System.Drawing.Point(284, 146);
            this.CmbClaveMaterialPeligroso.Name = "CmbClaveMaterialPeligroso";
            this.CmbClaveMaterialPeligroso.Size = new System.Drawing.Size(291, 21);
            this.CmbClaveMaterialPeligroso.TabIndex = 22;
            // 
            // CmbEmbalaje
            // 
            this.CmbEmbalaje.FormattingEnabled = true;
            this.CmbEmbalaje.Location = new System.Drawing.Point(16, 202);
            this.CmbEmbalaje.Name = "CmbEmbalaje";
            this.CmbEmbalaje.Size = new System.Drawing.Size(118, 21);
            this.CmbEmbalaje.TabIndex = 23;
            // 
            // CmbFraccionArancelaria
            // 
            this.CmbFraccionArancelaria.FormattingEnabled = true;
            this.CmbFraccionArancelaria.Location = new System.Drawing.Point(390, 201);
            this.CmbFraccionArancelaria.Name = "CmbFraccionArancelaria";
            this.CmbFraccionArancelaria.Size = new System.Drawing.Size(96, 21);
            this.CmbFraccionArancelaria.TabIndex = 24;
            // 
            // CmbMoneda
            // 
            this.CmbMoneda.FormattingEnabled = true;
            this.CmbMoneda.Location = new System.Drawing.Point(193, 254);
            this.CmbMoneda.Name = "CmbMoneda";
            this.CmbMoneda.Size = new System.Drawing.Size(119, 21);
            this.CmbMoneda.TabIndex = 25;
            // 
            // TxtDescripcionEmbalaje
            // 
            this.TxtDescripcionEmbalaje.Location = new System.Drawing.Point(154, 202);
            this.TxtDescripcionEmbalaje.Name = "TxtDescripcionEmbalaje";
            this.TxtDescripcionEmbalaje.Size = new System.Drawing.Size(100, 20);
            this.TxtDescripcionEmbalaje.TabIndex = 26;
            // 
            // TxtPesoEnKG
            // 
            this.TxtPesoEnKG.Location = new System.Drawing.Point(284, 201);
            this.TxtPesoEnKG.Name = "TxtPesoEnKG";
            this.TxtPesoEnKG.Size = new System.Drawing.Size(78, 20);
            this.TxtPesoEnKG.TabIndex = 27;
            // 
            // TxtValorMercancia
            // 
            this.TxtValorMercancia.Location = new System.Drawing.Point(16, 254);
            this.TxtValorMercancia.Name = "TxtValorMercancia";
            this.TxtValorMercancia.Size = new System.Drawing.Size(153, 20);
            this.TxtValorMercancia.TabIndex = 28;
            // 
            // MercanciaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtValorMercancia);
            this.Controls.Add(this.TxtPesoEnKG);
            this.Controls.Add(this.TxtDescripcionEmbalaje);
            this.Controls.Add(this.CmbMoneda);
            this.Controls.Add(this.CmbFraccionArancelaria);
            this.Controls.Add(this.CmbEmbalaje);
            this.Controls.Add(this.CmbClaveMaterialPeligroso);
            this.Controls.Add(this.CmbMaterialPeligroso);
            this.Controls.Add(this.CmbUnidad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Embalaje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbClaveUnidad);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.CmbClaveSTCC);
            this.Controls.Add(this.CmbBienes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "MercanciaControl";
            this.Size = new System.Drawing.Size(732, 291);
            this.Load += new System.EventHandler(this.MercanciaControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbBienes;
        private System.Windows.Forms.ComboBox CmbClaveSTCC;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.ComboBox CmbClaveUnidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Embalaje;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CmbUnidad;
        private System.Windows.Forms.ComboBox CmbMaterialPeligroso;
        private System.Windows.Forms.ComboBox CmbClaveMaterialPeligroso;
        private System.Windows.Forms.ComboBox CmbEmbalaje;
        private System.Windows.Forms.ComboBox CmbFraccionArancelaria;
        private System.Windows.Forms.ComboBox CmbMoneda;
        private System.Windows.Forms.TextBox TxtDescripcionEmbalaje;
        private System.Windows.Forms.TextBox TxtPesoEnKG;
        private System.Windows.Forms.TextBox TxtValorMercancia;
    }
}
