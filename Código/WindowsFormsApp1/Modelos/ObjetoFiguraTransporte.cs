using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    class ObjetoFiguraTransporte
    {
        public int ID_FIGURA;
        public string INVOICE_ID;
        public string CveTransporte;

        public int ID_OPERADOR, ID_PROPIETARIO, ID_ARRENDATARIO, ID_NOTIFICADO;

        public override string ToString()
        {
            return "'" + INVOICE_ID + "','" + CveTransporte + "'," + ID_OPERADOR + "," + ID_PROPIETARIO + "," + ID_ARRENDATARIO + "," + ID_NOTIFICADO;
        }


    }
}
