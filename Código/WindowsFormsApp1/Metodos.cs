using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1
{
    public static class Metodos
    {

        /// <summary>
        /// Metodo encargad de cargar los valores de cualquier combo a traves de un Dictionary
        /// </summary>
        /// <param name="combo">Combobox al cual se le asignaran sus valores</param>
        /// <param name="Valores">Valores a insertar en el combo</param>
        public static void CargarComboValores(ComboBox combo, Dictionary<string, string> Valores)
        {
            if (Valores.Count > 0)
            {
                combo.DataSource = new BindingSource(Valores, null);
                combo.DisplayMember = "Value";
                combo.ValueMember = "Key";
            }
        }

        /// <summary>
        /// Este metodo retorna el nombre de la tabla a la cual se va a insertar
        /// </summary>
        /// <returns></returns>
        public static string ObtenerNombreTabla(TablasCartaPorte tabla)
        {
            return tabla.ToString();
        }

        /// <summary>
        /// Este metodo retorna los campos que contiene cada tabla.
        /// </summary>
        /// <param name="tabla"></param>
        /// <returns></returns>
        public static string ObtenerCamposTabla(TablasCartaPorte tabla)
        {
            string resultado = "";
            switch(tabla)
            {
                case TablasCartaPorte.VMX_FE_CARTAPORTE:
                    resultado = "";
                    break;

                //Ferroviario

                case TablasCartaPorte.VMX_FE_CP_FERROVIARIO:
                    resultado = "TipoDeServicio, NombreAseg, NumPolizaSeguro, Concesionario";
                    break;

                case TablasCartaPorte.VMX_FE_CP_CARRO:
                    resultado = "tipoCarro, MatriculaCarro, GuiaCarro, ToneladasNetasCarro, ID_FERROVIARIO ";
                    break;

                case TablasCartaPorte.VMX_FE_CP_CONTENEDOR_FERROVIARIO:
                    resultado = "TipoContenedor, PesoContenedorVacio, PesoNetoMercancia, ID_CARRO";
                    break;

                case TablasCartaPorte.VMX_FE_CP_DERECHOS_PASO:
                    resultado = "TipoDerechoDePaso, KilometrajePagado, ID_FERROVIARIO";
                    break;


                    //Autotransporte Federal
                case TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL:
                    resultado = "PermSCT, NumPermisoSCT, NombreAseg";
                    break;

                case TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR:
                    resultado = "ConfigVehicular, PlacaVM, AnioModeloVM, NumPolizaSeguro";
                    break;

                case TablasCartaPorte.VMX_FE_CP_REMOLQUES:
                    resultado = "SubTipoRem, Placa";
                    break;

                case TablasCartaPorte.VMX_FE_CP_MARITIMO:
                    resultado = "PermSCT, NumPermisoSCT, NombreAseg, NumPolizaSeguro, TipoEmbarcacion, Matricula," +
                        " NumeroOMI, AnioEmbarcacion, NombreEmbarc, NacionalidadEmbarc, UnidadesDeArqBruto,TipoCarga, NumCertITC, " +
                        "Eslora, Manga, Calado, LineaNaviera, NombreAgenteNaviero, NumAutorizacionNaviero, NumViaje, NumConocEmbarc";
                    break;

                case TablasCartaPorte.VMX_FE_CP_CONTENEDOR: //Este hace referencia al contenedor maritimo
                    resultado = "MatriculaContenedor, NumPrecinto, TipoContenedor, ID_MARITIMO";
                    break;


                case TablasCartaPorte.VMX_FE_CP_AEREO:
                    resultado = "PermSCT, NumPermisoSCT, MatriculaAeronave, NombreAseg, NumPolizaSeguro, NumGuia, LugarContrato," +
                        "ID_TRANSPORTISTA, ID_EMBARCADOR";
                    break;

                case TablasCartaPorte.VMX_FE_CP_MERCANCIAS:
                    resultado = "INVOICE_ID, NumTotalMercancias, CargoPorTasacion, PesoBrutoTotal, UnidadPeso, PesoNetoTotal";
                    break;

                case TablasCartaPorte.VMX_FE_CP_PRODUCTO:
                    resultado = "BienesTransp, ClaveSTCC, Descripcion, ClaveUnidad, Unidad, MaterialPeligroso,CveMaterialPeligro, Embalaje, DescripEmbalaje, Moneda, FraccionArancelaria, UUIDComercioExt ";
                    break;

                case TablasCartaPorte.VMX_FE_CP_DETALLE_MERCANCIA:
                    resultado = "ID_PRODUCTO, Cantidad, Dimensiones, PesoEnKg, ValorMercancia, UnidadPeso, PesoBruto, PesoTara, NumPiezas";
                    break;

                case TablasCartaPorte.VMX_FE_CP_EMBARCADOR:
                    resultado = "NombreEmbarcador, ResidenciaFiscalEmbar, NumRegIdTribEmbarc";  /// CAMBIAR DE NOMBRE EL CAMPO DE RESIDENCIA FISCAL.
                    break;

                case TablasCartaPorte.VMX_FE_CP_TRANSPORTISTA:
                    resultado = "RFCTransportista, CodigoTransportista, NombreTransportista, ResidenciaFiscalTranspor, NumRegIdTribTranspor";
                    break;

                case TablasCartaPorte.VMX_FE_CP_NOTIFICADO:
                    resultado = "ID_FIGURA_TRANSPORTE, RFCArrendatario, NombreArrendatario, NumRegIdTribArrendatario, ResidenciaFiscalArrendatario, ID_DOMICILIO";
                    break;

                case TablasCartaPorte.VMX_FE_CP_ARRENDATARIO:
                    resultado = "ID_FIGURA_TRANSPORTE, ";
                    break;

                case TablasCartaPorte.VMX_FE_CP_OPERADOR:
                    resultado = "RFC";
                    break;


            }
            return resultado;
        }
        /// <summary>
        /// Este metodo obtiene la cadena del enum mandado
        /// </summary>
        /// <param name="catalogo">Enum mandado para retornar una cadena</param>
        /// <returns></returns>
        public static string ObtenerNombreCatalogoCartaPorte(CatalogoCartaPorte catalogo)
        {
            string Cadena;
            switch (catalogo)
            {
                case CatalogoCartaPorte.ClaveTransporte:
                    Cadena = "ClaveTransporte";
                    break;

                case CatalogoCartaPorte.TipoEstacion:
                    Cadena = "TipoEstacion";
                    break;

                case CatalogoCartaPorte.Estaciones:
                    Cadena = "Estaciones";
                    break;

                case CatalogoCartaPorte.ClaveUnidadPeso:
                    Cadena = "ClaveUnidadPeso";
                    break;

                case CatalogoCartaPorte.MaterialPeligroso:
                    Cadena = "MaterialPeligroso";
                    break;

                case CatalogoCartaPorte.TipoEmbalaje:
                    Cadena = "TipoEmbalaje";
                    break;

                case CatalogoCartaPorte.TipoPermiso:
                    Cadena = "TipoPermiso";
                    break;

                case CatalogoCartaPorte.Colonia:
                    Cadena = "Colonia";
                    break;

                case CatalogoCartaPorte.ConfigAutoFederal:
                    Cadena = "ConfigAutoFederal";
                    break;

                case CatalogoCartaPorte.TipoRemolque:
                    Cadena = "TipoRemolque";
                    break;

                case CatalogoCartaPorte.ConfigMaritima:
                    Cadena = "ConfigMaritima";
                    break;

                case CatalogoCartaPorte.TipoCarga:
                    Cadena = "TipoCarga";
                    break;

                case CatalogoCartaPorte.ContenedorMaritimo:
                    Cadena = "ContenedorMaritimo";
                    break;

                case CatalogoCartaPorte.AutorizacionNaviero:
                    Cadena = "AutorizacionNaviero";
                    break;

                case CatalogoCartaPorte.TransporteAereo:
                    Cadena = "TransporteAereo";
                    break;

                case CatalogoCartaPorte.ClaveProdSTCC:
                    Cadena = "ClaveProductoSTCC";
                    break;

                case CatalogoCartaPorte.TipoServicio:
                    Cadena = "TipoServicio";
                    break;

                case CatalogoCartaPorte.DerechosPaso:
                    Cadena = "DerechosPaso";
                    break;

                case CatalogoCartaPorte.TipoCarro:
                    Cadena = "TipoCarro";
                    break;

                case CatalogoCartaPorte.TipoContenedor:
                    Cadena = "TipoContenedor";
                    break;

                default:
                    Cadena = "";
                    break;
            }

            return Cadena;


        }
        /// <summary>
        /// Metodo encargado de obtener cada uno de los catalogos de la Carta Porte
        /// </summary>
        /// <param name="Catalogo">Parametro que indica cual es el catalogo requerido</param>
        /// <param name="CodigoPostal">Parametro opcional para el catalogo de colonias</param>
        /// <returns></returns>
        public static Dictionary<string, string> ObtenerCatalogoCartaPorte (CatalogoCartaPorte catalog, string CodigoPostal = "", string ClaveTransporte =  "" )
        {
            Dictionary<string, string> Resultado = new Dictionary<string, string>();
            try
            {
                

                string Catalogo = ObtenerNombreCatalogoCartaPorte(catalog);

                SqlConnection c = new SqlConnection(@"Data Source =VESDB\SQL2016; Initial Catalog =CFDI2; User id=SYSADM; Password =SYSADM;");

                c.Open();
                SqlCommand comando = new SqlCommand("VMX_FE_SP_OBTENER_CATALOGO_CP", c);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Catalogo", Catalogo);
                if (!string.IsNullOrEmpty(CodigoPostal))
                {
                    comando.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                }
                if (!string.IsNullOrEmpty(ClaveTransporte))
                {
                    comando.Parameters.AddWithValue("@ClaveTransporte", ClaveTransporte);
                }

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string[] Descripcion = reader["Descripcion"].ToString().Split('-');

                    Resultado.Add(Descripcion[0].Trim(), reader.GetString(0));
                }
                c.Close();
               
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
            return Resultado;


        }

        /// <summary>
        /// Este metodo retorna una lista de string con el catalogo seleccionado
        /// </summary>
        /// <param name="Catalogo"></param>
        /// <returns></returns>
        public static List<string> ObtenerCatalogosCFDI(string Catalogo )
        {
            List<string> CatalogoCFDI = new List<string>();
            try
            {
                SqlConnection c = new SqlConnection(@"Data Source =VESDB\SQL2016; Initial Catalog =CFDI2; User id=SYSADM; Password =SYSADM;");

                c.Open();
                SqlCommand comando = new SqlCommand("VMX_FE_SP_OBTENER_CATALOGO_CFDI", c);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Catalogo", Catalogo);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    CatalogoCFDI.Add(reader["Descripcion"].ToString());
                }
                c.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return CatalogoCFDI;
        }

        public static Modelos.ObjetoDireccion ObtenerDireccionDestino(string INVOICE_ID)
        {
            //VMX_FE_SP_OBTENER_INFO_CARTAPORTE
            Modelos.ObjetoDireccion dir = new Modelos.ObjetoDireccion();
            try
            {


                SqlConnection c = new SqlConnection(@"Data Source =VESDB\SQL2016; Initial Catalog =CFDI2; User id=SYSADM; Password =SYSADM;");

                c.Open();
                SqlCommand comando = new SqlCommand("VMX_FE_SP_OBTENER_INFO_CARTAPORTE", c);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Opcion", "UbicacionDestino");


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    dir.calle = reader["Calle"].ToString();
                    dir.Ciudad = reader["Ciudad"].ToString();
                    dir.Estado = reader["Estado"].ToString();
                    dir.NumeroExterior = reader["NumeroExterior"].ToString();
                    dir.NumeroInterior = reader["NumeroInterior"].ToString();
                    dir.CodigoPostal = reader["CodigoPostal"].ToString();
                    dir.Pais = reader["Pais"].ToString();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }


            return dir;
        }


        /// <summary>
        /// Este metodo retorna el id de la tabla a la que se inserto un registro.
        /// </summary>
        /// <param name="tabla">Tabla a la que se se insertara</param>
        /// <param name="objetoInsertar">Objeto que contiene los datos a insertar</param>
        /// <returns></returns>
        public static  int  InsertarRegistroTabla(TablasCartaPorte tabla, Object objetoInsertar)
        {
            string NombreTabla = ObtenerNombreTabla(tabla);
            string CamposTabla = ObtenerCamposTabla(tabla);

            string valores = "";
            switch (tabla)
            {
                case TablasCartaPorte.VMX_FE_CARTAPORTE:
                    valores = ((ObjetoCartePorte)objetoInsertar).ToString();
                    break;

                case TablasCartaPorte.VMX_FE_CP_CARRO:
                   valores = ((ObjetoCarro)objetoInsertar).ToString();

                        break;

                case TablasCartaPorte.VMX_FE_CP_CONTENEDOR_FERROVIARIO:
                    valores = ((ObjetoContenedorFerroviario)objetoInsertar).ToString();
                    break;

                case TablasCartaPorte.VMX_FE_CP_FERROVIARIO:
                    valores = ((ObjetoTransporteFerroviario)objetoInsertar).ToString();
                        break;

                case TablasCartaPorte.VMX_FE_CP_DERECHOS_PASO:
                    valores = ((ObjetoDerechosPaso)objetoInsertar).ToString();
                    break;

                case TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR:
                    valores = ((ObjetoIdentificacionVehicular)objetoInsertar).ToString();
                    break;

                case TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL:
                    valores = ((ObjetoAutotransporte)objetoInsertar).ToString();
                    break;

                case TablasCartaPorte.VMX_FE_CP_REMOLQUES:
                    valores = ((ObjetoRemolque)objetoInsertar).ToString();
                    break;


                case TablasCartaPorte.VMX_FE_CP_MARITIMO:
                    valores = ((ObjetoMaritimo)objetoInsertar).ToString();
                    break;

                case TablasCartaPorte.VMX_FE_CP_CONTENEDOR:
                    valores = ((ObjetoContenedorMaritimo)objetoInsertar).ToString();
                    break;

                case TablasCartaPorte.VMX_FE_CP_AEREO:
                    valores = ((ObjetoAereo)objetoInsertar).ToString();
                    break;

                    //pendientes

                case TablasCartaPorte.VMX_FE_CP_MERCANCIAS:
                    valores = "SIN DEFINIR AUN";
                    break;


                case TablasCartaPorte.VMX_FE_CP_DETALLE_MERCANCIA:
                    valores = "sin definir aun";
                    break;

                case TablasCartaPorte.VMX_FE_CP_PRODUCTO:
                    valores = "sin definir aun";
                    break;

                case TablasCartaPorte.VMX_FE_CP_UBICACIONES:
                    valores = "sin definir aun";
                    break;

                case TablasCartaPorte.VMX_FE_CP_UBICACION:
                    valores = "sin definir aun";
                    break;


                case TablasCartaPorte.VMX_FE_CP_FIGURA_TRANSPORTE:
                    valores = "sin definir aun";
                    break;

                case TablasCartaPorte.VMX_FE_CP_EMBARCADOR:
                    valores = "";
                    break;

                case TablasCartaPorte.VMX_FE_CP_TRANSPORTISTA:
                    valores = "sin definir aun";
                    break;

                case TablasCartaPorte.VMX_FE_CP_PROPIETARIO:
                    valores = "sin definir aun";
                    break;

                case TablasCartaPorte.VMX_FE_CP_OPERADOR:
                    valores = "sin definir aun";
                    break;

                case TablasCartaPorte.VMX_FE_CP_NOTIFICADO:
                    valores = "sin definir aun";
                    break;


            }
          

            SqlConnection c = new SqlConnection(@"Data Source =VESDB\SQL2016; Initial Catalog =CFDI2; User id=SYSADM; Password =SYSADM;");
            c.Open();
            string sql = "INSERT INTO " + NombreTabla + " (" + CamposTabla + ")" + " VALUES("+ valores +") " +
                "SELECT Id = SCOPE_IDENTITY()";

            SqlCommand comando = new SqlCommand(sql, c)
            {
                CommandType = CommandType.Text
            };

            int IdTabla = 0;
            SqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            IdTabla = int.Parse(reader[0].ToString());
            

            return IdTabla;

            
        }


        public static DataTable ObtenerValoresConsulta(TablasCartaPorte tabla, int id = 0)
        {
            string CamposTabla = ObtenerCamposTabla(tabla);
            string NombreTabla = ObtenerNombreTabla(tabla);

            string Consulta = "SELECT " + CamposTabla + " FROM " + NombreTabla;

            if (id != 0)
            {
                switch (tabla)
                {
                    case TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL:
                        Consulta += " WHERE ID_FEDERAL = " + id;
                        break;

                    case TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR:
                        Consulta += " WHERE ID_VEHICULAR = " + id;
                        break;

                    case TablasCartaPorte.VMX_FE_CP_REMOLQUES:
                        Consulta += " WHERE ID_REMOLQUE = " + id;
                        break;


                }
            }
            SqlConnection c = new SqlConnection(@"Data Source =VESDB\SQL2016; Initial Catalog =CFDI2; User id=SYSADM; Password =SYSADM;");
            c.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(Consulta, c);
            DataTable dtValores = new DataTable();
            adaptador.Fill(dtValores);

            return dtValores ;
        }


    }
}
