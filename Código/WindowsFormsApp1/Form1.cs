using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUbicaciones ubi = new FrmUbicaciones();
            ubi.ShowDialog();
            int midato;
            if (ubi.GuardadoCorrectamente)
            {
                midato = ubi.ObtenerDatos();

                dataGUbicaciones.Rows.Add("", "", "", "");
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMercancias frmMerca = new FrmMercancias();
            frmMerca.ShowDialog();

            dataGridView1.Rows.Add("","","","","","","","");
        }

        private void dataGUbicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Formularios fr = new Formularios();
            fr.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Formularios fr = new Formularios();
            fr.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Se va a poner dependiente del tipo de transporte

            //FrmTransporteFerroviario tf = new FrmTransporteFerroviario();
            //tf.ShowDialog();


            FrmTransporteTerrestre tt = new FrmTransporteTerrestre();
            tt.ShowDialog();


        }
    }
}
