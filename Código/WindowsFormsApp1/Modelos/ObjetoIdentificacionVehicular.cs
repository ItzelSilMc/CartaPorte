using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoIdentificacionVehicular
    {
        public string ConfiguracionVehicular, PlacaVehiculo, NumPolizaSeguro;
        public int AñoModelo;

        public void ActualizarPolizaSeguro(string NumPolizaSeguro)
        {
            this.NumPolizaSeguro = NumPolizaSeguro;
        }

        public override string ToString()
        {
            return "'" + ConfiguracionVehicular + "','" + PlacaVehiculo + "'," + AñoModelo + ",'"+ NumPolizaSeguro + "'";
        }


    }
}
