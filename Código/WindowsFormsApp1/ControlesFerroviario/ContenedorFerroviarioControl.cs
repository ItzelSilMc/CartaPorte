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

namespace WindowsFormsApp1.ControlesFerroviario
{
    public partial class ContenedorFerroviarioControl : UserControl
    {
        public ContenedorFerroviarioControl()
        {
            InitializeComponent();
        }

        public void CargarComboTipoContenedor(Dictionary<string, string> TipoContenedores)
        {
            EstructurasFunciones.CargarComboValores(CmbTipoContenedor, TipoContenedores);
        }


        public void CargarDatosPrevios(ObjetoContenedorFerroviario contenedor)
        {
            if (!string.IsNullOrEmpty(contenedor.TipoContenedor))
            {
                CmbTipoContenedor.SelectedValue = contenedor.TipoContenedor;
            }

            if(contenedor.PesoContenedorVacio != 0m)
            {
                TxtPesoContenedorVacio.Text = contenedor.PesoContenedorVacio.ToString();
            }
            if(contenedor.PesoNetoMercancia != 0m)
            {
                TxtPesoNetoMercancia.Text = contenedor.PesoNetoMercancia.ToString();
            }
        }

        public ObjetoContenedorFerroviario ObtenerContenedorFerroviario()
        {
            ObjetoContenedorFerroviario contenedor = new ObjetoContenedorFerroviario();
            contenedor.TipoContenedor = CmbTipoContenedor.SelectedValue == null ? "" : CmbTipoContenedor.SelectedValue.ToString();
            contenedor.PesoContenedorVacio = decimal.TryParse(TxtPesoContenedorVacio.Text, out decimal ValorDecimal) ? 0m : ValorDecimal;
            contenedor.PesoNetoMercancia = decimal.TryParse(TxtPesoNetoMercancia.Text, out decimal ValorDecimal2) ? 0m : ValorDecimal2;

            return contenedor;

        }
    }
}
