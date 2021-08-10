using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Modelos
{
    public static class EstructurasFunciones
    {
        public enum CatalogoCartaPorte
        {
            ClaveTransporte,
            TipoEstacion,
            Estaciones,
            ClaveUnidadPeso,
            MaterialPeligroso,
            TipoEmbalaje,
            TipoPermiso,
            Colonia,
            ConfigAutoFederal,
            TipoRemolque,
            ConfigMaritima,
            TipoCarga,
            ContenedorMaritimo,
            AutorizacionNaviero,
            TransporteAereo,
            ClaveProdSTCC,
            TipoServicio,
            DerechosPaso,
            TipoCarro,
            TipoContenedor
        }

        public enum TipoPersona
        {
            Transportista,
            Embarcador,
            Arrendatario,
            Operador,
            Propietario
        }


        public static void CargarComboValores(ComboBox combo, Dictionary<string, string> Valores)
        {
            if (Valores.Count > 0)
            {
                combo.DataSource = new BindingSource(Valores, null);
                combo.DisplayMember = "Value";
                combo.ValueMember = "Key";
            }
        }
    }

  
}
