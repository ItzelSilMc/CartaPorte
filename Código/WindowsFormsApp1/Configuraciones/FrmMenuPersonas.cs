using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1.Configuraciones
{
    public partial class FrmMenuPersonas : Form
    {
        public FrmMenuPersonas()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnTransportista_Click(object sender, EventArgs e)
        {
            AbrirFormaPersona(TipoPersona.Transportista);

        }

        private void BtnEmbarcador_Click(object sender, EventArgs e)
        {
            AbrirFormaPersona(TipoPersona.Embarcador);
        }

        private void BtnOperador_Click(object sender, EventArgs e)
        {
            //AbrirFormaPersona(TipoPersona.Operador);

            Hide();
            FrmAdministracion admin = new FrmAdministracion();
            admin.SetTipoGrid(TablasCartaPorte.VMX_FE_CP_OPERADOR);
            admin.ShowDialog();
            Show();
            

        }

        private void AbrirFormaPersona(TipoPersona tipoPersona)
        {
            Hide();
            FrmPersona frmPer = new FrmPersona();
            frmPer.SetTipo(tipoPersona);
            frmPer.AbiertoDesdeConfiguracion = true;
            frmPer.ShowDialog();
            Show();
        }

        private void BtnNotificado_Click(object sender, EventArgs e)
        {
            //AbrirFormaPersona(TipoPersona.Operador);

            Hide();
            FrmAdministracion admin = new FrmAdministracion();
            admin.SetTipoGrid(TablasCartaPorte.VMX_FE_CP_NOTIFICADO);
            admin.ShowDialog();
            Show();
        }
    }
}
