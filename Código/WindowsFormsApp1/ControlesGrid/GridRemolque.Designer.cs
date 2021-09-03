
namespace WindowsFormsApp1.ControlesGrid
{
    partial class GridRemolque
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
            this.DgvRemolque = new System.Windows.Forms.DataGridView();
            this.ID_REMOLQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTipoRem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRemolque)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRemolque
            // 
            this.DgvRemolque.AllowUserToAddRows = false;
            this.DgvRemolque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRemolque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_REMOLQUE,
            this.SubTipoRem,
            this.Placa,
            this.Editar,
            this.Eliminar});
            this.DgvRemolque.Location = new System.Drawing.Point(3, 3);
            this.DgvRemolque.Name = "DgvRemolque";
            this.DgvRemolque.RowHeadersVisible = false;
            this.DgvRemolque.Size = new System.Drawing.Size(305, 150);
            this.DgvRemolque.TabIndex = 0;
            this.DgvRemolque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRemolque_CellContentClick);
            this.DgvRemolque.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvRemolque_CellPainting);
            // 
            // ID_REMOLQUE
            // 
            this.ID_REMOLQUE.HeaderText = "ID_REMOLQUE";
            this.ID_REMOLQUE.Name = "ID_REMOLQUE";
            this.ID_REMOLQUE.ReadOnly = true;
            this.ID_REMOLQUE.Visible = false;
            // 
            // SubTipoRem
            // 
            this.SubTipoRem.HeaderText = "Tipo remolque";
            this.SubTipoRem.Name = "SubTipoRem";
            this.SubTipoRem.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Plaza";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
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
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Width = 50;
            // 
            // GridRemolque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.DgvRemolque);
            this.Name = "GridRemolque";
            this.Size = new System.Drawing.Size(313, 157);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRemolque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRemolque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_REMOLQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTipoRem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
