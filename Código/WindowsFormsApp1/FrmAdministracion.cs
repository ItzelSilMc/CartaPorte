using System;
using System.Windows.Forms;
using WindowsFormsApp1.Configuraciones;
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
        
        public void SetTipoGrid(TablasCartaPorte tipoTabla)
        {
            this.tipoTabla = tipoTabla;

            Control gridAUsar = new Control();
            switch(tipoTabla)
            {
                case TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL:
                    gridAUsar = new GridAutotransporte();
                    Text = Text.Replace("-", "Autotransporte federal");
                    break;

                case TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR:
                    gridAUsar = new GridIdentificacionVehicular();
                    Text = Text.Replace("-", "Identificacion vehicular");
                    break;

                case TablasCartaPorte.VMX_FE_CP_REMOLQUES:
                    gridAUsar = new  GridRemolque();
                    Text = Text.Replace("-", "Remolques");
                    break;
            }

            PnlGrid.Controls.Add(gridAUsar);
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

                case TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR:
                    FrmConfIdentificacionVehicular identi = new FrmConfIdentificacionVehicular();
                    Hide();
                    identi.ShowDialog();
                    Show();
                    break;

                case TablasCartaPorte.VMX_FE_CP_REMOLQUES:
                    FrmConfRemolque remolques = new FrmConfRemolque();
                    Hide();
                    remolques.ShowDialog();
                    Show();
                    break;


            }

        }
    }
}
