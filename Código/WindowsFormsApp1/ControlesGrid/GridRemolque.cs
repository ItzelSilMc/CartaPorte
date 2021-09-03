using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1.ControlesGrid
{
    public partial class GridRemolque : UserControl
    {
        DataTable tablaInfo;

        public GridRemolque()
        {
            InitializeComponent();
            tablaInfo = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_REMOLQUES);
            CargarGrid();
        }

    private void CargarGrid()
    {
        foreach (DataRow row in tablaInfo.Rows)
        {
            DataGridViewRow drow = new DataGridViewRow();
            drow.CreateCells(DgvRemolque);
            drow.Cells[0].Value = row["ID_REMOLQUE"].ToString();
            drow.Cells[1].Value = row["SubTipoRem"].ToString();
            drow.Cells[2].Value = row["Placa"].ToString();

            DgvRemolque.Rows.Add(drow);

        }
    }

    private void DgvRemolque_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.editar16.Width;
                var h = Properties.Resources.editar16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.editar16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
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

        private void DgvRemolque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3)   //Columna editar
                {
                    int IdModificar = int.Parse(DgvRemolque.Rows[e.RowIndex].Cells[0].Value.ToString());

                }
                else
                {
                    if (e.ColumnIndex == 4)  // columna eliminar
                    {
                        if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Carta porte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {

                        }
                    }
                }
            }
        }
    }
}
