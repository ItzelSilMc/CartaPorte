using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        bool ExisteTransporteConfigurado = false;

        ObjetoAutoTransporteFederal transporteTerrestre;

        List<Ubicaciones> ListaUbicaciones = new List<Ubicaciones>();

        public FrmPrincipal()
        {
            InitializeComponent();
            INVOICE_ID = textBox3.Text;
            conn = ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString;
            BD = ConfigurationManager.AppSettings.Get("BD");
        }
        

        public FrmPrincipal(string INVOICE)
        {
            InitializeComponent();
            textBox3.Text = INVOICE;
            INVOICE_ID = textBox3.Text;
            conn = ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString;
            BD = ConfigurationManager.AppSettings.Get("BD");
            //Carga la cadena de conexión para los metodos
            Metodos.CargarConexion(conn,BD);

            DataTable dt = new DataTable();
            dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_MERCANCIAS, 1, INVOICE_ID);
            if (dt.Rows.Count > 0)
                CargarMercanciasConfiguradas(dt);
            else
                cargarMercancias();
            //cargarMercancias();
            CargarUbicaciones();
            cargarCP();
            BtnMercancia.Enabled = false;
            textPesoTotal.Text = "0";
            textPesoBruto.Text = "0";
        }

        private void dataGUbicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            frmCatalagoUbicaciones frmUbi = new frmCatalagoUbicaciones(INVOICE_ID, customerID,
                DgvUbicaciones.CurrentRow.Cells["ComboTipo"].Value.ToString().Split('-')[0].Trim(),
                DgvUbicaciones.CurrentRow.Cells["IdDomicilio"].Value.ToString());
            frmUbi.ShowDialog();
            DgvUbicaciones.Rows[e.RowIndex].Cells["IdDomicilio"].Value = frmUbi.ID;
           

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
            CmbViaEntradaSalida.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCombos();
            //BuscarUbicaciones();
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
               DgvUbicaciones.Rows.Add("03-Destino Final", "","","","","", "","","yyyy-MM-dd","");

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
                    //DgvUbicaciones.Rows.Add("", "", "", "", "", "", "","","","");
                    DgvUbicaciones.Rows.Add("02-Intermedia", "", "", "", "", "", "", "", "yyyy-MM-dd", "");

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
            //if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            //{
            //    int id = (int)DgvUbicaciones[3, e.RowIndex].Value;
            //    Ubicaciones ubicacionSeleccionada = ListaUbicaciones.Where(ubicacion => ubicacion.idUbicacion == id).FirstOrDefault();

            //    FrmUbicaciones frm = new FrmUbicaciones(CmbViaEntradaSalida.Text.Split('-')[0].Trim(), ubicacionSeleccionada, "Modificar");
            //    frm.ShowDialog();
            //}
        }

        private void DgvUbicaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.ColumnIndex == 12 && e.RowIndex>=0)
            {
                //e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                //var w = Properties.Resources.editar16.Width;
                //var h = Properties.Resources.editar16.Height;
                //var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                //var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                //e.Graphics.DrawImage(Resources.editar16,new Rectangle(x,y,w,h));
                //e.Handled = true;
            }
        }

        public void cargarMercancias()
        {
            try
            {
                INVOICE_ID = textBox3.Text;
                if (INVOICE_ID != "")
                {
                    double total = 0;
                    //DataTable dtMercancias = new DataTable();
                    dtMercancias = ObtenerMercancias(INVOICE_ID, out string Error);
                    for (int i = 0; i < dtMercancias.Rows.Count; i++)
                    {
                        string Cantidad = dtMercancias.Rows[i]["Cantidad"].ToString();
                        string Dimensiones = "";
                        if (tInterno)
                            Dimensiones = dtMercancias.Rows[i]["SHIP_DIMENSIONS"].ToString();
                        string PesoEnKG = dtMercancias.Rows[i]["PESO"].ToString();
                        string ValorMercancia = dtMercancias.Rows[i]["ValorMercancia"].ToString();
                        string IDMercancia = dtMercancias.Rows[i]["ID"].ToString();
                        string UnidadPeso = dtMercancias.Rows[i]["claveUnidad"].ToString();
                        string PesoBruto = dtMercancias.Rows[i]["pesoBruto"].ToString();
                        string PesoNeto = dtMercancias.Rows[i]["pesoNeto"].ToString();
                        string PesoTara = dtMercancias.Rows[i]["pesoTara"].ToString();
                        string NoPiezas = dtMercancias.Rows[i]["piezas"].ToString();
                        string IDDetalleMercancia = "";
                        total += Double.Parse(Cantidad);
                        dataGridView1.Rows.Add(Cantidad, Dimensiones, PesoEnKG, ValorMercancia, IDMercancia, UnidadPeso, PesoBruto, PesoNeto, PesoTara, NoPiezas, IDDetalleMercancia);

                    }
                    textTotalMercancias.Text = total.ToString();

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
                       '0' as piezas,'0' as pesoTara,'0' as pesoNeto,'0' as pesoBruto,'' as UnidadPeso 
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
                     '0' as piezas,'0' as pesoTara,'0' as pesoNeto,'0' as pesoBruto,'' as UnidadPeso 
                    FROM SHIPPER_LINE S INNER JOIN CUST_ORDER_LINE CO ON S.CUST_ORDER_LINE_NO = CO.LINE_NO 
                    AND S.CUST_ORDER_ID = CO.CUST_ORDER_ID LEFT JOIN PART P ON P.ID = CO.PART_ID 
                    LEFT JOIN SERVICE_CHARGE SC ON S.SERVICE_CHARGE_ID = SC.ID LEFT JOIN " + BD+"..VMX_FE_SERVICIOS VFS " +
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
        public void GuardarMercancias()
        {
            try
            {
                ObjetoMercancias obM = new ObjetoMercancias();
                obM.INVOICE_ID = INVOICE_ID;
                obM.NumTotalMercancia = Int32.Parse(textTotalMercancias.Text);
                obM.CargoPorTasacion = textTasacion.Text;
                obM.PesoBrutoTotal = decimal.Parse(textPesoBruto.Text);
                obM.UnidadPeso = textUnidadPeso.Text;
                obM.PesoNetoTotal = decimal.Parse(textPesoTotal.Text);



                DataTable dt = new DataTable();
                dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_MERCANCIAS, 1, INVOICE_ID);
                int i = 0;
                string IDMERCANCIA = "";
                if (dt.Rows.Count > 0)
                {
                    IDMERCANCIA = dt.Rows[0]["ID_MERCANCIAS"].ToString();
                    string sql = "DELETE FROM cfdi2..VMX_FE_CP_MERCANCIAS WHERE INVOICE_ID ='" + INVOICE_ID + "'";
                    int res = Metodos.EjecutarConsulta(sql);
                    sql = "DELETE FROM cfdi2..VMX_FE_CP_DETALLE_MERCANCIA WHERE ID_MERCANCIAS ='" + IDMERCANCIA + "'";
                    res = Metodos.EjecutarConsulta(sql);

                }
                i = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_MERCANCIAS, obM);


                if (i > 0)
                {
                    int o = 0;
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        ObjetoDetalleMercancia obD = new ObjetoDetalleMercancia();
                        obD.ID_MERCANCIAS = i;
                        obD.ID_PRODUCTO = item.Cells["IdDetalleMercancia"].Value.ToString()=="" ? 0 : Int32.Parse(item.Cells["IdDetalleMercancia"].Value.ToString());
                        obD.Cantidad = decimal.Parse(item.Cells["Cantidad"].Value.ToString());
                        obD.Dimensiones = item.Cells["Dimensiones"].Value.ToString();
                        obD.PesoEnKg = decimal.Parse(item.Cells["PesoEnKg"].Value.ToString());
                        obD.ValorMercancia = item.Cells["ValorMercancia"].Value.ToString();
                        obD.UnidadPeso = item.Cells["unidadPeso"].Value.ToString();
                        obD.PesoBruto = decimal.Parse(item.Cells["pesoBruto"].Value.ToString());
                        obD.PesoNeto = decimal.Parse(item.Cells["pesoNeto"].Value.ToString());
                        obD.PesoTara = decimal.Parse(item.Cells["pesoTara"].Value.ToString());
                        decimal de = decimal.Parse(item.Cells["numPiezas"].Value.ToString());
                        obD.NumPiezas = Decimal.ToInt32(de);
                        obD.PART_ID = item.Cells["idMercancia"].Value.ToString(); 
                        o = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_DETALLE_MERCANCIA, obD);
                    }
                    if (o > 0)
                        MessageBox.Show("Registros guardados exitosamente. Mercancias");
                }
                else
                {
                    MessageBox.Show("Problemas al registrar las mercancías");
                }
            }
            catch (Exception r)
            {

                MessageBox.Show("Problemas al guardar las mercancías. "+r.Message);
            }
           
        }
        public void CargarMercanciasConfiguradas(DataTable dt)
        {
            try
            {
                string ID_Mercancia = "";
                foreach (DataRow item in dt.Rows)
                {
                    ID_Mercancia = item["ID_MERCANCIAS"].ToString();
                    textTotalMercancias.Text = item["NumTotalMercancias"].ToString();
                    textPesoBruto.Text= item["PesoBrutoTotal"].ToString();
                    textPesoTotal.Text = item["PesoNetoTotal"].ToString();
                    textTasacion.Text = item["CargoPorTasacion"].ToString();
                    textUnidadPeso.Text = item["UnidadPeso"].ToString();
                }
                DataTable dt2 = new DataTable();
                dt2 = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_DETALLE_MERCANCIA, 1, ID_Mercancia);
                foreach (DataRow item in dt2.Rows)
                {
                    //ID_DETALLE_MERCANCIA	ID_MERCANCIAS	ID_PRODUCTO	Cantidad	Dimensiones	
                    // PesoEnKg	ValorMercancia	UnidadPeso	PesoBruto	PesoNeto	PesoTara	NumPiezas
                    string cantidad = item["Cantidad"].ToString();
                    string dimensiones = item["Dimensiones"].ToString();
                    string peso = item["PesoEnKg"].ToString();
                    string valorMercancia = item["ValorMercancia"].ToString();
                    string idMercancia = item["PART_ID"].ToString();
                    string unidadPeso = item["UnidadPeso"].ToString();
                    string pesoBruto = item["PesoBruto"].ToString();
                    string pesoNeto = item["PesoNeto"].ToString();
                    string pesoTara = item["PesoTara"].ToString();
                    string noPiezas = item["NumPiezas"].ToString();
                    string idDetalleM = item["ID_PRODUCTO"].ToString();
                    dataGridView1.Rows.Add(cantidad,dimensiones,peso,valorMercancia,idMercancia,unidadPeso,pesoBruto,pesoNeto,pesoTara,noPiezas,idDetalleM);
                    
                }
            }
            catch (Exception r)
            {

                MessageBox.Show("Problemas al cargar las mercancías. "+ r.Message);
            }
        }

        public void cargarCP()
        {
            DataTable dt = new DataTable();
            dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CARTAPORTE, 1, INVOICE_ID);
            foreach (DataRow r in dt.Rows)
            {
               
                CmbInternacional.Text = r["TransInternal"].ToString();
                CmbEntradaSalidaMercancia.Text = r["EntradaSalidaMerc"].ToString();
                CmbViaEntradaSalida.Text = r["ViaEntradaSalida"].ToString();
                TxtTotalDistRecorrida.Text = r["TotalDisRec"].ToString();
            }


        }
        public void GuardarCP()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CARTAPORTE, 1, INVOICE_ID);
                if (dt.Rows.Count > 0)
                {
                    string sql = "DELETE FROM CFDI2..VMX_FE_CARTAPORTE WHERE INVOICE_ID ='" + INVOICE_ID + "'";
                    int res = Metodos.EjecutarConsulta(sql);

                }
                ObjetoCartePorte obc = new ObjetoCartePorte();
                obc.INVOICE_ID = INVOICE_ID;
                obc.EntradaSalidaMerc = CmbEntradaSalidaMercancia.Text;
                obc.TotalDistRec = TxtTotalDistRecorrida.Text;
                obc.TransInternal = CmbInternacional.Text;
                obc.ViaEntradaSalida = CmbViaEntradaSalida.Text.Split('-')[0].Trim();
                int i = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CARTAPORTE, obc);

            }
            catch (Exception o)
            {
                if (!o.Message.Contains("formato correcto"))
                    MessageBox.Show("Problemas al guardar datos Carta Porte. " + o.Message);
                
            }
           


        }
        public void CargarUbicaciones()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_UBICACION, 1, INVOICE_ID);
                if (dt.Rows.Count <= 0)
                    DgvUbicaciones.Rows.Add("03-Destino Final", "", "", "", "", "", "", "", "yyyy-MM-dd", "");

                
                int i = 0;
                foreach (DataRow item in dt.Rows)
                {
                    DgvUbicaciones.Rows.Add(""
                     ,
                        //item["TipoEstacion"].ToString(),
                     item["RFC"].ToString(),
                     item["Nombre"].ToString(),
                     item["NumRegIdTrib"].ToString(),
                     item["ResidenciaFiscal"].ToString(),
                     item["NumEstacion"].ToString(),
                     item["NombreEstacion"].ToString(),
                     item["NavegacionTrafico"].ToString(),
                     item["FechaHora"].ToString(),
                     item["ID_DOMICILIO"].ToString()
                     );
                    
                    DgvUbicaciones.Rows[i].Cells["ComboTipo"].Value = item["TipoEstacion"].ToString().Contains("03") ? "03-Destino Final" : "02-Intermedia";
                    i++;
                }
            }
            catch (Exception r)
            {

                MessageBox.Show("Problemas al cargar las ubicaciones. "+ r.Message);
            }
            
        }
        
        public void GuardarUbicaciones()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_UBICACION, 1, INVOICE_ID);
                            
                if (dt.Rows.Count > 0)
                {
                    string sql = "DELETE FROM CFDI2..VMX_FE_CP_UBICACION WHERE INVOICE_ID ='" + INVOICE_ID + "'";
                    int res = Metodos.EjecutarConsulta(sql);
                    
                }
                foreach (DataGridViewRow item in DgvUbicaciones.Rows)
                {
                    ObjetoUbicacion Ou = new ObjetoUbicacion();
                    //item.Cells["pesoBruto"].Value.ToString()

                    Ou.TipoEstacion = item.Cells["ComboTipo"].Value.ToString().Split('-')[0].Trim();
                    Ou.RFC = item.Cells["rfc"].Value.ToString();
                    Ou.Nombre = item.Cells["nombre"].Value.ToString();
                    Ou.NumRegIdTrib = item.Cells["numRegIDTrib"].Value.ToString();
                    Ou.ResidenciaFiscal = item.Cells["residenciaFiscal"].Value.ToString();
                    Ou.NumEstacion = item.Cells["NumEstacion"].Value.ToString();
                    Ou.NombreEstacion = item.Cells["NombreEstacion"].Value.ToString();
                    Ou.NavegacionTrafico = item.Cells["NavegacionTrafico"].Value.ToString();
                    DateTime dtT = new DateTime();
                    dtT = Convert.ToDateTime(item.Cells["FechaHora"].Value.ToString());
                    Ou.FechaHora = dtT.ToString("yyyy-MM-dd");
                    Ou.ID_DOMICILIO = item.Cells["IdDomicilio"].Value.ToString();
                    Ou.INVOICE_ID = INVOICE_ID;
                    int i = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_UBICACION, Ou);

                }
               // MessageBox.Show("Ubicaciones guardadas.");
            }
            catch (Exception r)
            {
                MessageBox.Show("Problemas al guardar las ubicaciones. "+r.Message);
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCP();
            GuardarUbicaciones();
            GuardarMercancias();
        }
    }
}
