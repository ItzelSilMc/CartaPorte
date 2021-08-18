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
            EstructurasFunciones.CargarComboValores(CmbClaveSTCC, ClaveSTCC);
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
            EstructurasFunciones.CargarComboValores(CmbClaveMaterialPeligroso, MaterialesPeligrosos);  
        }

        private void CargarCombosEmbalaje(Dictionary<string, string> Embalajes)
        {
            EstructurasFunciones.CargarComboValores(CmbEmbalaje, Embalajes);
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
    }
}
