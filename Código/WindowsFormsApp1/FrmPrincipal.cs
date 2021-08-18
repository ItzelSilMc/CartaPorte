using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using WindowsFormsApp1.Properties;
using static WindowsFormsApp1.Modelos.EstructurasFunciones;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        List<Ubicaciones> ListaUbicaciones = new List<Ubicaciones>();



        private void dataGUbicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Formularios fr = new Formularios();
            //fr.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
            
        }

        private void CargarCombos()
        {
            Dictionary<string, string> EntradaSalida = new Dictionary<string, string>();
            EntradaSalida.Add("Entrada", "Entrada");
            EntradaSalida.Add("Salida", "Salida");

            EstructurasFunciones.CargarComboValores(CmbEntradaSalidaMercancia, EntradaSalida);

            Dictionary<string, string> TransporteInternacional = new Dictionary<string, string>();
            TransporteInternacional.Add("NO", "NO");
            TransporteInternacional.Add("SI", "SI");
            


            EstructurasFunciones.CargarComboValores(CmbInternacional, TransporteInternacional);


            Dictionary<string, string> ClavesTransporte = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.ClaveTransporte);

            //foreach (Modelos.Catalogos c in ClavesTransporte)
            //{
            //    CmbViaEntradaSalida.Items.Add(c.Descripcion);
            //}

            EstructurasFunciones.CargarComboValores(CmbViaEntradaSalida, ClavesTransporte);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCombos();
            BuscarUbicaciones();
        }

        private void BuscarUbicaciones()
        {
            ObjetoDireccion dirDestino = Metodos.ObtenerDireccionDestino("");


            int id = ListaUbicaciones.Count + 1;
            ListaUbicaciones.Add(new Ubicaciones()
            {
                idUbicacion = id,
                NombreEstacion = "",
                NumeroEstacion ="",
                TipoEstacion = "03",
                dir = dirDestino
            });


            if(!string.IsNullOrEmpty( dirDestino.calle))
            {
               DgvUbicaciones.Rows.Add("03", "", "", id);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnUbicacionNueva_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CmbViaEntradaSalida.Text))
            {
                //FrmUbicaciones ubi = new FrmUbicaciones();
                FrmUbicaciones ubi = new FrmUbicaciones(CmbViaEntradaSalida.Text.Split('-')[0].Trim());
                ubi.ShowDialog();
               
                if (ubi.GuardadoCorrectamente)
                {
                    Ubicaciones ubicacionNueva = ubi.retornarUbicacion();


                    //añadir al grid.
                   // DgvUbicaciones.Rows.Add("", "", "", "");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una vía de entrada salida primero", "Carta Porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnConfigurarTransporte_Click(object sender, EventArgs e)
        {
            // Se va a poner dependiente del tipo de transporte

            //FrmTransporteFerroviario tf = new FrmTransporteFerroviario();
            //tf.ShowDialog();

            if (CmbViaEntradaSalida.Text.Length > 0)
            {

                //01  Autotransporte Federal
                //02  Transporte Marítimo
                //03  Transporte Aéreo
                //04  Transporte Ferroviario
                switch (CmbViaEntradaSalida.Text.Split('-')[0].Trim())
                {
                    case "01":
                        FrmTransporteTerrestre tt = new FrmTransporteTerrestre();
                        tt.ShowDialog();
                        break;

                    case "02":
                        FrmTransporteMaritimo tm = new FrmTransporteMaritimo();
                        tm.ShowDialog();
                        break;

                    case "03":
                        FrmTransporteAereo ta = new FrmTransporteAereo();
                        ta.ShowDialog();
                        break;

                    case "04":
                        FrmTransporteFerroviario tf = new FrmTransporteFerroviario();
                        tf.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("No hay configuración para ese tipo de transporte", "Carta Porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                BtnConfigurarTransporte.BackColor = Color.Cyan;
            }
            else
            {
                MessageBox.Show("Seleccione la via de entrada salida", "Carta Porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TxtTotalDistRecorrida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permite un punto decimal.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DgvUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                int id = (int)DgvUbicaciones[3, e.RowIndex].Value;
                Ubicaciones ubicacionSeleccionada = ListaUbicaciones.Where(ubicacion => ubicacion.idUbicacion == id).FirstOrDefault();

                FrmUbicaciones frm = new FrmUbicaciones(CmbViaEntradaSalida.Text.Split('-')[0].Trim(), ubicacionSeleccionada, "Modificar");
                frm.ShowDialog();



           }
        }

        private void DgvUbicaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.ColumnIndex == 4 && e.RowIndex>=0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.editar16.Width;
                var h = Properties.Resources.editar16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.editar16,new Rectangle(x,y,w,h));
                e.Handled = true;
            }
        }

        private void BtnMercancia_Click(object sender, EventArgs e)
        {
            FrmMercancias frmMerca = new FrmMercancias();

            
            frmMerca.ShowDialog();

            //if(frmMerca.)

            
            //dataGridView1.Rows.Add("", "", "", "", "", "", "", "");
        }
    }
}
