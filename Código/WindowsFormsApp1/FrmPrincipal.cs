using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using WindowsFormsApp1.Properties;
using static WindowsFormsApp1.Modelos.EstructurasEnums;


namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        bool tInterno = false;
        string customerID = "";
        string INVOICE_ID="";
        string conn ="";
        string BD = "";
        DataTable dtMercancias = new DataTable();
        public FrmPrincipal()
        {
            InitializeComponent();
            INVOICE_ID = textBox3.Text;
            conn = ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString;
            BD = ConfigurationManager.AppSettings.Get("BD");
        }
        bool ExisteTransporteConfigurado = false;

        ObjetoAutoTransporteFederal transporteTerrestre;

        List<Ubicaciones> ListaUbicaciones = new List<Ubicaciones>();

        public FrmPrincipal(string INVOICE)
        {
            InitializeComponent();
            textBox3.Text = INVOICE;
            INVOICE_ID = textBox3.Text;
            conn = ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString;
            BD = ConfigurationManager.AppSettings.Get("BD");
            cargarMercancias();
            BtnMercancia.Enabled = false;
        }

        private void dataGUbicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Formularios fr = new Formularios();
            //fr.ShowDialog();
            frmCatalagoUbicaciones frmUbi = new frmCatalagoUbicaciones(INVOICE_ID, customerID);
            frmUbi.ShowDialog();
            //DgvUbicaciones.Rows.Add("", "", "", frmUbi.ID, frmUbi.Direccion, "", "", "");
            DgvUbicaciones.Rows[e.RowIndex].Cells["idUbicacion"].Value = frmUbi.ID;
            DgvUbicaciones.Rows[e.RowIndex].Cells["Nombre"].Value = frmUbi.Direccion;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //FrmMercancias frM = new FrmMercancias(dataGridView1.CurrentRow.Cells["idMercancia"].Value.ToString(),
            //    dataGridView1.CurrentRow.Cells["unidadPeso"].Value.ToString(),
            //    dataGridView1.CurrentRow.Cells["unidadPeso"].Value.ToString());

            
            string part_id = dataGridView1.CurrentRow.Cells["idMercancia"].Value.ToString();
            FrmMercancias frM = new FrmMercancias();

            
            DataTable dt = new DataTable();
            dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_PRODUCTO, 1, part_id);
            if (dt.Rows.Count > 0)
            {
                frM = new FrmMercancias(dt, part_id);

            }
            else
            {
                IEnumerable<DataRow> ieRegistro = from fila in dtMercancias.AsEnumerable()
                                                  where fila.Field<string>("ID") == part_id
                                                  select fila;
                DataTable boundTable = ieRegistro.CopyToDataTable<DataRow>();
                frM = new FrmMercancias(boundTable);
            }


            frM.ShowDialog();
            dataGridView1.Rows[e.RowIndex].Cells["IdDetalleMercancia"].Value = frM.ID;


        }

        private void CargarCombos()
        {
            Dictionary<string, string> EntradaSalida = new Dictionary<string, string>();
            EntradaSalida.Add("Entrada", "Entrada");
            EntradaSalida.Add("Salida", "Salida");

            Metodos.CargarComboValores(CmbEntradaSalidaMercancia, EntradaSalida);

            Dictionary<string, string> TransporteInternacional = new Dictionary<string, string>();
            TransporteInternacional.Add("NO", "NO");
            TransporteInternacional.Add("SI", "SI");
            


            Metodos.CargarComboValores(CmbInternacional, TransporteInternacional);


            Dictionary<string, string> ClavesTransporte = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.ClaveTransporte);

            //foreach (Modelos.Catalogos c in ClavesTransporte)
            //{
            //    CmbViaEntradaSalida.Items.Add(c.Descripcion);
            //}

            Metodos.CargarComboValores(CmbViaEntradaSalida, ClavesTransporte);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCombos();
            BuscarUbicaciones();
        }

        private void BuscarUbicaciones()
        {
            ObjetoDireccion dirDestino = Metodos.ObtenerDireccionDestino("");


            int id = ListaUbicaciones.Count + 1;
            ListaUbicaciones.Add(new Ubicaciones()
            {
                idUbicacion = id,
                NombreEstacion = "",
                NumeroEstacion ="",
                TipoEstacion = "03-Destino Final",
                dir = dirDestino
            });


            if(!string.IsNullOrEmpty( dirDestino.calle))
            {
               DgvUbicaciones.Rows.Add("03-Destino Final", "", "","","","","", "");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnUbicacionNueva_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CmbViaEntradaSalida.Text)&& !string.IsNullOrEmpty(INVOICE_ID))
            {
                ////FrmUbicaciones ubi = new FrmUbicaciones();
                //// -- Funcional
                //FrmUbicaciones ubi = new FrmUbicaciones(CmbViaEntradaSalida.Text.Split('-')[0].Trim());
                //ubi.ShowDialog();

                //if (ubi.GuardadoCorrectamente)
                //{
                //    Ubicaciones ubicacionNueva = ubi.ObtenerUbicacion();
                //    //añadir al grid.
                //   // DgvUbicaciones.Rows.Add("", "", "", "");
                //}
                

                CargarDatos(out string MsgError);
                if (MsgError != "")
                    MessageBox.Show("Problemas al cargar los datos: " + MsgError);
                else
                {
                   DgvUbicaciones.Rows.Add("", "", "", "", "", "", "", "");

                }



            }
            else
            {
                MessageBox.Show("Selecciona una vía de entrada salida primero y agrega una Factura", "Carta Porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnConfigurarTransporte_Click(object sender, EventArgs e)
        {
            // Se va a poner dependiente del tipo de transporte

            //FrmTransporteFerroviario tf = new FrmTransporteFerroviario();
            //tf.ShowDialog();

            INVOICE_ID = textBox3.Text;
            if (CmbViaEntradaSalida.Text.Length > 0)
            {

                //01  Autotransporte Federal
                //02  Transporte Marítimo
                //03  Transporte Aéreo
                //04  Transporte Ferroviario

                bool guardadoCorrectamente = false;
                switch (CmbViaEntradaSalida.Text.Split('-')[0].Trim())
                {
                    case "01":
                        if (INVOICE_ID == "")
                        {
                            MessageBox.Show("Añade una factura para continuar");
                        }
                        else
                        {

                            FrmTransporteTerrestre tt = new FrmTransporteTerrestre(INVOICE_ID);
                            if (ExisteTransporteConfigurado)
                            {
                                tt.CargarDatosPrevios(transporteTerrestre);
                            }
                            tt.ShowDialog();

                            
                            //FrmTransporteTerrestre tt = new FrmTransporteTerrestre();
                            //if (ExisteTransporteConfigurado)
                            //{
                            //    tt.CargarDatosPrevios(transporteTerrestre);
                            //}
                            //tt.ShowDialog();

                            //if (tt.GuardadoCorrectamente)
                            //{
                            //    guardadoCorrectamente = true;
                            //    transporteTerrestre = tt.ObtenerInfoTransporteTerreste();
                            //    ExisteTransporteConfigurado = true;
                            //}
                        }
                        
                        break;

                    case "02":
                        FrmTransporteMaritimo tm = new FrmTransporteMaritimo();
                        tm.ShowDialog();
                        break;

                    case "03":
                        FrmTransporteAereo ta = new FrmTransporteAereo();
                        ta.ShowDialog();
                        break;

                    case "04":
                        FrmTransporteFerroviario tf = new FrmTransporteFerroviario();
                        tf.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("No hay configuración para ese tipo de transporte", "Carta Porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                if (guardadoCorrectamente)
                {
                    BtnConfigurarTransporte.Text = BtnConfigurarTransporte.Text.Replace("Configurar", "Modificar");
                    BtnConfigurarTransporte.BackColor = Color.Cyan;
                }
            }
            else
            {
                MessageBox.Show("Seleccione la via de entrada salida", "Carta Porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TxtTotalDistRecorrida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permite un punto decimal.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DgvUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                int id = (int)DgvUbicaciones[3, e.RowIndex].Value;
                Ubicaciones ubicacionSeleccionada = ListaUbicaciones.Where(ubicacion => ubicacion.idUbicacion == id).FirstOrDefault();

                FrmUbicaciones frm = new FrmUbicaciones(CmbViaEntradaSalida.Text.Split('-')[0].Trim(), ubicacionSeleccionada, "Modificar");
                frm.ShowDialog();



           }
        }

        private void DgvUbicaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.ColumnIndex == 7 && e.RowIndex>=0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.editar16.Width;
                var h = Properties.Resources.editar16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.editar16,new Rectangle(x,y,w,h));
                e.Handled = true;
            }
        }

        public void cargarMercancias()
        {
            try
            {
                INVOICE_ID = textBox3.Text;
                if (INVOICE_ID != "")
                {
                    //DataTable dtMercancias = new DataTable();
                    dtMercancias = ObtenerMercancias(INVOICE_ID, out string Error);
                    for (int i = 0; i < dtMercancias.Rows.Count; i++)
                    {
                        string Cantidad = dtMercancias.Rows[i]["Cantidad"].ToString();
                        string Dimensiones = dtMercancias.Rows[i]["SHIP_DIMENSIONS"].ToString();
                        string PesoEnKG = dtMercancias.Rows[i]["PESO"].ToString();
                        string ValorMercancia = dtMercancias.Rows[i]["ValorMercancia"].ToString();
                        string IDMercancia = dtMercancias.Rows[i]["ID"].ToString();
                        string UnidadPeso = dtMercancias.Rows[i]["claveUnidad"].ToString();
                        string PesoBruto = dtMercancias.Rows[i]["pesoBruto"].ToString();
                        string PesoNeto = dtMercancias.Rows[i]["pesoNeto"].ToString();
                        string PesoTara = dtMercancias.Rows[i]["pesoTara"].ToString();
                        string NoPiezas = dtMercancias.Rows[i]["piezas"].ToString();
                        string IDDetalleMercancia = "";
                        dataGridView1.Rows.Add(Cantidad, Dimensiones, PesoEnKG, ValorMercancia, IDMercancia, UnidadPeso, PesoBruto, PesoNeto, PesoTara, NoPiezas, IDDetalleMercancia);

                    }

                }
                else
                {
                    MessageBox.Show("Añade una factura para continuar");
                }
            }
            catch (Exception r)
            {

                MessageBox.Show("Error al cargar mercancias: "+r.Message);
            }
        }
        private void BtnMercancia_Click(object sender, EventArgs e)
        {
            // funcional
            //FrmMercancias frmMerca = new FrmMercancias();
            //frmMerca.ShowDialog();

            cargarMercancias();

        }

        public void CargarDatos(out string Error)
        {
            DataTable dt = new DataTable();
            Error = "";
            string sql = @"SELECT I.SHIPPER_ID AS INVOICE_ID, NULL AS CUSTOMER_ID 
                FROM IBT_SHIPPER I INNER JOIN
                dbo.IBT ON I.IBT_ID = dbo.IBT.ID LEFT OUTER JOIN "+BD+"..VMX_FE_TRASLADOS V ON I.SHIPPER_ID = V.IBT_ID " +
                "where I.SHIPPER_ID = '" + INVOICE_ID + "'";
            dt = Metodos.EjecutarConsultaDT(sql);
            tInterno = true;
            //customerID = dt.Rows[0][""].ToString();
            if (dt.Rows.Count <= 0)
            {
                sql = @"SELECT  * FROM SHIPPER S INNER JOIN CUSTOMER_ORDER CO ON S.CUST_ORDER_ID = CO.ID 
                    LEFT OUTER JOIN "+BD+"..VMX_FE_TRASLADOS V ON S.PACKLIST_ID = V.IBT_ID AND CO.CUSTOMER_ID = V.CUSTOMER_ID " +
                    "INNER JOIN CUSTOMER C ON C.ID = CO.CUSTOMER_ID where S.PACKLIST_ID ='" + INVOICE_ID + "'";
                dt = Metodos.EjecutarConsultaDT(sql);
                tInterno = false;
                customerID = dt.Rows[0]["CUSTOMER_ID"].ToString();
                if (dt.Rows.Count <= 0)
                {
                    Error = "No existe el traslado";

                }
            }
            
        }
        public DataTable ObtenerMercancias(string invoice, out string Error)
        {
            try
            {
                Error = "";
                

                DataTable dt = new DataTable();
                //string BD = "CFDI2";
                CargarDatos(out Error);
                if (Error != "")
                    return null;
                string sql = "";

                sql = "SELECT * FROM " + BD + "..VMX_FE_CE_PARAMETROS";
                dt = Metodos.EjecutarConsultaDT(sql);
                string FRACCION = "";
                if (dt.Rows.Count > 0)
                    FRACCION = dt.Rows[0]["FRACCION"].ToString();
                sql = "SELECT CLAVPRODSERV FROM " + BD + "..VMX_FE_PARAMETROS";
                dt = Metodos.EjecutarConsultaDT(sql);
                string CLAVE = "";
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["CLAVPRODSERV"].ToString() != "" || !string.IsNullOrEmpty(dt.Rows[i]["CLAVPRODSERV"].ToString()))
                            CLAVE = dt.Rows[0]["CLAVPRODSERV"].ToString();
                    }
                }

                //FRACCION = ObtenerUnidadMedidaSATVisual(row["IBT_UM"].ToString(), out Error);
                if (tInterno) // TRASLADO INTERNO
                {
                    sql = string.Format(@"SELECT   '0' as ValorMercancia, ISL.SHIPPER_ID,ISL.SHIPPED_QTY as Cantidad,IL.PART_ID as ID , P.DESCRIPTION, 
				     IL.IBT_UM as claveUnidad, IL.IBT_UM as UNIDAD
                    , ISL.SHIP_DIMENSIONS, (CASE WHEN ISL.SHIPPING_WEIGHT IS NULL THEN 0 ELSE ISL.SHIPPING_WEIGHT END  * ISL.SHIPPED_QTY) AS PESO, 
                     CASE WHEN (SELECT STRING_VAL AS TARIFF_CODE FROM USER_DEF_FIELDS WHERE PROGRAM_ID = 'VMPRTMNT' 
	                    AND ID = '{0}' AND DOCUMENT_ID = P.ID) = ''  
                    THEN 
	                    (SELECT STRING_VAL AS TARIFF_CODE FROM USER_DEF_FIELDS WHERE PROGRAM_ID = 'VMPRTMNT' 
	                    AND ID = '{0}' AND DOCUMENT_ID = P.ID)
                    ELSE
	                    ( SELECT USER_2 FROM PART  WHERE ID =  P.ID)
                    END AS FRACCION_ARANCELARIA,
                    (SELECT STRING_VAL AS TARIFF_CODE FROM USER_DEF_FIELDS WHERE PROGRAM_ID = 'VMPRTMNT' 
	                 AND ID = '{1}' AND DOCUMENT_ID = P.ID )as CLAVE  ,'' as IDDetalle, 
                       '' as piezas,'' as pesoTara,'' as pesoNeto,'' as pesoBruto,'' as UnidadPeso 
                    FROM dbo.IBT_SHIPPER_LINE AS ISL INNER JOIN
                    dbo.IBT_LINE AS IL ON IL.IBT_ID = ISL.IBT_ID AND IL.LINE_NO = ISL.IBT_LINE_NO INNER JOIN
                    dbo.PART AS P ON P.ID = IL.PART_ID
                    WHERE ISL.SHIPPER_ID = '" + INVOICE_ID + "'", FRACCION, CLAVE);
                    dt = Metodos.EjecutarConsultaDT(sql);
                }
                else
                {
                    sql = string.Format(@"SELECT (S.SHIPPED_QTY * S.UNIT_PRICE) as ValorMercancia, S.SHIPPED_QTY as Cantidad,P.ID, SC.DESCRIPTION as 'Descripcion',
                        (CASE WHEN S.SHIPPING_WEIGHT IS NULL THEN 0 ELSE S.SHIPPING_WEIGHT END  * S.SHIPPED_QTY) AS PESO,  P.Description,
                        CASE WHEN P.ID = '' OR P.ID IS NULL 
                        THEN VFS.UNIDAD_MEDIDA
                        ELSE 
                        P.STOCK_UM
                        END AS claveUnidad
                         , P.STOCK_UM AS UNIDAD, 
                         CASE WHEN (SELECT STRING_VAL AS TARIFF_CODE FROM USER_DEF_FIELDS WHERE PROGRAM_ID = 'VMPRTMNT' 
	                        AND ID = '{0}' AND DOCUMENT_ID = P.ID) = ''  
                        THEN 
	                        (SELECT STRING_VAL AS TARIFF_CODE FROM USER_DEF_FIELDS WHERE PROGRAM_ID = 'VMPRTMNT' 
	                        AND ID = '{0}' AND DOCUMENT_ID = P.ID)
                        ELSE
	                        ( SELECT USER_2 FROM PART  WHERE ID =  P.ID)
                        END AS FRACCION_ARANCELARIA ,
                    ( SELECT STRING_VAL AS TARIFF_CODE FROM USER_DEF_FIELDS WHERE PROGRAM_ID = 'VMPRTMNT' 
	                    AND ID = '{1}' AND DOCUMENT_ID = P.ID) as CLAVE ,'' as IDDetalle  ,
                    '' as piezas,'' as pesoTara,'' as pesoNeto,'' as pesoBruto,'' as UnidadPeso 
                    FROM SHIPPER_LINE S INNER JOIN CUST_ORDER_LINE CO ON S.CUST_ORDER_LINE_NO = CO.LINE_NO 
                    AND S.CUST_ORDER_ID = CO.CUST_ORDER_ID LEFT JOIN PART P ON P.ID = CO.PART_ID 
                    LEFT JOIN SERVICE_CHARGE SC ON S.SERVICE_CHARGE_ID = SC.ID LEFT JOIN "+BD+"..VMX_FE_SERVICIOS VFS " +
                    "ON SC.ID = VFS.SERVICE_CHARGE_ID WHERE PACKLIST_ID = '" + INVOICE_ID + "' and SHIPPED_QTY > 0", FRACCION, CLAVE);
                    dt = Metodos.EjecutarConsultaDT(sql);
                }
                Error = "";
                return dt;
            }
            catch (Exception e)
            {

                Error = e.Message;
                return null;
            }
        
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            FrmConfiguraciones frm = new FrmConfiguraciones();
            frm.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            INVOICE_ID = textBox3.Text;

        }
    }
}
