using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApp1.Modelos;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {

            #region Pruebas
            //Pruebas ferrocarril
            //int IdFerroviario = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_FERROVIARIO,
            //  new ObjetoTransporteFerroviario() { Concesionario = "conse", NombreAseguradora = "finanzas", NumPolizaSeguro = "298938", TipoServicio = "chido" });

            //ObjetoCarro carro = new ObjetoCarro()
            //{
            // GuiaCarro = "guia1", Matricula ="JNF3059", TipoCarro ="abc12", ToneladasNetoCarro = 2.10m

            //};
            //carro.ActualizarIdFerroviario(IdFerroviario);


            //int IdCarro = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_CARRO, carro);


            //ObjetoDerechosPaso dp = new ObjetoDerechosPaso()
            //{
            //  DerechosPaso = "derecho1", KilometrajePagado = 57.00m
            //};

            //dp.ActualizarIdFerroviario(IdFerroviario);


            //Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_DERECHOS_PASO, dp);

            //ObjetoContenedorFerroviario ocf = new ObjetoContenedorFerroviario()
            //{
            //    PesoContenedorVacio = 10m, PesoNetoMercancia = 10m , TipoContenedor ="Nuevo"

            //};

            //ocf.ActualizarIdCarro(IdCarro);


            //int idContenedorFerroviario =  Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_CONTENEDOR_FERROVIARIO, ocf);



            //Pruebas autotransporte.

            //ObjetoIdentificacionVehicular identi = new ObjetoIdentificacionVehicular()
            //{
            //    AñoModelo = 1992,
            //    ConfiguracionVehicular = "abc12",
            //    PlacaVehiculo = "jnf3050"
            //};

            //int IdIdentificacion = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR, identi);

            //ObjetoAutotransporte auto = new ObjetoAutotransporte()
            //{
            //    PermisoSCT= "con1", NombreAseguradora = "axxa", NumPolizaSeguro= "12345", NumPermisoSCT= "FB1" 
            //};

            //auto.ActualizarIdVehicular(IdIdentificacion);

            //int IdAutotrans = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL, auto);

            //ObjetoRemolque remolque = new ObjetoRemolque()
            //{
            //    PlacaRemolque = "JFF12",
            //    SubtipoRemolque = "FB3"
            //};
            //remolque.ActualizarIdAutotransporte(IdAutotrans);

            //int idRemolque = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_REMOLQUES, remolque);


            //ObjetoMaritimo oMarit = new ObjetoMaritimo()
            //{
            //    AñoEmbarcacion= 1992, Calado = 10m , Eslora = 10m, LineaNaviera="LN", Manga = 10m, Matricula ="MAT1", NacionalidadEmbarc="MEX", NombreAgenteNaviero ="NAME", NombreAseg = "AXXA", 
            //    UnidadesDeArqBruto = 10M, NombreEmbar = "NAME2", NumAutorizacionNaviero = "AUTO", NumCertITC ="CERT", NumConocEmbarc = "AJUA", NumeroOMI = "23723", NumPermisoSCT = "3434",
            //     NumPolizaSeguro = "242424", NumViaje = "205", PermSCT = "233", TipoCarga ="ALGO", TipoEmbarcacion ="BR34"
            //};


            //int IdMaritimo = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_MARITIMO, oMarit);

            //ObjetoContenedorMaritimo conteMari = new ObjetoContenedorMaritimo()
            //{
            //    MatriculaContenedor = "m445", NumPrecinto = "1344", TipoContenedor = "CNT12"
            //};
            //conteMari.ActualizarIdMaritimo(IdMaritimo);


            //int IdContenedorMaritimo = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_CONTENEDOR, conteMari);






            //ObjetoAereo ae = new ObjetoAereo()
            //{
            // LugarContrato ="MEX", MatriculaAeronave="398398", NombreAseg="AXXA", NumGuia ="GUA1", NumPermisoSCT = "33", NumPolizaSeguro= "32" 
            //};


            //int IdAereo = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_AEREO, ae);
            //Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL, 3);
            //Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR, 1);
            //Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_REMOLQUES, 3);
            //Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL);
            //ObjetoProducto prod = new ObjetoProducto()
            //{
            //    BienesTransp = "8373",
            //    ClaveSTCC = "131",
            //    ClaveUnidad = "u1",
            //    CveMaterialPeligroso = "",
            //    Descripcion = "NA"
            // ,
            //    DescripcionEmbalaje = "",
            //    Embalaje = "BALA",
            //    FraccioArancelaria = "131",
            //    MaterialPeligroso = "NO",
            //    Moneda = "MXN",
            //    Unidad = "u1",
            //    UUIDComercioExterior = "24242422324214412424214",
            //    PART_ID = "232323232323"
            //};

            //int idProducto = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_PRODUCTO, prod);



            //ObjetoMercancias cabezaMerca = new ObjetoMercancias()
            //{
            //  INVOICE_ID = "1131313", CargoPorTasacion = "313", NumTotalMercancia = 1, PesoBrutoTotal = 10010, PesoNetoTotal = 12121, UnidadPeso = "U1"
            //};

            //int IdCabecera = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_MERCANCIAS, cabezaMerca);


            //ObjetoDetalleMercancia detMerca = new ObjetoDetalleMercancia()
            //{
            // UnidadPeso = "", Cantidad = 1, Dimensiones = "10x10", ID_MERCANCIAS = IdCabecera , ID_PRODUCTO = idProducto,
            //  NumPiezas = 1, PesoBruto = 10.5m, PesoEnKg = 10.8m, PesoNeto = 10.1m, PesoTara = 10, ValorMercancia = "n/a"
            //};

            //int IDMerca = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_DETALLE_MERCANCIA, detMerca);

            // bool yesOnO = Metodos.ActualizarRegistro(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL, "SET NombreAseg = 'SEGUROS BANQUEOS' WHERE ID_FEDERAL = 10");

            Pruebas();

            #endregion
           
            try
            {


                string folio = ConfigurationManager.AppSettings.Get("folio");
                if (folio=="")
                {
                    MessageBox.Show("Debe agregar una factura en el config.");

                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    if (args.Count() == 0)
                    {

                        //Application.Run(new FrmPrincipal());
                        Application.Run(new FrmPrincipal(folio));

                    }
                    else
                    {
                        Application.Run(new FrmConfiguraciones());
                    }
                }
                Application.Exit();
                
            }
                catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Pruebas()
        {

            ComplementoCartaPorte cascaron = new ComplementoCartaPorte();
            cascaron.EntradaSalidaMerc = "Entrada";
            cascaron.ViaEntradaSalida = "01";
            cascaron.TranspInternac = "No";


           

            cascaron.ubicaciones = new Modelos.Ubicaciones();


            Ubicacion Ubic = new Ubicacion()
            {
                TipoEstacion = "IDN",
                DistanciaRecorrida = 0,
                origen = new Origen()
                {
                    FechaHoraSalida = DateTime.Now, IDOrigen = "OR1", NavegacionTrafico = "NO SE", NombreEstacion = "UNI", 
                    NombreRemitente="EL JIMMY", NumEstacion= "01", NumRegIdTrib= "1331", ResidenciaFiscal = "MEX", RFCRemitente ="RFCGENERICO" 
                }
                , destino = null
            };

            Ubicacion UbicDestino = new Ubicacion()
            {
                TipoEstacion = "DES", destino = new Destino()
                {
                    FechaHoraProgLlegada = DateTime.Now, IDDestino = "DEST1", NavegacionTrafico = "TODO DERECHO", NombreDestinatario = "PEPE", NombreEstacion = "02", NumEstacion = "8131", NumRegIdTrib = "4321", ResidenciaFiscal = "MEX", RFCDestinatario = "RFC2CHIDO"
                },
                DistanciaRecorrida = 20, 
                origen = null
            };




            cascaron.ubicaciones.ubicacion = new Ubicacion[]{ Ubic, UbicDestino };
            
            Domicilio domicilio1 = new Domicilio()
            {
                Calle = "Chamizal", CodigoPostal = "44860", Colonia = "043", Estado = "JAL", Localidad = "GDL", Municipio = "GDL", NumeroExterior = "1004", NumeroInterior = "47", Pais = "MEX", Referencia = "CASA BLANCA"
            };


            Operador operador = new Operador
            {
                RFCOperador = "MEES9201306C9",
                NombreOperador = "Santiago Meza",
                NumLicencia= "123",
                NumRegIdTribOperador = "123",
                ResidenciaFiscalOperador= "MEX",
                domicilio = domicilio1
            };


            FiguraTransporte figuraTransporte = new FiguraTransporte()
            {
                CveTransporte = "01",
                
            };

            figuraTransporte.operadores = new Operadores();
            figuraTransporte.operadores.operador = new Operador[] {operador };
            
            

            IdentificacionVehicular identificacion = new IdentificacionVehicular()
            {
                 AnioModeloVM= 1992, ConfigVehicular = "CONF1", PlacaVM = "JNF3030"
            };

            Remolque remolque1 = new Remolque()
            {
                 Placa = "PAL233", SubTipoRem = "CTR026"
            };
            Remolques remolques = new Remolques();

            Remolque[] remolquesTodos = { remolque1 };

            remolques.remolque = remolquesTodos;

            AutotransporteFederal auto = new AutotransporteFederal()
            {

                 NombreAseg = "AXXA SEGUROS", NumPermisoSCT = "PERM13", NumPolizaSeguro = "21212A3QA3AAA", PermSCT = "2332",
                 identificacionVehicular = identificacion,
                 remolques = remolques
                 
            };

            DetalleMercancia detalle = new DetalleMercancia()
            {
                  NumPiezas= 1, PesoBruto = 1.5m, PesoNeto = 10.1m , PesoTara= 10.0m 
            };

            CantidadTransporta cantidadTransporta = new CantidadTransporta()
            {
                Cantidad =2, CvesTransporte = "01", IDDestino= "DEST01", IDOrigen = "OR01"
            };

            Mercancia mercancia = new Mercancia()
            {
                BienesTransportado = "", ClaveSTCC = "",
                detalleMercancia = detalle
               
            };
            mercancia.cantidadTransporta =  new CantidadTransporta[]{ cantidadTransporta};


            Mercancias mercancias = new Mercancias()
            {
                autotransporteFederal = auto,
                CargoPorTasacion = 10m, NumTotalMercancias = 1, PesoBrutoTotal = 1000, PesoNetoTotal = 103, UnidadPeso = "PZA",
               

            };
            mercancias.mercancia = new  Mercancia[] { mercancia };

            ///partes del complemento
            ///
            cascaron.mercancias = mercancias;
            cascaron.figuraTransporte = figuraTransporte;


            string cadena = AppDomain.CurrentDomain.BaseDirectory + "\\" + "prueba";
            TextWriter archivo = new StreamWriter(cadena + ".XML");
            XmlSerializer serializer = null;
            XmlSerializerNamespaces myNameSpaces = new XmlSerializerNamespaces();
            myNameSpaces.Add("cartaporte", "http://www.sat.gob.mx/CartaPorte");



           
             serializer = new XmlSerializer(typeof(ComplementoCartaPorte));
            
            
            serializer.Serialize(archivo, cascaron, myNameSpaces);
            archivo.Close();




        }
    }
}
