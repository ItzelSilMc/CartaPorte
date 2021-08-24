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

namespace WindowsFormsApp1.ControlesTerrestre
{
    public partial class RemolqueControl : UserControl
    {
        public RemolqueControl()
        {
            InitializeComponent();
        }

        public void CargarComboTipoRemolque(Dictionary<string, string> Remolques)
        {
            EstructurasFunciones.CargarComboValores(CmbTipoRemolque, Remolques);
        }

        public ObjetoRemolque ObtenerRemolque()
        {
            ObjetoRemolque objRemolque = new ObjetoRemolque
            {
                SubtipoRemolque = string.IsNullOrEmpty(CmbTipoRemolque.Text) ? "" : CmbTipoRemolque.SelectedValue.ToString(),
                PlacaRemolque = TxtPlacaRemolque.Text
            };

            return objRemolque;
        }

        public void CargarDatosPrevios(ObjetoRemolque remolque)
        {
            if (!string.IsNullOrEmpty(remolque.SubtipoRemolque))
            {
                CmbTipoRemolque.SelectedValue = remolque.SubtipoRemolque;
                TxtPlacaRemolque.Text = remolque.PlacaRemolque;

            }


        }
    }
}
