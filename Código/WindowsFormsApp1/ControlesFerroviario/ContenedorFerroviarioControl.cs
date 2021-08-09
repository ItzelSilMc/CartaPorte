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
    }
}
