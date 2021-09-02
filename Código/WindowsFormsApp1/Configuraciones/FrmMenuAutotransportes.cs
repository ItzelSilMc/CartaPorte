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
using static WindowsFormsApp1.Modelos.EstructurasEnums;

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
            AbrirFormaAdministracion(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL);    
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
            AbrirFormaAdministracion(TablasCartaPorte.VMX_FE_CP_REMOLQUES);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AbrirFormaAdministracion(TablasCartaPorte tabla)
        {
            Hide();
            FrmAdministracion admin = new FrmAdministracion();
            admin.SetTipoGrid(tabla);
            admin.ShowDialog();
            Show();
        }
    }
}
