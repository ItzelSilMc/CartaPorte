using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoTransporteFerroviario
    {
        public int ID;

        public string TipoServicio, NombreAseguradora, NumPolizaSeguro, Concesionario;


        public override string ToString()
        {
            return "'" + TipoServicio + "','" + NombreAseguradora + "','" + NumPolizaSeguro + "','" + Concesionario + "'";
        }
    }
}
