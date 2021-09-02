
namespace WindowsFormsApp1.ControlesGrid
{
    partial class GridAutotransporte
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
            this.DgvInformacion = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermSCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPermisoSCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvInformacion
            // 
            this.DgvInformacion.AllowUserToAddRows = false;
            this.DgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInformacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PermSCT,
            this.NumPermisoSCT,
            this.NombreAseg,
            this.Editar,
            this.Eliminar});
            this.DgvInformacion.Location = new System.Drawing.Point(4, 3);
            this.DgvInformacion.Name = "DgvInformacion";
            this.DgvInformacion.RowHeadersVisible = false;
            this.DgvInformacion.Size = new System.Drawing.Size(490, 150);
            this.DgvInformacion.TabIndex = 0;
            this.DgvInformacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInformacion_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // PermSCT
            // 
            this.PermSCT.HeaderText = "Permiso SCT";
            this.PermSCT.Name = "PermSCT";
            this.PermSCT.ReadOnly = true;
            // 
            // NumPermisoSCT
            // 
            this.NumPermisoSCT.HeaderText = "Numero permiso SCT";
            this.NumPermisoSCT.Name = "NumPermisoSCT";
            this.NumPermisoSCT.ReadOnly = true;
            // 
            // NombreAseg
            // 
            this.NombreAseg.HeaderText = "Nombre aseguradora";
            this.NombreAseg.Name = "NombreAseg";
            this.NombreAseg.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 50;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 50;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Width = 50;
            // 
            // GridAutotransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.DgvInformacion);
            this.Name = "GridAutotransporte";
            this.Size = new System.Drawing.Size(497, 157);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvInformacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermSCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPermisoSCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAseg;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
