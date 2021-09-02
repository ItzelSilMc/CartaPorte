using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoPersona
    {
        public TipoPersona tipoPersona;
        public string  RFC,CodigoTransportista,  Nombre, NumRegistro, ResidenciaFiscal, calle, NumExterior, NumInterior, NumLicencia;
        public ObjetoDireccion objDireccion;



        public override string ToString()
        {
            string Cadena = "";

            switch(tipoPersona)
            {
                case TipoPersona.Transportista:
                    Cadena = "'" + RFC + "','" + CodigoTransportista + "','" + Nombre + "','" + ResidenciaFiscal + "','" +
                        NumRegistro + "'";
                        break;

                case TipoPersona.Embarcador:
                    Cadena = "'" + Nombre + "','" + ResidenciaFiscal + "','" + NumRegistro;
                    break;

                case TipoPersona.Operador:
                    Cadena = "";
                    break;
            }

            return Cadena;


        }
    }
}
