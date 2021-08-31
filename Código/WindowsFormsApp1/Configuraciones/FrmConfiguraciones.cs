using System;
using System.Windows.Forms;
using WindowsFormsApp1.Configuraciones;

namespace WindowsFormsApp1
{
    public partial class FrmConfiguraciones : Form
    {
        public FrmConfiguraciones()
        {
            InitializeComponent();
        }

        private void BtnAutotransporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuAutotransportes menu = new FrmMenuAutotransportes();
            menu.ShowDialog();
            this.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPersonas_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMenuPersonas personas = new FrmMenuPersonas();
            personas.ShowDialog();
            Show();

        }
    }
}
