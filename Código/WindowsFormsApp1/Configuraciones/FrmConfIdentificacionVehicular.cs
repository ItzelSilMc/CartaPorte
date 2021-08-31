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

        public FrmConfIdentificacionVehicular()
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
                ObjetoIdentificacionVehicular identificacion =  identificacionVehicularControl1.ObtenerIdentificacionVehicular();

                Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR, identificacion);
                MessageBox.Show("Se ha guardado la informacion correctamente", "Carta porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}
