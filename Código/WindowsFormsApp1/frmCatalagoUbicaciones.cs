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

namespace WindowsFormsApp1
{
    public partial class frmCatalagoUbicaciones : Form
    {
        public string ID = "";
        public string Direccion = "";

        string INVOICE_ID = "", CadenaConexion = "", BD="", customer="";
        public frmCatalagoUbicaciones()
        {
            InitializeComponent();
            CadenaConexion = ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString;
            BD = ConfigurationManager.AppSettings.Get("BD");
        }

        private void dataCatalago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ////MessageBox.Show("Entro");
            ////MessageBox.Show(e.RowIndex.ToString());
            string g = dataCatalago.CurrentRow.Cells[0].Value.ToString();
            ID =  dataCatalago.CurrentRow.Cells[0].Value.ToString();
            Direccion = dataCatalago.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        public frmCatalagoUbicaciones(string invoice, string cust)
        {
            InitializeComponent();
            INVOICE_ID = invoice;
            customer = cust;
            CadenaConexion = ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString;
            BD = ConfigurationManager.AppSettings.Get("BD");
            cargarInformacion();


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
