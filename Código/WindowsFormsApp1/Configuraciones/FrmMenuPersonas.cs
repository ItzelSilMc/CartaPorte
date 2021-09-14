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
            AbrirFormaAdministracionPersona(TipoPersona.Transportista);

        }

        private void BtnEmbarcador_Click(object sender, EventArgs e)
        {
            AbrirFormaAdministracionPersona(TipoPersona.Embarcador);
        }

        private void BtnOperador_Click(object sender, EventArgs e)
        {
            AbrirFormaAdministracionPersona(TipoPersona.Operador);
            
        }

        private void BtnNotificado_Click(object sender, EventArgs e)
        {
            AbrirFormaAdministracionPersona(TipoPersona.Notificado);
        }

        private void AbrirFormaAdministracionPersona(TipoPersona tipoPersona)
        {
            Hide();
            FrmAdministracion frmPer = new FrmAdministracion();
            TablasCartaPorte tabla = TablasCartaPorte.VMX_FE_CP_TRANSPORTISTA;

            switch(tipoPersona)
            {
                case TipoPersona.Transportista:
                    tabla = TablasCartaPorte.VMX_FE_CP_TRANSPORTISTA;
                    break;

                case TipoPersona.Propietario:
                    tabla = TablasCartaPorte.VMX_FE_CP_PROPIETARIO;
                    break;

                case TipoPersona.Operador:
                    tabla = TablasCartaPorte.VMX_FE_CP_OPERADOR;
                    break;

                case TipoPersona.Notificado:
                    tabla = TablasCartaPorte.VMX_FE_CP_NOTIFICADO;
                    break;

                case TipoPersona.Embarcador:
                    tabla = TablasCartaPorte.VMX_FE_CP_EMBARCADOR;
                    break;

                case TipoPersona.Arrendatario:
                    tabla = TablasCartaPorte.VMX_FE_CP_ARRENDATARIO;
                    break;

            }
            frmPer.SetTipoGrid(tabla);
            frmPer.ShowDialog();
            Show();
        }

        
    }
}
