using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1
{
    public partial class FrmTransporteTerrestre : Form
    {


        public  bool GuardadoCorrectamente = false;

        ObjetoAutoTransporteFederal autoTransporteFederal = new ObjetoAutoTransporteFederal();

        public FrmTransporteTerrestre()
        {
            InitializeComponent();

            Dictionary<string, string> Permisos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoPermiso);
            Dictionary<string, string> ConfiguracionesVehiculares = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.ConfigAutoFederal);
            Dictionary<string, string> Remolques = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoRemolque);

            CargarCombos(Permisos, ConfiguracionesVehiculares, Remolques);
        }


        private void FrmTransporteTerrestre_Load(object sender, EventArgs e)
        {
            

            
        }
        private void CargarCombos(Dictionary<string, string> Permisos, Dictionary<string, string> ConfiguracionesVehiculares, Dictionary<string, string> Remolques)
        {
            autotransporteFederalControl1.CargarComboPermisoSCT(Permisos);
            identificacionVehicularControl1.CargarComboConfigVehicular(ConfiguracionesVehiculares);
            remolqueControl1.CargarComboTipoRemolque(Remolques);
        }

        public void CargarDatosPrevios(ObjetoAutoTransporteFederal transporteFederal)
        {
            autotransporteFederalControl1.CargarDatosPrevios(transporteFederal.transporte);
            identificacionVehicularControl1.CargarDatosPrevios(transporteFederal.identidicacion);
            remolqueControl1.CargarDatosPrevios(transporteFederal.remolque);

            botonesPersonasControl1.CargarDatosPrevios(transporteFederal.listaPersonas);

        }

        private void BtnConfigurarOperador_Click(object sender, EventArgs e)
        {
            FrmPersona frmOperador = new FrmPersona();
            frmOperador.SetTipo(TipoPersona.Operador);
            frmOperador.ShowDialog();
        }
        private bool ValidarTransporteTerrestre()
        {
            return true;
        }
      

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarTransporteTerrestre())
            {
                autoTransporteFederal.identidicacion = identificacionVehicularControl1.ObtenerIdentificacionVehicular();
                autoTransporteFederal.remolque = remolqueControl1.ObtenerRemolque();
                autoTransporteFederal.transporte = autotransporteFederalControl1.ObtenerAutotransporte();
                autoTransporteFederal.listaPersonas = botonesPersonasControl1.ObtenerPersonas();
                GuardadoCorrectamente = true;

                this.Close();
            }
        }

        public ObjetoAutoTransporteFederal ObtenerInfoTransporteTerreste()
        {
            return autoTransporteFederal;
        }

        private void botonesPersonasControl1_Load(object sender, EventArgs e)
        {

        }



    }
}
