using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    class ObjetoCartePorte
    {
        public string INVOICE_ID, TransInternal, EntradaSalidaMerc, ViaEntradaSalida;

        public string TotalDistRec;

        public override string ToString()
        {
            return "'" + INVOICE_ID + "','" + TransInternal + "','" + EntradaSalidaMerc + "','" + ViaEntradaSalida + "'," + TotalDistRec; 
        }
    }
}
