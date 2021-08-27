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

namespace WindowsFormsApp1.ControlesAereo
{
    public partial class TransporteAereoControl : UserControl
    {
        public TransporteAereoControl()
        {
            InitializeComponent();
        }

        public void CargarComboPermisos(Dictionary<string, string> Permisos)
        {
            Metodos.CargarComboValores(CmbPermisoSCT, Permisos);

        }



        public void CargarDatosPrevios()
        {

        }


    }
}
