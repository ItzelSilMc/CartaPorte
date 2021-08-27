using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoRemolque
    {
        public string SubtipoRemolque, PlacaRemolque;

        private int IdAutotransporte;

        public void ActualizarIdAutotransporte(int IdAutotransporte)
        {
            this.IdAutotransporte = IdAutotransporte;
        }

        public override string ToString()
        {
            return "" + IdAutotransporte + ",'" + SubtipoRemolque + "','" + PlacaRemolque + "'";
        }
    }
}
