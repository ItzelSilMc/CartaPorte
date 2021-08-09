using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            CmbPermisoSCT.DataSource = new BindingSource(Permisos, null);
            CmbPermisoSCT.DisplayMember = "Descripcion";
            CmbPermisoSCT.ValueMember = "IdCatalogo";

        }
    }
}
