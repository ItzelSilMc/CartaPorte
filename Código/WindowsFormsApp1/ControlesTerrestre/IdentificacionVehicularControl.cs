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
    }
}
