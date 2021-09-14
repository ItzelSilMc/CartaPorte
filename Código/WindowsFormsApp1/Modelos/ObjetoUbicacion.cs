using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    class ObjetoUbicacion
    {

        public string INVOICE_ID;
        public string TipoEstacion;
        public string RFC;
        public string Nombre;
        public string NumRegIdTrib;
        public string ResidenciaFiscal;
        public string NumEstacion;
        public string NombreEstacion;
        public string NavegacionTrafico;
        public string FechaHora;
        public string ID_DOMICILIO;

        public override string ToString()
        {
            return "'" + TipoEstacion + "','" + RFC + "','" + Nombre + "','" + NumRegIdTrib + "','" + ResidenciaFiscal + "','" + NumEstacion + "','" +
                NombreEstacion + "','" + NavegacionTrafico + "','" + FechaHora + "','" + ID_DOMICILIO + "', '" + INVOICE_ID + "'";
        }
    }
}
