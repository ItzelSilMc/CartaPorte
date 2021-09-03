using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoContenedorMaritimo
    {
        public int ID;
        public string MatriculaContenedor, NumPrecinto, TipoContenedor;

        private int IdMaritimo;

        public void ActualizarIdMaritimo(int IdMaritimo)
        {
            this.IdMaritimo = IdMaritimo;
        }

        public override string ToString()
        {
            return "'" + MatriculaContenedor + "','" + NumPrecinto + "','" + TipoContenedor + "'," + IdMaritimo;
        }
    }
}
