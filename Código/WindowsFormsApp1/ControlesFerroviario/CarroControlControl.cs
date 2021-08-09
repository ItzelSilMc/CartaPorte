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
    public partial class CarroControlControl : UserControl
    {
        public CarroControlControl()
        {
            InitializeComponent();
        }

        public void CargarComboTipoCarro(Dictionary<string, string> TipoCarro)
        {
            EstructurasFunciones.CargarComboValores(CmbTipoCarro, TipoCarro);
        }


        public static AutoCompleteStringCollection AutoCompletado(List<Modelos.Catalogos> coleccion)
        {
            AutoCompleteStringCollection cadenas = new AutoCompleteStringCollection();
            foreach(Modelos.Catalogos c in coleccion)
            {
                cadenas.Add(c.Descripcion);
            }
            return cadenas;
        }

        private void CarroControlControl_Load(object sender, EventArgs e)
        {
           
        }
    }

    
}
