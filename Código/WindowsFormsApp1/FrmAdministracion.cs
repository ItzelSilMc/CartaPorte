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

                case TablasCartaPorte.VMX_FE_CP_OPERADOR:
                    gridAUsar = new GridPersona(TipoPersona.Operador);
                    Text = Text.Replace("-", "Operadores");
                    break;

                case TablasCartaPorte.VMX_FE_CP_NOTIFICADO:
                    gridAUsar = new GridPersona(TipoPersona.Notificado);
                    Text = Text.Replace("-"," Notificados");
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
                    FrmConfIdentificacionVehicular identificacion = new FrmConfIdentificacionVehicular();
                    Hide();
                    identificacion.ShowDialog();
                    Show();
                    break;

                case TablasCartaPorte.VMX_FE_CP_REMOLQUES:
                    FrmConfRemolque remolques = new FrmConfRemolque();
                    Hide();
                    remolques.ShowDialog();
                    Show();
                    break;

                case TablasCartaPorte.VMX_FE_CP_NOTIFICADO:
                    FrmPersona frmPersona = new FrmPersona();
                    frmPersona.SetTipo(TipoPersona.Notificado);
                    Hide();
                    frmPersona.ShowDialog();
                    Show();
                    
                    break;

                case TablasCartaPorte.VMX_FE_CP_OPERADOR:
                    FrmPersona frmpersona = new FrmPersona();
                    frmpersona.SetTipo(TipoPersona.Operador);
                    Hide();
                    frmpersona.ShowDialog();
                    Show();
                    break;


            }

            //Para refrescar el grid respectivo en caso de ser agrado un nuevo registro.

            foreach (Control control in PnlGrid.Controls)
            {
                if (control is GridAutotransporte autotransporte)
                {
                    autotransporte.RefrescarGrid();
                }
                if(control is GridIdentificacionVehicular identificacion)
                {
                    identificacion.RefrescarGrid();
                }
                if(control is GridRemolque remolque)
                {
                    remolque.RefrescarGrid();
                }
                if(control is GridPersona persona)
                {
                    persona.RefrescarGrid();
                }
            }


        }
    }
}
