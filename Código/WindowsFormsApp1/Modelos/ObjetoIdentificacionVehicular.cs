﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoIdentificacionVehicular
    {
        public string ConfiguracionVehicular, PlacaVehiculo;
        public int AñoModelo;

        public override string ToString()
        {
            return "'" + ConfiguracionVehicular + "','" + PlacaVehiculo + "'," + AñoModelo;
        }


    }
}
