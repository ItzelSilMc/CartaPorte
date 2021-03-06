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
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1
{
    public partial class DomicilioControl : UserControl
    {
        public DomicilioControl()
        {
            InitializeComponent();
        }


        public void CargarInformacionPrevia(ObjetoDireccion dir)
        {
            TxtCalle.Text = dir.calle;
            TxtCodigoPostal.Text = dir.CodigoPostal;
            TxtNumeroExt.Text = dir.NumeroExterior;
            TxtNumeroInt.Text = dir.NumeroInterior;
            TxtCodigoPostal.Text = dir.CodigoPostal;

            if(!string.IsNullOrEmpty(dir.Pais))
            {
                CmbPais.SelectedValue = dir.Pais;
            }
            if(!string.IsNullOrEmpty(dir.Estado))
            {
                CmbEstado.SelectedValue = dir.Estado;
            }
            if(!string.IsNullOrEmpty(dir.Municipio))
            {
                CmbMunicipio.SelectedValue = dir.Municipio;
            }
            if(!string.IsNullOrEmpty(dir.Localidad))
            {
                CmbLocalidad.SelectedValue = dir.Localidad;
            }
            



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
            Dictionary<string, string> PaisesD = new Dictionary<string, string>();

            foreach (string pais in Paises)
            {
                string[] PaisSplit = pais.Split('-');
                PaisesD.Add(PaisSplit[0].Trim(), PaisSplit[1].Trim());
            }

            Metodos.CargarComboValores(CmbPais, PaisesD);

            //CmbPais.Items.AddRange(Paises.ToArray());

        }

        private void TxtCodigoPostal_Leave(object sender, EventArgs e)
        {
            LlenarComboColonias();

        }

        private void LlenarComboColonias()
        {
            CmbColonia.Items.Clear();

            Dictionary<string, string> Colonias = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.Colonia , TxtCodigoPostal.Text);

            Metodos.CargarComboValores(CmbColonia, Colonias);

        }
        public  ObjetoDireccion ObtenerDireccion()
        {


            ObjetoDireccion dire = new ObjetoDireccion();

            dire.calle = TxtCalle.Text;
            dire.NumeroExterior = TxtNumeroExt.Text;
            dire.NumeroInterior = TxtNumeroInt.Text;
            dire.Estado = CmbEstado.SelectedValue == null ? "" : CmbEstado.SelectedValue.ToString();
            dire.CodigoPostal = TxtCodigoPostal.Text;
            dire.Localidad = CmbLocalidad.SelectedValue == null ? "" : CmbLocalidad.SelectedValue.ToString();
            dire.Pais = CmbPais.SelectedValue == null ? "" : CmbPais.SelectedValue.ToString();
            dire.Colonia = CmbColonia.SelectedValue == null ? "" : CmbColonia.SelectedValue.ToString();
            


            
            

            return dire;
        }
    }
}
