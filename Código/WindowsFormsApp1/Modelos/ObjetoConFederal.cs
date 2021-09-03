using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    class ObjetoConFederal
    {
        

        public string INVOICE_ID ,ID_FEDERAL , ID_VEHICULAR ,ID_REMOLQUE;

        public override string ToString()
        {
            return "'" + INVOICE_ID + "','" + ID_FEDERAL + "','" + ID_VEHICULAR + "','" + ID_REMOLQUE +  "'";
        }
    }
}
