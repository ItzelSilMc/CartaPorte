using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoAutotransporte
    {
        public string PermisoSCT, NumPermisoSCT, NombreAseguradora, NumPolizaSeguro;

        private int IdVehicular;

        public void ActualizarIdVehicular(int IdVehicular)
        {
            this.IdVehicular = IdVehicular;
        }

        public override string ToString()
        {
            return "'" + PermisoSCT + "','" + NumPermisoSCT + "','" + NombreAseguradora + "','" + NumPolizaSeguro + "'," + IdVehicular; 
        }
    }
}
