using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using WindowsFormsApp1.Properties;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1.ControlesGrid
{
    public partial class GridAutotransporte : UserControl
    {
        DataTable tablaInfo = new DataTable();

        public GridAutotransporte()
        {
            InitializeComponent();
            RefrescarGrid();
            
        }

        private void RefrescarGrid()
        {
            DgvInformacion.Rows.Clear();
            tablaInfo = Metodos.ObtenerValoresConsulta(Modelos.EstructurasEnums.TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL);
            CargarGrid();
        }


        private void CargarGrid()
        {
            foreach(DataRow row in tablaInfo.Rows)
            {
                DataGridViewRow drow = new DataGridViewRow();
                drow.CreateCells(DgvInformacion);
                drow.Cells[0].Value = row["ID_FEDERAL"].ToString();
                drow.Cells[1].Value = row["PermSCT"].ToString();
                drow.Cells[2].Value = row["NumPermisoSCT"].ToString();
                drow.Cells[3].Value = row["NombreAseg"].ToString();

                DgvInformacion.Rows.Add(drow);

            }
        }

        private void DgvInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == 4) //Columna modificar
                {
                    int IdModificar = int.Parse(DgvInformacion.Rows[e.RowIndex].Cells[0].Value.ToString());

                    DataTable tabla = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL, IdModificar);
                    ObjetoAutotransporte objTerrestre = new ObjetoAutotransporte();
                    foreach (DataRow row in tabla.Rows)
                    {
                        objTerrestre.NombreAseguradora = row["NombreAseg"].ToString();
                        objTerrestre.PermisoSCT = row["PermSCT"].ToString();
                        objTerrestre.NumPermisoSCT = row["NumPermisoSCT"].ToString();
                    }

                    FrmConfAutotransporte frmTerrestre = new FrmConfAutotransporte(objTerrestre);
                    
                    frmTerrestre.ShowDialog();


                }
                else
                {
                    if(e.ColumnIndex == 5)
                    {
                        if(MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Carta porte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int IdEliminar = int.Parse( DgvInformacion.Rows[e.RowIndex].Cells[0].Value.ToString());
                            Metodos.EliminarRegistro(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL, IdEliminar);
                            RefrescarGrid();
                        }
                    }
                }
            }
        }

        private void DgvInformacion_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.editar16.Width;
                var h = Properties.Resources.editar16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.editar16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    var w = Properties.Resources.editar16.Width;
                    var h = Properties.Resources.editar16.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(Resources.delete, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
            
        }
    }
}
