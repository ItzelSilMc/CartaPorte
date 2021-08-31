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

namespace WindowsFormsApp1.Configuraciones
{
    public partial class FrmConfRemolque : Form
    {
        Dictionary<string, string> Subtipos;
        public FrmConfRemolque()
        {
            InitializeComponent();
            Subtipos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoRemolque);

            CargarCombos();
        }
        private void CargarCombos()
        {
            remolqueControl1.CargarComboTipoRemolque(Subtipos);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
           ObjetoRemolque remolque  =  remolqueControl1.ObtenerRemolque();
            int idRemolque = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_REMOLQUES, remolque);

        }
    }
}
