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
            EstructurasFunciones.CargarComboValores(CmbDerechosPaso, DerechosPaso);
        }
    }
}
