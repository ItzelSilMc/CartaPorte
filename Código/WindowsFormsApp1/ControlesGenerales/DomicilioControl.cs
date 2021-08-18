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
using static WindowsFormsApp1.Modelos.EstructurasFunciones;

namespace WindowsFormsApp1
{
    public partial class DomicilioControl : UserControl
    {
        public DomicilioControl()
        {
            InitializeComponent();
        }


        public void CargarInformacionPrevia(Ubicaciones ubicacion)
        {
            TxtCalle.Text = ubicacion.dir.calle;
            TxtCodigoPostal.Text = ubicacion.dir.CodigoPostal;
            TxtNumeroExt.Text = ubicacion.dir.NumeroExterior;
            TxtNumeroInt.Text = ubicacion.dir.NumeroInterior;


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

            EstructurasFunciones.CargarComboValores(CmbColonia, Colonias);

        }
        public  ObjetoDireccion RetornarDireccion()
        {
            ObjetoDireccion dire = new ObjetoDireccion
            {
                calle = TxtCalle.Text,
                NumeroExterior = TxtNumeroExt.Text,
                NumeroInterior = TxtNumeroInt.Text,
                Estado = CmbEstado.Text,
                CodigoPostal = TxtCodigoPostal.Text,
                Localidad = CmbLocalidad.Text,
                Pais = CmbPais.Text,
                Colonia = CmbColonia.Text,


            };
            

            return dire;
        }
    }
}
