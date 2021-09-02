using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ControlesFerroviario;
using WindowsFormsApp1.ControlesGrid;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1
{
    public partial class FrmAdministracion : Form
    {
        TablasCartaPorte tipoTabla;
        public FrmAdministracion()
        {
            InitializeComponent();
        }
        
        public void SetTipoGrid(TablasCartaPorte tipoTabla )
        {
            this.tipoTabla = tipoTabla;

            Control gridAUsar;
            switch(tipoTabla)
            {
                case TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL:
                    gridAUsar = new GridAutotransporte();
                    PnlGrid.Controls.Add(gridAUsar);

                    break;

                case TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR:
                    break;

                case TablasCartaPorte.VMX_FE_CP_REMOLQUES:
                    break;
            }
        }
        

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            switch(tipoTabla)
            {
                case TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL:
                    FrmConfAutotransporte auto = new FrmConfAutotransporte();
                    Hide();
                    auto.ShowDialog();
                    Show();
                    break;


            }

        }
    }
}
