using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.Modelos.EstructurasFunciones;

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoPersona
    {
        public TipoPersona tipoPersona;
        public string  RFC, Nombre, NumRegistro, ResidenciaFiscal, calle, NumExterior, NumInterior, NumLicencia;
        public ObjetoDireccion objDireccion;
    }
}
