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
                ObjetoIdentificacionVehicular identificacion = identificacionVehicularControl1.ObtenerIdentificacionVehicular();
                if (!CargadoParaActualizar)
                {
                    Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR, identificacion);
                    MessageBox.Show("Se ha guardado la informacion correctamente", "Carta porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }

                Close();

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}
