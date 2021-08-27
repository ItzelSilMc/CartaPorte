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
    public partial class DerechosPasoControl : UserControl
    {
        public DerechosPasoControl()
        {
            InitializeComponent();
        }

        public void CargarComboDerechosPaso(Dictionary<string, string> DerechosPaso)
        {
            Metodos.CargarComboValores(CmbDerechosPaso, DerechosPaso);
        }

        public ObjetoDerechosPaso ObtenerDerechosPaso()
        {
            ObjetoDerechosPaso odp = new ObjetoDerechosPaso
            {
                DerechosPaso = CmbDerechosPaso.SelectedValue == null ? "" : CmbDerechosPaso.SelectedValue.ToString(),
                KilometrajePagado = decimal.TryParse(TxtKilometrajePagado.Text, out decimal valorConvertir) ? 0m : valorConvertir
            };



            return odp;
        }

        public void CargarValoresPrevios(ObjetoDerechosPaso objetoDerechosPaso)
        {
            if (!string.IsNullOrEmpty(objetoDerechosPaso.DerechosPaso))
            {
                CmbDerechosPaso.SelectedValue = objetoDerechosPaso.DerechosPaso;
            }
            if (objetoDerechosPaso.KilometrajePagado != 0m)
            {
                TxtKilometrajePagado.Text = objetoDerechosPaso.KilometrajePagado.ToString();
            }
        }
    }
}
