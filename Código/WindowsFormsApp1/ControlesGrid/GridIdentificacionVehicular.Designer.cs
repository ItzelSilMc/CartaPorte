
namespace WindowsFormsApp1.ControlesGrid
{
    partial class GridIdentificacionVehicular
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
            this.DgvIdentificacion = new System.Windows.Forms.DataGridView();
            this.ID_VEHICULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfigVehicular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaVM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPolizaSeguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIdentificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvIdentificacion
            // 
            this.DgvIdentificacion.AllowUserToAddRows = false;
            this.DgvIdentificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIdentificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_VEHICULAR,
            this.ConfigVehicular,
            this.PlacaVM,
            this.Anio,
            this.NumPolizaSeguro,
            this.Editar,
            this.Eliminar});
            this.DgvIdentificacion.Location = new System.Drawing.Point(4, 4);
            this.DgvIdentificacion.Name = "DgvIdentificacion";
            this.DgvIdentificacion.RowHeadersVisible = false;
            this.DgvIdentificacion.Size = new System.Drawing.Size(506, 227);
            this.DgvIdentificacion.TabIndex = 0;
            this.DgvIdentificacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIdentificacion_CellContentClick);
            this.DgvIdentificacion.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // ID_VEHICULAR
            // 
            this.ID_VEHICULAR.HeaderText = "ID_VEHICULAR";
            this.ID_VEHICULAR.Name = "ID_VEHICULAR";
            this.ID_VEHICULAR.Visible = false;
            // 
            // ConfigVehicular
            // 
            this.ConfigVehicular.HeaderText = "Configuracion Vehicular";
            this.ConfigVehicular.Name = "ConfigVehicular";
            this.ConfigVehicular.ReadOnly = true;
            // 
            // PlacaVM
            // 
            this.PlacaVM.HeaderText = "Placa";
            this.PlacaVM.Name = "PlacaVM";
            this.PlacaVM.ReadOnly = true;
            // 
            // Anio
            // 
            this.Anio.HeaderText = "Año";
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            // 
            // NumPolizaSeguro
            // 
            this.NumPolizaSeguro.HeaderText = "Numero poliza seguro";
            this.NumPolizaSeguro.Name = "NumPolizaSeguro";
            this.NumPolizaSeguro.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 50;
            // 
            // GridIdentificacionVehicular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.DgvIdentificacion);
            this.Name = "GridIdentificacionVehicular";
            this.Size = new System.Drawing.Size(513, 234);
            ((System.ComponentModel.ISupportInitialize)(this.DgvIdentificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VEHICULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfigVehicular;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaVM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPolizaSeguro;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
