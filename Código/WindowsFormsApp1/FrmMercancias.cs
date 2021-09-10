using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1
{
    public partial class FrmMercancias : Form
    {
     
        string PartID = "";
        bool Existeregistro = false;
        public string ID = "";

        string cantidad = "";
        string descripcion = "";
        string claveUnidad = "";
        string unidad = "";
        string fraccionAra = "";
        string peso = "";
        string clave = "";
        string detalle = "";
        string valor = "";


        string claveSTCC = "";
        string MaterialPeligroso = "";
        string CveMaterialPeligroso = "";
        string Embalaje = "";
        string DescripEmbalaje = "";
        string Moneda = "";
        string UUIDComercioExt = "";

        string IDProducto = "";

        public FrmMercancias()
        {
            InitializeComponent();
        }
        public FrmMercancias(DataTable dt)
        {
            InitializeComponent();
            CargaDatosExistentes(dt);

           
            
        }

        public FrmMercancias(DataTable dt, string idDetalle)
        {
            InitializeComponent();
            Existeregistro = true;
            CargaDatosExistentes(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void TxtNumTotalMercancias_Leave(object sender, EventArgs e)
        {
            int NumeroMercancias = int.Parse(TxtNumTotalMercancias.Text);

            int PosicionX = 0;
            int PosicionY = 0;

            int total = PNMercancias.Controls.Count;
            for (int i = 0; i < total; i++)
            {
                PNMercancias.Controls.RemoveAt(0);
            }

            // Obtener informacion de todos los catalogos

            List<string> ClavesUnidad = Metodos.ObtenerCatalogosCFDI("ClaveUnidad");
            List<string> ClavesProdServ = Metodos.ObtenerCatalogosCFDI("ClaveProdServ");

            //Catalogos Carta Porte
            Dictionary<string, string> ClaveSTCC = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.ClaveProdSTCC);
            Dictionary<string, string> MaterialesPeligrosos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.MaterialPeligroso);
            Dictionary<string, string> Embalajes = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoEmbalaje);

            for (int i = 1; i <= NumeroMercancias; i++)
            {
                MercanciaControl mc = new MercanciaControl
                {
                    Location = new Point(PosicionX, PosicionY)
                };
                mc.CargarCombos(ClavesUnidad, ClaveSTCC, ClavesProdServ, MaterialesPeligrosos, Embalajes  );
                
                // Se añade el control al panel
                PNMercancias.Controls.Add(mc);

                //Se calcula la proxima localizacion del proximo control de Mercancia
                PosicionY = PosicionY + mc.Size.Height + 10;
            }
        }
        public void CargaDatosExistentes(DataTable dt)
        {
            Dictionary<string, string> ClaveSTCC = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.ClaveProdSTCC);
            Dictionary<string, string> MaterialesPeligrosos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.MaterialPeligroso);
            Dictionary<string, string> Embalajes = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoEmbalaje);
            

            mercanciaControl1.CargarCombosPrincipales(ClaveSTCC, MaterialesPeligrosos, Embalajes);

            if (Existeregistro)
            {
                foreach (DataRow item in dt.Rows)
                {
                    cantidad = "";
                    descripcion = item["Descripcion"].ToString();
                    claveUnidad = item["ClaveUnidad"].ToString();
                    unidad = item["Unidad"].ToString();
                    fraccionAra = item["FraccionArancelaria"].ToString();
                    peso = "";
                    clave = item["BienesTransp"].ToString();
                    PartID = item["PART_ID"].ToString();
                    detalle = item["ID_PRODUCTO"].ToString();
                    valor = "";
                    textPartID.Text = PartID;

                    claveSTCC = item["ClaveSTCC"].ToString();
                    MaterialPeligroso = item["MaterialPeligroso"].ToString();
                    CveMaterialPeligroso = item["CveMaterialPeligroso"].ToString();
                    Embalaje = item["Embalaje"].ToString();
                    DescripEmbalaje = item["DescripEmbalaje"].ToString();
                    Moneda = item["Moneda"].ToString();
                    UUIDComercioExt = item["UUIDComercioExt"].ToString();
                    ID = detalle;
                    IDProducto = detalle;
                }
                mercanciaControl1.CargarDatos(cantidad, descripcion, claveUnidad, unidad, fraccionAra, 
                    peso, clave, PartID, Existeregistro, valor,
                    claveSTCC, MaterialPeligroso, CveMaterialPeligroso, Embalaje, DescripEmbalaje, Moneda, UUIDComercioExt);
            }
            else
            {
                foreach ( DataRow item in dt.Rows)
                {
                    ID = "";
                    cantidad = item["Cantidad"].ToString();
                    descripcion = item["Description"].ToString();
                    claveUnidad = item["claveUnidad"].ToString();
                    unidad = item["UNIDAD"].ToString();
                    fraccionAra = item["FRACCION_ARANCELARIA"].ToString();
                    peso = item["PESO"].ToString();
                    clave = item["CLAVE"].ToString();
                    PartID = item["ID"].ToString();
                    detalle = item["IDDetalle"].ToString();
                    valor = item["ValorMercancia"].ToString();
                    textPartID.Text = PartID;
                }
                mercanciaControl1.CargarDatos(cantidad, descripcion, claveUnidad, unidad, fraccionAra, peso, clave, PartID, Existeregistro, valor);
            }
           
            
            
        }
        public void GuardarDatos()
        {
            mercanciaControl1.GuardarDatos();
            ObjetoProducto ob = new ObjetoProducto();
            ob.BienesTransp = mercanciaControl1.BienesTransp;
            ob.ClaveSTCC = mercanciaControl1.ClaveSTCC.Length < 4 ? mercanciaControl1.ClaveSTCC : mercanciaControl1.ClaveSTCC.Split('-', ',')[1].Trim();
            ob.Descripcion = mercanciaControl1.Descripcion;
            ob.ClaveUnidad = mercanciaControl1.ClaveUnidad;
            ob.Unidad = mercanciaControl1.Unidad;
            ob.MaterialPeligroso = mercanciaControl1.MaterialPeligroso;
            ob.CveMaterialPeligroso = mercanciaControl1.CveMaterialPeligroso.Length < 7 ? mercanciaControl1.CveMaterialPeligroso : mercanciaControl1.CveMaterialPeligroso.Split('-', ',')[1].Trim();
            ob.Embalaje = mercanciaControl1.SelEmbalaje.Length < 7 ? mercanciaControl1.SelEmbalaje : mercanciaControl1.SelEmbalaje.Split('-', ',')[1].Trim();
            ob.DescripcionEmbalaje = mercanciaControl1.DescripcionEmbalaje;
            ob.Moneda = mercanciaControl1.Moneda;
            ob.FraccioArancelaria = mercanciaControl1.FraccioArancelaria;
            ob.UUIDComercioExterior = mercanciaControl1.UUIDComercioExterior;
            ob.PART_ID = PartID;

            if (Existeregistro)
            {
                string sql = "DELETE  FROM CFDI2..VMX_FE_CP_PRODUCTO WHERE PART_ID='" + PartID + "'";
                int o = Metodos.EjecutarConsulta(sql);

            }
            int i = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_PRODUCTO, ob);
            if (i > 0 )
            {
                MessageBox.Show("Registros guardados con éxito");
                ID = i.ToString();
                this.Close();
            }

        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
    }
}
