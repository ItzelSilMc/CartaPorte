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
    public partial class FrmTransporteAereo : Form
    {
        public FrmTransporteAereo()
        {
            InitializeComponent();
        }

        private void FrmTransporteAereo_Load(object sender, EventArgs e)
        {

            Dictionary<string, string> Permisos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoPermiso);

            transporteAereoControl1.CargarComboPermisos(Permisos);

            
        }
    }
}
