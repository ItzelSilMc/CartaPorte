using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Modelos.EstructurasFunciones;

namespace WindowsFormsApp1
{
    public partial class DomicilioControl : UserControl
    {
        public DomicilioControl()
        {
            InitializeComponent();
        }

        public void InsertarTipoDmicilio(string tipo)
        {
            label10.Text = "Domicilio " + tipo;
        }

        private void DomicilioControl_Load(object sender, EventArgs e)
        {
            CargarCombos();

        }
        private void CargarCombos()
        {
            CargarComboPaises();
        }

        private void CargarComboPaises()
        {
            List<string> Paises = Metodos.ObtenerCatalogosCFDI("Paises");

            CmbPais.Items.AddRange(Paises.ToArray());

        }

        private void TxtCodigoPostal_Leave(object sender, EventArgs e)
        {
            LlenarComboColonias();

        }

        private void LlenarComboColonias()
        {
            CmbColonia.Items.Clear();

            Dictionary<string, string> Colonias = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.Colonia , TxtCodigoPostal.Text);


            CmbColonia.DataSource = new BindingSource(Colonias, null);
            CmbColonia.DisplayMember = "Value";
            CmbColonia.ValueMember = "Key";
            

        }
    }
}
