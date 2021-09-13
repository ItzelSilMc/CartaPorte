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
        public int ID;

        public TipoPersona tipoPersona;
        public string  RFC,CodigoTransportista, Numlicencia,  Nombre, NumRegistro, ResidenciaFiscal, calle, NumExterior, NumInterior, NumLicencia;
        int IdDomicilio;
        public ObjetoDireccion objDireccion;

        public void ActualizarDomicilio(int IdDomicilio)
        {
            this.IdDomicilio = IdDomicilio;
        }
        public void SetTipoPersona(TipoPersona tipoPersona)
        {
            this.tipoPersona = tipoPersona;
        }

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
                    Cadena = "'" + RFC + "','" + Nombre + "','" + CodigoTransportista + "','" + NumRegistro + "','" +
                      ResidenciaFiscal+ "'," + IdDomicilio;
                    break;

                case TipoPersona.Notificado:
                    Cadena = "'" + RFC + "','" + Nombre + "','" + NumRegistro +"','"+ ResidenciaFiscal + "'," +
                     IdDomicilio ;
                    break;
            }

            return Cadena;


        }
    }
}
