using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Modelos
{
    public static class EstructurasEnums
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


        public enum  TablasCartaPorte
        {
            VMX_FE_CARTAPORTE,

            //Ubicaciones
            VMX_FE_CP_UBICACIONES,
            VMX_FE_CP_UBICACION,
            VMX_FE_CP_DOMICILIO,

            //Mercancias
            VMX_FE_CP_MERCANCIAS,
            VMX_FE_CP_DETALLE_MERCANCIA,
            VMX_FE_CP_PRODUCTO,

            //Ferroviario
            VMX_FE_CP_FERROVIARIO,
            VMX_FE_CP_CARRO,
            VMX_FE_CP_DERECHOS_PASO,
            VMX_FE_CP_CONTENEDOR_FERROVIARIO,

             //Maritimo
            VMX_FE_CP_MARITIMO,
            VMX_FE_CP_CONTENEDOR,

            //AutoTransporteFederal
            VMX_FE_CP_AUTOTRANSPORTE_FEDERAL,
            VMX_FE_CP_IDENTIFICACION_VEHICULAR,
            VMX_FE_CP_REMOLQUES,
            VMX_FE_CP_CONFIGURACION_FEDERAL,


            //Aereo
            VMX_FE_CP_AEREO,

            //FiguraTransporte
            VMX_FE_CP_FIGURA_TRANSPORTE,
            VMX_FE_CP_TRANSPORTISTA,
            VMX_FE_CP_EMBARCADOR,
            VMX_FE_CP_OPERADOR,
            VMX_FE_CP_PROPIETARIO,
            VMX_FE_CP_ARRENDATARIO,
            VMX_FE_CP_NOTIFICADO
        }


        
    }

  
}
