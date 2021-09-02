using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ControlesGrid
{
    public partial class GridAutotransporte : UserControl
    {
        DataTable tablaInfo = new DataTable();

        public GridAutotransporte()
        {
            InitializeComponent();
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

                    FrmTransporteTerrestre frmTerrestre = new FrmTransporteTerrestre();
                }
            }
        }
    }
}
