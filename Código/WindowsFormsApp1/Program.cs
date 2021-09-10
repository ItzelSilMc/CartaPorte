using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            #endregion
           
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (args.Count() == 0)
                {
                    
                    //Application.Run(new FrmPrincipal());
                    Application.Run(new FrmPrincipal("12563"));

                }
                else
                {
                    Application.Run(new FrmConfiguraciones());
                }
            }
                catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
