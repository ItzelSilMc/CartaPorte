using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoDireccion
    {
        public int ID;

        public string calle;
        public string NumeroExterior;
        public string NumeroInterior;
        public string Pais;
        public string Estado;
        public string Municipio;
        public string Ciudad;
        public string CodigoPostal;
        public string Colonia;
        public string Localidad;
        public string Referencia;
        public string Tipo;


        public override string ToString()
        {
            return "'" + calle + "','" + NumeroExterior + "','" + NumeroInterior + "','"+ Colonia + "','" + Localidad +"','" +
                Referencia + "','" + Municipio + "','" + Estado + "','"+ Pais + "','"+ CodigoPostal + "','" + Tipo + "'" ;
        }
    }
}
