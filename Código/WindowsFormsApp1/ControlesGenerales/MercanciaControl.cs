using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;

namespace WindowsFormsApp1
{
    public partial class MercanciaControl : UserControl
    {
        public string BienesTransp="";
        public string ClaveSTCC="";
        public string Descripcion = "";
        public string ClaveUnidad="";
        public string Unidad="";
        public string MaterialPeligroso="";
        public string CveMaterialPeligroso = "";
        public string SelEmbalaje="";
        public string DescripcionEmbalaje="";
        public string Moneda="";
        public string FraccioArancelaria="";
        public string UUIDComercioExterior="";
        public string PART_ID="";
        public MercanciaControl()
        {
            InitializeComponent();
        }

        private void MercanciaControl_Load(object sender, EventArgs e)
        {
           
        }

       public void GuardarDatos()
        {
            BienesTransp = textBienes.Text;
            //ClaveSTCC = CmbClaveSTCC.SelectedItem.ToString();
            ClaveSTCC = CmbClaveSTCC.SelectedItem == null ? CmbClaveSTCC.Text : CmbClaveSTCC.SelectedItem.ToString();
            Descripcion = TxtDescripcion.Text;
            ClaveUnidad = textClaveUnidad.Text;
            Unidad = textUnidad.Text;
            //aterialPeligroso = CmbMaterialPeligroso.SelectedItem.ToString();
            MaterialPeligroso = CmbMaterialPeligroso.SelectedItem == null ? CmbMaterialPeligroso.Text : CmbMaterialPeligroso.SelectedItem.ToString();

            CveMaterialPeligroso = MaterialPeligroso=="NO" ? "" : (CmbClaveMaterialPeligroso.SelectedItem == null ? CmbClaveMaterialPeligroso.Text : CmbClaveMaterialPeligroso.SelectedItem.ToString());
            //CveMaterialPeligroso = CmbClaveMaterialPeligroso.SelectedItem.ToString();
            //SelEmbalaje = CmbEmbalaje.SelectedItem.ToString();
            SelEmbalaje = CmbEmbalaje.SelectedItem == null ? CmbEmbalaje.Text : CmbEmbalaje.SelectedItem.ToString();
            DescripcionEmbalaje = TxtDescripcionEmbalaje.Text;
            Moneda = textMoneda.Text;
            FraccioArancelaria = textFraccion.Text;
            UUIDComercioExterior = "";
            
        }
        private void CargarComboServicioSTCC(Dictionary<string, string> ClaveSTCC)
        {
            Metodos.CargarComboValores(CmbClaveSTCC, ClaveSTCC);
        }

        private void CargarComboProdServ(List<string> ClavesProdServ)
        {
            if (ClavesProdServ.Count > 0)
            {
                CmbBienes.Items.AddRange(ClavesProdServ.ToArray());
            }
        }
        private void CargarCombosMaterialesPeligrosos(Dictionary<string, string> MaterialesPeligrosos)
        { 
            Metodos.CargarComboValores(CmbClaveMaterialPeligroso, MaterialesPeligrosos);  
        }

        private void CargarCombosEmbalaje(Dictionary<string, string> Embalajes)
        {
            Metodos.CargarComboValores(CmbEmbalaje, Embalajes);
        }
        
        public void CargarDatos(string cantidad, string descripcion, string claveUnidad, string unidad, 
            string fraccionAra, string peso, string clave, string PartID, bool existente,string valor,
            string claveSTCC ="", string MaterialPeligroso = "", string CveMaterialPeligroso = "", 
            string Embalaje = "", string DescripEmbalaje = "", string Moneda = "", string UUIDComercioExt = "")
        {
            
            textBienes.Text = clave;
            TxtDescripcion.Text = descripcion;
            TxtCantidad.Text = cantidad;
            textClaveUnidad.Text = claveUnidad;
            textUnidad.Text = unidad;
            TxtPesoEnKG.Text = peso;
            textFraccion.Text = fraccionAra;
            TxtValorMercancia.Text = valor;
            textMoneda.Text = "";
            if (existente)
            {
                CmbClaveSTCC.Text = claveSTCC;
                CmbMaterialPeligroso.Text = MaterialPeligroso;
                CmbClaveMaterialPeligroso.Text = CveMaterialPeligroso;
                CmbEmbalaje.Text = Embalaje;
                TxtDescripcionEmbalaje.Text = DescripEmbalaje;
                textMoneda.Text = Moneda;
                
            }
        }
        public void CargarCombosPrincipales( Dictionary<string, string> ClaveSTCC, Dictionary<string, string> MaterialesPeligrosos,
           Dictionary<string, string> Embalajes)
        {
            

            CargarComboServicioSTCC(ClaveSTCC);
            CargarCombosMaterialesPeligrosos(MaterialesPeligrosos);
            CargarCombosEmbalaje(Embalajes);

        }
        /// <summary>
        /// Este metodo carga los combos, son mandados desde fuera para que solo se llamen una sola vez por toda la forma.
        /// </summary>
        /// <param name="ClavesUnidad">Lista de claves de unidad que se cargaran</param>
        /// <param name="ClaveSTCC">Lista de claves STCC para cargar</param>
        public void CargarCombos(List<string> ClavesUnidad, Dictionary<string, string> ClaveSTCC,
            List<string> ClavesProdServ, Dictionary<string, string> MaterialesPeligrosos,
            Dictionary<string, string> Embalajes)
        {
            if (ClavesUnidad.Count > 0)
            {
                CmbClaveUnidad.Items.AddRange(ClavesUnidad.ToArray());
            }

            CargarComboServicioSTCC(ClaveSTCC);
            CargarComboProdServ(ClavesProdServ);
            CargarCombosMaterialesPeligrosos(MaterialesPeligrosos);
            CargarCombosEmbalaje(Embalajes);
           
        }

        private void CmbMaterialPeligroso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMaterialPeligroso.SelectedItem.ToString() == "NO"|| CmbMaterialPeligroso.SelectedItem.ToString() == "No")
            {
                CmbClaveMaterialPeligroso.Text = "";
                CmbClaveMaterialPeligroso.Enabled = false;
                CveMaterialPeligroso = "";
            }
            
        }
    }
}
