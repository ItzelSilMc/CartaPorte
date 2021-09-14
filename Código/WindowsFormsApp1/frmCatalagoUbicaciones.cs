using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1
{
    public partial class frmCatalagoUbicaciones : Form
    {
        public string ID = "";
        public string Direccion = "";
        string tipoE = "";
        string ID_Domicilio = "";

        string INVOICE_ID = "", CadenaConexion = "", BD="", customer="";
        public frmCatalagoUbicaciones()
        {
            InitializeComponent();
            CadenaConexion = ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString;
            BD = ConfigurationManager.AppSettings.Get("BD");
        }
        public frmCatalagoUbicaciones(string invoice, string cust, string tipo, string IdUb)
        {
            InitializeComponent();
            INVOICE_ID = invoice;
            customer = cust;
            tipoE = tipo;
            CadenaConexion = ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString;
            BD = ConfigurationManager.AppSettings.Get("BD");
            
            cargarInformacion();
            if (IdUb != "")
                CargarUbicacion(IdUb);


        }
        public void CargarUbicacion(string ubicacion)
        {
            DataTable dt = new DataTable();
            dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_DOMICILIO, 1, ubicacion);
            if (dt.Rows.Count > 0)
            {
                ID_Domicilio = dt.Rows[0]["ID_DOMICILIO"].ToString();
                ID = dt.Rows[0]["ID_DOMICILIO"].ToString();
                dataUbicacion.Rows.Add(dt.Rows[0]["Calle"].ToString(), 
                    dt.Rows[0]["NumeroExterior"].ToString(),
                    dt.Rows[0]["NumeroInterior"].ToString(),
                    dt.Rows[0]["Colonia"].ToString(),
                    dt.Rows[0]["Localidad"].ToString(),
                    dt.Rows[0]["Referencia"].ToString(),
                    dt.Rows[0]["Municipio"].ToString(),
                    dt.Rows[0]["Estado"].ToString(),
                    dt.Rows[0]["Pais"].ToString(),
                    dt.Rows[0]["CodigoPostal"].ToString());
            }

        }
        private void dataCatalago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string g = dataCatalago.CurrentRow.Cells[0].Value.ToString();
                ID = dataCatalago.CurrentRow.Cells[0].Value.ToString();
                Direccion = dataCatalago.CurrentRow.Cells[1].Value.ToString();
                ID_Domicilio = "";
                dataUbicacion.Rows.Clear();
                string ADDR_1 = dataCatalago.CurrentRow.Cells["ADDR_1"].Value.ToString();
                string COUNTRY = dataCatalago.CurrentRow.Cells["COUNTRY"].Value.ToString();
                string ZIPCODE = dataCatalago.CurrentRow.Cells["ZIPCODE"].Value.ToString();
                dataUbicacion.Rows.Add(ADDR_1, "", "", "", "", "", "", "", COUNTRY, ZIPCODE);
            }
            catch (Exception r)
            {

                MessageBox.Show("Error al seleccionar la ubicación. "+ r.Message);
            }
            
            //
        }

        public void GuardarDatos()
        {
            try
            {
                if (ID_Domicilio == "")
                {
                    int i = 0;
                    foreach (DataGridViewRow item in dataUbicacion.Rows)
                    {
                        ObjetoDireccion OD = new ObjetoDireccion();
                        OD.calle = item.Cells["calle"].Value.ToString();
                        OD.NumeroExterior = item.Cells["NumExterior"].Value.ToString();
                        OD.NumeroInterior = item.Cells["NumInterior"].Value.ToString();
                        OD.Pais = item.Cells["pais"].Value.ToString();
                        OD.Estado = item.Cells["estado"].Value.ToString();
                        OD.Municipio = item.Cells["municipio"].Value.ToString();
                        OD.Ciudad = item.Cells["localidad"].Value.ToString();
                        OD.CodigoPostal = item.Cells["CP"].Value.ToString();
                        OD.Colonia = item.Cells["colonia"].Value.ToString();
                        OD.Localidad = item.Cells["localidad"].Value.ToString();
                        OD.Referencia = item.Cells["referencia"].Value.ToString();
                        OD.Tipo = tipoE;
                        i = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_DOMICILIO, OD);

                    }
                    ID = i.ToString();
                    this.Close();
                }

            }
            catch (Exception o )
            {

                MessageBox.Show("Problemas al guardar la ubicación. "+ o.Message);
            }
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
        public void cargarInformacion()
        {
            try
            {
                DataTable dt = ObtenerUbicaciones(INVOICE_ID,customer, out string MsgError);
                dataCatalago.DataSource = dt.DataSet;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string ADDR_NO = dt.Rows[i]["ADDR_NO"].ToString();
                    string NAME = dt.Rows[i]["NAME"].ToString();
                    string ADDR_1 = dt.Rows[i]["ADDR_1"].ToString();
                    string ZIPCODE = dt.Rows[i]["ZIPCODE"].ToString();
                    string COUNTRY = dt.Rows[i]["COUNTRY"].ToString();
                    dataCatalago.Rows.Add(ADDR_NO,NAME,ADDR_1,ZIPCODE,COUNTRY);

                }

            }
            catch (Exception r)
            {

                MessageBox.Show("cargarInformacion. Error:" + r.Message);
            }
        }
        public DataTable ObtenerUbicaciones(string invoice, string cust, out string Error)
        {
            try
            {
                //CargarDatos(out Error);
                Error = "";
                string customerID = cust;
                DataTable dt = new DataTable();
                
                Error = "Obteniendo datos de " + BD + "..ObtenerUbicaciones";
                string sSQL = "";
                if (string.IsNullOrEmpty(customerID))
                    sSQL = "select * from SHIPTO_ADDRESS ";
                else
                    sSQL = "select * from CUST_ADDRESS where customer_id='" + customerID + "'";

                dt = Metodos.EjecutarConsultaDT(sSQL);


                return dt;
            }
            catch (Exception e)
            {
                Error = e.Message;
                return null;

            }

        }
    }
}
