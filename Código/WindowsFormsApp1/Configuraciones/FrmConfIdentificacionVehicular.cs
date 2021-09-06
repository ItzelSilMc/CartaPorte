using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1.Configuraciones
{
    public partial class FrmConfIdentificacionVehicular : Form
    {
        Dictionary<string, string> ConfiguracionesVehiculares ;

        ObjetoIdentificacionVehicular objetoPrevio;
        ObjetoIdentificacionVehicular identificacion;

        public bool CargadoParaActualizar = false;

        public FrmConfIdentificacionVehicular()
        {
            Inicializar();
        }
        public FrmConfIdentificacionVehicular(ObjetoIdentificacionVehicular identificacion)
        {
            Inicializar();
            this.identificacion = identificacion;

            identificacionVehicularControl1.CargarDatosPrevios(identificacion);
        }
        public void PrepararParaActualizar()
        {
            CargadoParaActualizar = true;
            objetoPrevio = identificacion;
        }

        private void Inicializar()
        {
            InitializeComponent();

            ConfiguracionesVehiculares = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.ConfigAutoFederal);

            CargarCombos();
        }
        private void CargarCombos()
        {
            identificacionVehicularControl1.CargarComboConfigVehicular(ConfiguracionesVehiculares);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
                identificacion = identificacionVehicularControl1.ObtenerIdentificacionVehicular();
                if (!CargadoParaActualizar)
                {
                    Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR, identificacion);
                    MessageBox.Show("Se ha guardado la informacion correctamente", "Carta porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string CadenaWhere = " WHERE ID_VEHICULAR = " +  objetoPrevio.ID ;
                    string CadenaUpdate = ObtenerCadenaSet();

                    Metodos.ActualizarRegistro(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR, CadenaUpdate + CadenaWhere);
                }

                Close();

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private string ObtenerCadenaSet()
        {
            List<string> CamposModificados = new List<string>();

            if(objetoPrevio.ConfiguracionVehicular != identificacion.ConfiguracionVehicular)
            {
                CamposModificados.Add("ConfigVehicular = '" + identificacion.ConfiguracionVehicular + "',");
            }
            if(objetoPrevio.PlacaVehiculo != identificacion.PlacaVehiculo)
            {
                CamposModificados.Add("PlacaVM = '" + identificacion.PlacaVehiculo + "',");

            }
            if(objetoPrevio.AñoModelo != identificacion.AñoModelo)
            {
                CamposModificados.Add("AnioModeloVM =" + identificacion.AñoModelo+ ",");
            }
            if(objetoPrevio.NumPolizaSeguro != identificacion.NumPolizaSeguro)
            {
                CamposModificados.Add("NumPolizaSeguro = '" + identificacion.NumPolizaSeguro + "',");

            }
            string CadenaSet = "SET ";

            foreach(string campos in CamposModificados)
            {
                CadenaSet += campos;
            }
            if(CamposModificados.Count > 0)
            {
                CadenaSet = CadenaSet.Substring(0, CadenaSet.Length - 1);
            }
            return CadenaSet;
        }
    }
}
