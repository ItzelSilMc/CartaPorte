using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoCarro
    {
        public int ID;
        public string TipoCarro, GuiaCarro, Matricula;
        public decimal ToneladasNetoCarro;

        private int IdFerroviario;

        public void ActualizarIdFerroviario(int IdFerroviario)
        {
            this.IdFerroviario = IdFerroviario;
        }

        public override string ToString()
        {
            return  "'"+TipoCarro +"','" + GuiaCarro + "', "+"'"+Matricula +"',"+ToneladasNetoCarro+"," + IdFerroviario;
        }

        
    }
}
