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
    public partial class FrmTransporteTerrestre : Form
    {
        public FrmTransporteTerrestre()
        {
            InitializeComponent();
        }

        private void FrmTransporteTerrestre_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> Permisos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoPermiso);
            Dictionary<string, string> ConfiguracionesVehiculares = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.ConfigAutoFederal);
            Dictionary<string, string> Remolques = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoRemolque);

            CargarCombos(Permisos, ConfiguracionesVehiculares, Remolques);

            
        }
        private void CargarCombos(Dictionary<string, string> Permisos, Dictionary<string, string> ConfiguracionesVehiculares, Dictionary<string, string> Remolques)
        {
            autotransporteFederalControl1.CargarComboPermisoSCT(Permisos);
            identificacionVehicularControl1.CargarComboConfigVehicular(ConfiguracionesVehiculares);
            remolqueControl1.CargarComboTipoRemolque(Remolques);
        }

        private void BtnConfigurarOperador_Click(object sender, EventArgs e)
        {
            FrmPersona frmOperador = new FrmPersona();
            frmOperador.SetTipo(TipoPersona.Operador);
            frmOperador.ShowDialog();
        }

        private void BtnTransportista_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer = new FrmPersona();
            FrmPer.SetTipo(TipoPersona.Transportista);
            FrmPer.ShowDialog();
            BtnTransportista.BackColor = Color.Cyan;
        }

        private void BtnEmbarcador_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer = new FrmPersona();
            FrmPer.SetTipo(TipoPersona.Embarcador);
            FrmPer.ShowDialog();

            BtnEmbarcador.BackColor = Color.Cyan;
        }

        private void BtnPropietario_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer = new FrmPersona();
            FrmPer.SetTipo(TipoPersona.Propietario);
            FrmPer.ShowDialog();

            BtnPropietario.BackColor = Color.Cyan;
        }

        private void BtnArrendatario_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer = new FrmPersona();
            FrmPer.SetTipo(TipoPersona.Arrendatario);
            FrmPer.ShowDialog();

            BtnArrendatario.BackColor = Color.Cyan;
        }
    }
}
