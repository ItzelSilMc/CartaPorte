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
            this.ADDR_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDR_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZIPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNTRY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataCatalago)).BeginInit();
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
            this.dataCatalago.Location = new System.Drawing.Point(43, 79);
            this.dataCatalago.Name = "dataCatalago";
            this.dataCatalago.Size = new System.Drawing.Size(646, 333);
            this.dataCatalago.TabIndex = 0;
            this.dataCatalago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCatalago_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubicaciones";
            // 
            // ADDR_NO
            // 
            this.ADDR_NO.HeaderText = "Direccion";
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.WindowText;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(729, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmCatalagoUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCatalago);
            this.Name = "frmCatalagoUbicaciones";
            this.Text = "frmCatalagoUbicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataCatalago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCatalago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZIPCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUNTRY;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}