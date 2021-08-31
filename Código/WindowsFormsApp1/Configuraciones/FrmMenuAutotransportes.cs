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

namespace WindowsFormsApp1
{
    public partial class FrmMenuAutotransportes : Form
    {
        public FrmMenuAutotransportes()
        {
            InitializeComponent();
        }

        private void BtnTransporte_Click(object sender, EventArgs e)
        {
            FrmConfAutotransporte auto = new FrmConfAutotransporte();
            Hide();
            auto.ShowDialog();
            Show();
        }

        private void BtnIdentificacionVehicular_Click(object sender, EventArgs e)
        {
            Hide();
            FrmConfIdentificacionVehicular identi = new FrmConfIdentificacionVehicular();
            identi.ShowDialog();
            Show();

        }

        private void BtnRemolque_Click(object sender, EventArgs e)
        {
            Hide();
            FrmConfRemolque frmRemolque = new FrmConfRemolque();
            frmRemolque.ShowDialog();
            Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
