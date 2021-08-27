using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoAereo
    {
        public string PermSCT, NumPermisoSCT, MatriculaAeronave, NombreAseg, NumPolizaSeguro, NumGuia, LugarContrato;

        private int IdTransportista, IdEmbarcador;

        public void ActualizarIdTransportista (int IdTransportista)
        {
            this.IdTransportista = IdTransportista;
        }
        public void ActualizarIdEmbarcador(int IdEmbarcador)
        {
            this.IdEmbarcador = IdEmbarcador;
        }

        public override string ToString()
        {
            string IdEmbarcadorCadena  = IdEmbarcador == 0 ? "null" : IdEmbarcador.ToString();
            string IdTranspoCadena = IdTransportista == 0 ? "null" : IdTransportista.ToString();


            return "'" + PermSCT + "','" + NumPermisoSCT + "','" + MatriculaAeronave + "','" + NombreAseg + "','" + NumPolizaSeguro + "','" +
               NumGuia + "','" + LugarContrato + "'," + IdTranspoCadena + "," + IdEmbarcadorCadena;
        }
    }
}
