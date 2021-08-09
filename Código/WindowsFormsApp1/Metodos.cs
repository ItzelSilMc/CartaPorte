using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static WindowsFormsApp1.Modelos.EstructurasFunciones;

namespace WindowsFormsApp1
{
    public static class Metodos
    {
        public static string ObtenerCadenaCartaPorte(CatalogoCartaPorte catalogo)
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
            //Conexion.cData ObjData = new Conexion.cData(@"Data Source = VESDB\SQL2016; Initial Catalog =CFDI2; User id=SYSADM; Password =SYSADM;");
            //    ObjData.sConn = @"VESDB\SQL2016";
            //    ObjData.sUsername = "SYSADM";
            //    ObjData.sPassword = "SYSADM";
            //    ObjData.sHost = @"VESDB\SQL2016";
            //    ObjData.sDatabase = "CFDI2";

            string Catalogo = ObtenerCadenaCartaPorte(catalog);

            SqlConnection c = new SqlConnection(@"Data Source =VESDB\SQL2016; Initial Catalog =CFDI2; User id=SYSADM; Password =SYSADM;");

            c.Open();
            SqlCommand comando = new SqlCommand("VMX_FE_SP_OBTENER_CATALOGO_CP", c);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Catalogo", Catalogo);
            if(!string.IsNullOrEmpty(CodigoPostal))
            {
                comando.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
            }
            if(!string.IsNullOrEmpty(ClaveTransporte))
            {
                comando.Parameters.AddWithValue("@ClaveTransporte", ClaveTransporte);
            }

            SqlDataReader reader = comando.ExecuteReader();
            while(reader.Read())
            {
                string [] Descripcion = reader["Descripcion"].ToString().Split('-');

                Resultado.Add( Descripcion[0].Trim(), reader.GetString(0) );
            }
            c.Close();
            return Resultado;
            

        }

        public static List<string> ObtenerCatalogosCFDI(string Catalogo )
        {
            List<string> CatalogoCFDI = new List<string>();
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

            return CatalogoCFDI;
        }
    }
}
