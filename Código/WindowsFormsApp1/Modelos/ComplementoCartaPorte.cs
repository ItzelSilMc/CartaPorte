
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1.Modelos
{
    class ComplementoCartaPorte
    {
        [XmlAnyAttribute()]
        public string Version = "1.0";

        [XmlAttribute()]
        public string TranspInternac;

        [XmlAttribute()]
        public string EntradaSalidaMerc;

        [XmlAttribute()]
        public string ViaEntradaSalida;

        [XmlAttribute()]
        public Ubicaciones ubicaciones;

        [XmlAttribute()]
        public FiguraTransporte figuraTransporte;

        [XmlAttribute()]
        public Mercancias mercancias;

    }
    public class Mercancias
    {
        /// <summary>
        /// Opcional
        /// </summary>
        [XmlAttribute()]
        public decimal PesoBrutoTotal;

        /// <summary>
        /// Opcional
        /// </summary>
        [XmlAttribute()]
        public decimal UnidadPeso;

        /// <summary>
        /// Opcional
        /// </summary>
        [XmlAttribute()]
        public decimal PesoNetoTotal;

        /// <summary>
        /// Atributo requerido para expresar el número total de los bienes o  mercancías que se transladan en los distintos medios de transporte, identificandose por cada nodo "Mercancia" registrado en el complemento.
        /// </summary>
        [XmlAttribute()]
        public int NumTotalMercancias;

        /// <summary>
        /// Opcional
        /// </summary>
        [XmlAttribute()]
        public decimal CargoPorTasacion;

        [XmlAttribute()]
        public Mercancia[] mercancia;
    }
    public class Mercancia
    {
        /// <summary>
        /// Atributo condicional para expresar la clave de producto de los bienes o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [XmlAttribute()]
        public string BienesTransportado;


        [XmlAttribute()]
        public string ClaveSTCC;

        [XmlAttribute()]
        public string ClaveUnidad;

        [XmlAttribute()]
        public string Unidad;

        [XmlAttribute()]
        public string Dimensiones;

        [XmlAttribute()]
        public string MaterialPeligroso;

        [XmlAttribute()]
        public string CveMaterialPeligroso;

        /// <summary>
        /// Atributo condicional para precisar la clave del tipo de embalaje que se requiere para transportar el material o residuo peligroso.
        /// </summary>
        [XmlAttribute()]
        public string Embalaje;

        /// <summary>
        /// Atributo opcional para expresar la descripcion del embalaje en el que se transporta los bienes o mercancías que se consideran material o residuo peligroso.
        /// </summary>
        [XmlAttribute()]
        public string DescripEmbalaje;

        /// <summary>
        /// Atributo requerido para indicar el peso en kilogramos de los bienes o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [XmlAttribute()]
        public decimal PesoEnKg;

        [XmlAttribute()]
        public decimal ValorMercancia;

        [XmlAttribute()]
        public string Moneda;

        [XmlAttribute()]
        public string FraccionArancelaria;

        [XmlAttribute()]
        public string UUIDComercioExt;

        [XmlAttribute()]
        public CantidadTransporta[] cantidadTransporta;

        [XmlAttribute()]
        public DetalleMercancia detalleMercancia;
    }
    public class CantidadTransporta
    {
        [XmlAttribute()]
        public decimal Cantidad;

        [XmlAttribute()]
        public string IDOrigen;

        [XmlAttribute()]
        public string IDDestino;

        [XmlAttribute()]
        public string CvasTransporte;
    }
    public class DetalleMercancia
    {
        [XmlAttribute()]
        public string UnidadPeso;

        [XmlAttribute()]
        public decimal PesoBruto;

        [XmlAttribute()]
        public decimal PesoNeto;

        [XmlAttribute()]
        public decimal PesoTara;

        [XmlAttribute()]
        public int NumPiezas;
    }

    public class AutotransporteFederal
    {

        [XmlAttribute()]
        public string PermSCT;

        [XmlAttribute()]
        public string NumPermisoSCT;

        [XmlAttribute()]
        public string NombreAseg;

        [XmlAttribute()]
        public string NumPolizaSeguro;

        [XmlAttribute()]
        public IdentificacionVehicular identificacionVehicular;

        public Remolques remolques;

    }

    public class IdentificacionVehicular
    {
        [XmlAttribute()]
        public string ConfigVehicular;

        [XmlAttribute()]
        public string PlacaVM;

        [XmlAttribute()]
        public int AnioModeloVM;
    }
    public class Remolques
    {
        [XmlAttribute()]
        public Remolque[] remolque;

    }

    public class Remolque
    {
        [XmlAttribute()]
        public string SubTipoRem;

        [XmlAttribute()]
        public string Placa;
    }

    public class FiguraTransporte
    {
        /// <summary>
        /// Atributo requerido para expresar la clave que identifica el medio por el cual se transportan los bienes o mercancías.
        /// </summary>
        [XmlAttribute()]
        public string CveTransporte;

        [XmlAttribute()]
        public Operadores operadores;

        [XmlAttribute()]
        public Notificados notificados;
    }

    public class Ubicaciones
    {
        [XmlAttribute()]
        Ubicacion[] ubicacion;

    }

    public class Ubicacion
    {
        [XmlAttribute()]
        public string TipoEstacion;

        [XmlAttribute()]
        public decimal DistanciaRecorrida;

        [XmlAttribute()]
        public Origen origen;

        [XmlAttribute()]
        public Destino destino;
    }

    public class Origen
    {
        [XmlAttribute()]
        public string IDOrigen;

        [XmlAttribute()]
        public string RFCRemitente;

        [XmlAttribute()]
        public string NombreRemitente;

        [XmlAttribute()]
        public string NumRegIdTrib;

        [XmlAttribute()]
        public string ResidenciaFiscal;

        [XmlAttribute()]
        public string NumEstacion;

        [XmlAttribute()]
        public string NombreEstacion;


        /// <summary>
        /// Atributo condicional para registrar el tipo de puerto por el que se documentan los bienes o mercancías vía marítima.
        /// </summary>
        [XmlAttribute()]
        public string NavegacionTrafico;

        [XmlAttribute]
        public DateTime FechaHoraSalida;

    }


    public class Destino
    {
        [XmlAttribute()]
        public string IDDestino;

        [XmlAttribute()]
        public string RFCDestinatario;

        [XmlAttribute()]
        public string NombreDestinatario;

        [XmlAttribute()]
        public string NumRegIdTrib;

        [XmlAttribute()]
        public string ResidenciaFiscal;

        [XmlAttribute()]
        public string NumEstacion;

        [XmlAttribute()]
        public string NombreEstacion;


        /// <summary>
        /// Atributo condicional para registrar el tipo de puerto por el que se documentan los bienes o mercancías vía marítima.
        /// </summary>
        [XmlAttribute()]
        public string NavegacionTrafico;

        [XmlAttribute]
        public DateTime FechaHoraProgLlegada;
    }

    public class Domicilio
    {
        [XmlAttribute]
        public string Nombre;

        [XmlAttribute]
        public string NumeroExterior;

        [XmlAttribute]
        public string NumeroInterior;

        [XmlAttribute]
        public string Colonia;

        [XmlAttribute]
        public string Localidad;

        [XmlAttribute]
        public string Referencia;

        [XmlAttribute]
        public string Municipio;

        [XmlAttribute]
        public string Estado;

        [XmlAttribute]
        public string Pais;

        [XmlAttribute]
        public string CodigoPostal;

    }

    public class Operadores
    {
        [XmlAttribute()]
        public Operador[] operador;
    }

    public class Notificados
    {
        public Notificado[] notificado;
    }

    public class Operador
    {
        [XmlAttribute()]
        public string RFCOperador;

        [XmlAttribute()]
        public string NumLicencia;

        [XmlAttribute()]
        public string NombreOperador;

        [XmlAttribute()]
        public string NumRegIdTribOperador;

        [XmlAttribute()]
        public string ResidenciaFiscalOperador;

        [XmlAttribute()]
        public Domicilio domicilio;
    }

    public class Notificado
    {
        [XmlAttribute()]
        public string RFCONotificado;

        [XmlAttribute()]
        public string NombreNotificado;

        [XmlAttribute()]
        public string NumRegIdTribNotificado;

        [XmlAttribute()]
        public string ResidenciaFiscalNotificado;

        [XmlAttribute()]
        public Domicilio domicilio;
    }
}
