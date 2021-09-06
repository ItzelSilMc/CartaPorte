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
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1.ControlesGrid
{
    public partial class GridPersona : UserControl
    {
        TipoPersona tipoPersona;

        DataTable tablaInfo;

        public GridPersona(TipoPersona tipoPersona)
        {
            this.tipoPersona = tipoPersona;
            Inicializar();
        }

        private void Inicializar()
        {
            InitializeComponent();
            RefrescarGrid();
            
        }
        public void RefrescarGrid()
        {
            DgvPersona.Rows.Clear();
            
            switch(tipoPersona)
            {
                case TipoPersona.Operador:
                    tablaInfo = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_OPERADOR);
                    break;

                case TipoPersona.Notificado:
                    tablaInfo = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_NOTIFICADO);
                    break;

            }
            CargarGrid();

            
        }
        private void CargarGrid()
        {
            foreach (DataRow row in tablaInfo.Rows)
            {
                DataGridViewRow drow = new DataGridViewRow();
                drow.CreateCells(DgvPersona);
                switch (tipoPersona)
                {
                    case TipoPersona.Notificado:
                        drow.Cells[0].Value = row["ID_NOTIFICADO"].ToString();
                        drow.Cells[1].Value = row["RFCArrendatario"].ToString();
                        drow.Cells[2].Value = row["NombreArrendatario"].ToString();
                        drow.Cells[3].Value = "NOTIFICADO";
                        DgvPersona.Rows.Add(drow);
                        break;
            }
            }
        }

        private void DgvPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    int IdModificar = int.Parse(DgvPersona.Rows[e.RowIndex].Cells[0].Value.ToString());
                    switch(tipoPersona)
                    {
                        case TipoPersona.Operador:
                            ObjetoOperador operador = new ObjetoOperador();
                            break;
                    }
                    
                    
                    
                }
                if (e.ColumnIndex == 5)
                {
                    int IdEliminar = int.Parse(DgvPersona.Rows[e.RowIndex].Cells[0].Value.ToString());

                    if(MessageBox.Show("¿Esta seguro que desea eliminar el registro seleccionado?", "Carta porte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        TablasCartaPorte tabla = TipoPersona.Notificado == tipoPersona ? TablasCartaPorte.VMX_FE_CP_NOTIFICADO : TablasCartaPorte.VMX_FE_CP_OPERADOR;

                        if(Metodos.EliminarRegistro(tabla, IdEliminar))
                        {
                            MessageBox.Show("El registro se ha eliminado correctamente", "Carta porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
        }
    }
}
