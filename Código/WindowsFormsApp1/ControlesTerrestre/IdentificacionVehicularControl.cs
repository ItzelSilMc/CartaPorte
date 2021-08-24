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

namespace WindowsFormsApp1.ControlesTerrestre
{
    public partial class IdentificacionVehicularControl : UserControl
    {
        public IdentificacionVehicularControl()
        {
            InitializeComponent();
        }
        public void CargarComboConfigVehicular(Dictionary<string, string> ConfiguracionesVehiculares)
        {
            EstructurasFunciones.CargarComboValores(CmbConfigVehicular, ConfiguracionesVehiculares);
        }

        public ObjetoIdentificacionVehicular ObtenerIdentificacionVehicular()
        {
            ObjetoIdentificacionVehicular objetoIdentificacion = new ObjetoIdentificacionVehicular
            {
                ConfiguracionVehicular = string.IsNullOrEmpty(CmbConfigVehicular.Text) ? "" : CmbConfigVehicular.SelectedValue.ToString(),
                PlacaVehiculo = TxtPlacaVehicular.Text,
                AñoModelo = TxtAñoModelo.Text
            };

            return objetoIdentificacion;
        }


        public void CargarDatosPrevios(ObjetoIdentificacionVehicular identificacion)
        {
            if (!string.IsNullOrEmpty(identificacion.ConfiguracionVehicular))
            {
                CmbConfigVehicular.SelectedValue = identificacion.ConfiguracionVehicular;
            }
            TxtAñoModelo.Text = identificacion.AñoModelo;
            TxtPlacaVehicular.Text = identificacion.PlacaVehiculo;
            
        }
    }
}
