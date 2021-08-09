using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MercanciaControl : UserControl
    {
        public MercanciaControl()
        {
            InitializeComponent();
        }

        private void MercanciaControl_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        private void CargarCombos()
        {

        }
        private void CargarComboServicioSTCC(Dictionary<string, string> ClaveSTCC)
        {

            //foreach (Modelos.Catalogos CSTCC in ClaveSTCC)
            //{
            //    CmbClaveSTCC.Items.Add(CSTCC.Descripcion);
            //}

            CmbClaveSTCC.DataSource = new BindingSource(ClaveSTCC, null);
            CmbClaveSTCC.DisplayMember = "Value";
            CmbClaveSTCC.ValueMember = "Key";

        }
        private void CargarComboProdServ(List<string> ClavesProdServ)
        {
            
                CmbBienes.Items.AddRange(ClavesProdServ.ToArray());
            

        }
        private void CargarCombosMaterialesPeligrosos(Dictionary<string, string> MaterialesPeligrosos)
        {
            //foreach(Modelos.Catalogos mp in MaterialesPeligrosos)
            //{
            //    CmbClaveMaterialPeligroso.Items.Add(mp.Descripcion);
            //}
            CmbClaveMaterialPeligroso.DataSource = new BindingSource(MaterialesPeligrosos, null);
            CmbClaveMaterialPeligroso.DisplayMember = "Value";
            CmbClaveMaterialPeligroso.ValueMember = "Key";
        }

        private void CargarCombosEmbalaje(Dictionary<string, string> MaterialesPeligrosos)
        {
            //foreach (Modelos.Catalogos mp in MaterialesPeligrosos)
            //{
            //    CmbEmbalaje.Items.Add(mp.Descripcion);
            //}
            CmbEmbalaje.DataSource = new BindingSource(MaterialesPeligrosos, null);
            CmbEmbalaje.DisplayMember = "Value";
            CmbEmbalaje.ValueMember = "Key";
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
            CmbClaveUnidad.Items.AddRange(ClavesUnidad.ToArray());

            CargarComboServicioSTCC(ClaveSTCC);
            CargarComboProdServ(ClavesProdServ);
            CargarCombosMaterialesPeligrosos(MaterialesPeligrosos);
            CargarCombosEmbalaje(Embalajes);
           
        }
    }
}
