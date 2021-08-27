using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoDerechosPaso
    {
        public string DerechosPaso;
        public decimal KilometrajePagado;

        private int IdFerroviario;


        public void ActualizarIdFerroviario(int IdFerroviario)
        {
            this.IdFerroviario = IdFerroviario;
        }

        public override string ToString()
        {
            return "'" + DerechosPaso + "'," + KilometrajePagado + "," + IdFerroviario; 
        }
    }
}
