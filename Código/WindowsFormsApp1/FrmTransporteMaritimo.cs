using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Modelos.EstructurasFunciones;

namespace WindowsFormsApp1
{
    public partial class FrmTransporteMaritimo : Form
    {
        public FrmTransporteMaritimo()
        {
            InitializeComponent();
        }

        private void BtnTransportista_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer = new FrmPersona();
            FrmPer.SetTipo(TipoPersona.Transportista);
            FrmPer.ShowDialog();

            BtnTransportista.BackColor = Color.Cyan;
        }


        private void BtnArrendatario_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer = new FrmPersona();
            FrmPer.SetTipo(TipoPersona.Arrendatario);
            FrmPer.ShowDialog();

            BtnArrendatario.BackColor = Color.Cyan;
        }

        private void BtnPropietario_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer = new FrmPersona();
            FrmPer.SetTipo(TipoPersona.Propietario);
            FrmPer.ShowDialog();

            BtnPropietario.BackColor = Color.Cyan;
        }

        private void BtnEmbarcador_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer = new FrmPersona();
            FrmPer.SetTipo(TipoPersona.Embarcador);
            FrmPer.ShowDialog();

            BtnEmbarcador.BackColor = Color.Cyan;
        }
    }
}
