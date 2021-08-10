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
using static WindowsFormsApp1.Modelos.EstructurasFunciones;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FrmMercancias frmMerca = new FrmMercancias();
            frmMerca.ShowDialog();

            dataGridView1.Rows.Add("","","","","","","","");
        }

        private void dataGUbicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Formularios fr = new Formularios();
            //fr.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> ClavesTransporte = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.ClaveTransporte);

            //foreach (Modelos.Catalogos c in ClavesTransporte)
            //{
            //    CmbViaEntradaSalida.Items.Add(c.Descripcion);
            //}
            CmbViaEntradaSalida.DataSource = new BindingSource(ClavesTransporte, null);
            CmbViaEntradaSalida.DisplayMember = "Value";
            CmbViaEntradaSalida.ValueMember = "Key";


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
                int midato;
                if (ubi.GuardadoCorrectamente)
                {
                    midato = ubi.ObtenerDatos();

                    dataGUbicaciones.Rows.Add("", "", "", "");
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

                BtnConfigurarTransporte.BackColor = Color.LightCyan;
            }
            else
            {
                MessageBox.Show("Seleccione la via de entrada salida", "Carta Porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
