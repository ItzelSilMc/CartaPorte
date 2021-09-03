using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoMaritimo
    {

        public int ID;

        public string PermSCT, NumPermisoSCT, NombreAseg, NumPolizaSeguro, TipoEmbarcacion, Matricula, NumeroOMI,
            NombreEmbar, NacionalidadEmbarc, TipoCarga, NumCertITC, LineaNaviera, NombreAgenteNaviero, NumAutorizacionNaviero, NumViaje, NumConocEmbarc;

        public decimal UnidadesDeArqBruto, Eslora, Manga, Calado;

        public int AñoEmbarcacion;


        public override string ToString()
        {
            return "'" + PermSCT + "','" + NumPermisoSCT + "','" + NombreAseg + "','" + NumPolizaSeguro + "','" + TipoEmbarcacion + "','" +
                Matricula + "','" + NumeroOMI + "'," + AñoEmbarcacion + ",'" + NombreEmbar + "','" + NacionalidadEmbarc + "'," + UnidadesDeArqBruto + ",'" +
               TipoCarga +"','" + NumCertITC + "', " + Eslora + "," + Manga + "," + Calado + ",'" + LineaNaviera + "','"+ NombreAgenteNaviero +"','" +
               NumAutorizacionNaviero + "','" + NumViaje + "','" + NumConocEmbarc + "'";
        }
    }
}
