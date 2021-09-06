using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Configuraciones;
using WindowsFormsApp1.Modelos;
using WindowsFormsApp1.Properties;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1.ControlesGrid
{
    public partial class GridIdentificacionVehicular : UserControl
    {
        DataTable tablaInfo;
        public GridIdentificacionVehicular()
        {
            InitializeComponent();
            RefrescarGrid();
        }

        public void RefrescarGrid()
        {
            DgvIdentificacion.Rows.Clear();
            tablaInfo = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR);
            CargarGrid();
        }

        private void CargarGrid()
        {
            foreach (DataRow row in tablaInfo.Rows)
            {
                DataGridViewRow drow = new DataGridViewRow();
                drow.CreateCells(DgvIdentificacion);
                drow.Cells[0].Value = row["ID_VEHICULAR"].ToString();
                drow.Cells[1].Value = row["ConfigVehicular"].ToString();
                drow.Cells[2].Value = row["PlacaVM"].ToString();
                drow.Cells[3].Value = row["AnioModeloVM"].ToString();
                drow.Cells[4].Value = row["NumpolizaSeguro"].ToString();

                DgvIdentificacion.Rows.Add(drow);

            }
        }
       

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.editar16.Width;
                var h = Properties.Resources.editar16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.editar16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if(e.ColumnIndex == 6 && e.RowIndex >= 0)
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

        private void DgvIdentificacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 )
            {
                if(e.ColumnIndex == 5 )   //Columna editar
                {
                    int IdModificar = int.Parse(DgvIdentificacion.Rows[e.RowIndex].Cells[0].Value.ToString());
                    DataTable tabla = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR, IdModificar);
                    ObjetoIdentificacionVehicular identificacion = new ObjetoIdentificacionVehicular();
                    foreach (DataRow row in tabla.Rows)
                    {
                        
                        identificacion.ConfiguracionVehicular = row["ConfigVehicular"].ToString();
                        identificacion.PlacaVehiculo = row["PlacaVM"].ToString();
                        identificacion.AñoModelo = int.Parse(row["AnioModeloVM"].ToString());
                        identificacion.NumPolizaSeguro = row["NumPolizaSeguro"].ToString();
                        identificacion.ID =  int.Parse(row[0].ToString());
                    }

                    FrmConfIdentificacionVehicular FrmIdentificacion = new FrmConfIdentificacionVehicular(identificacion);
                    FrmIdentificacion.PrepararParaActualizar();
                    FrmIdentificacion.ShowDialog();

                }
                else
                {
                    if(e.ColumnIndex == 6)  // columna eliminar
                    {
                        if(MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Carta porte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
                        {
                            int IdEliminar = int.Parse(DgvIdentificacion.Rows[e.RowIndex].Cells[0].Value.ToString());

                            if (Metodos.EliminarRegistro(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR, IdEliminar))
                                MessageBox.Show("Se ha eliminado el registro correctamente.", "Carta porte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
        }
    }
}
