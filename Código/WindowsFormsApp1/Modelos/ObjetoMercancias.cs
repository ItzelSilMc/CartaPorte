using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoMercancias
    {
        public string INVOICE_ID;
        public int NumTotalMercancia;
        public string CargoPorTasacion;
        public decimal PesoBrutoTotal;
        public string UnidadPeso;
        public decimal PesoNetoTotal;

        public override string ToString()
        {
            return "'" + INVOICE_ID + "'," + NumTotalMercancia + ",'" + CargoPorTasacion + "'," + PesoBrutoTotal + ",'" +
                UnidadPeso + "'," + PesoNetoTotal;
        }
    }
}
