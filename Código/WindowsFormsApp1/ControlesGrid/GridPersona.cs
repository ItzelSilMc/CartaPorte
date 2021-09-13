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
                        drow.Cells[1].Value = row["RFCNotificado"].ToString();
                        drow.Cells[2].Value = row["NombreNotificado"].ToString();
                        drow.Cells[3].Value = "Notificado";
                        break;

                    case TipoPersona.Operador:
                        drow.Cells[0].Value = row["ID_OPERADOR"].ToString();
                        drow.Cells[1].Value = row["RFCOperador"].ToString();
                        drow.Cells[2].Value = row["NombreOperador"].ToString();
                        drow.Cells[3].Value = "Operador";
                       
                        break;
                }
                DgvPersona.Rows.Add(drow);
            }
        }

        private void DgvPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)   // Esta columna es para actulizar
                {
                    int IdModificar = int.Parse(DgvPersona.Rows[e.RowIndex].Cells[0].Value.ToString());
                    switch(tipoPersona)
                    {
                        case TipoPersona.Operador:

                            DataTable tablaInfo = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_OPERADOR, IdModificar);
                            int IdDomicilio = int.Parse(tablaInfo.Rows[0]["ID_DOMICILIO"].ToString());
                            ObjetoPersona operador = Metodos.obtenerOperadorDesdeTabla(tablaInfo);
                            DataTable tablaDomicilio = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_DOMICILIO, IdDomicilio);
                            ObjetoDireccion domicilio = Metodos.ObtenerDireccionDesdeTabla(tablaDomicilio);
                            operador.objDireccion = domicilio;
                            FrmPersona frmPersona = new FrmPersona(operador);
                            frmPersona.SetTipo(tipoPersona);
                            Hide();
                            frmPersona.ShowDialog();
                            Show();
                            RefrescarGrid();
                            break;

                        case TipoPersona.Notificado:
                            DataTable tablaInfoNotificado = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_NOTIFICADO, IdModificar);
                            int IdDomicilioNotificado = int.Parse(tablaInfoNotificado.Rows[0]["ID_DOMICILIO"].ToString());
                            ObjetoPersona notificado = Metodos.ObtenerNotificadoDesdeTabla(tablaInfoNotificado);
                            DataTable tablaDomicilioNotificado = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_DOMICILIO, IdDomicilioNotificado);
                            ObjetoDireccion direccionNotificado = Metodos.ObtenerDireccionDesdeTabla(tablaDomicilioNotificado);
                            notificado.objDireccion = direccionNotificado;

                            FrmPersona frmNotificado = new FrmPersona(notificado);
                            frmNotificado.SetTipo(tipoPersona);
                            Hide();
                            frmNotificado.ShowDialog();
                            Show();
                            RefrescarGrid();
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


        

        private void DgvPersona_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
