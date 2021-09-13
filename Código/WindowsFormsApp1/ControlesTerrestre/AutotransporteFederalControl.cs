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

namespace WindowsFormsApp1.ControlesTerrestre
{
    public partial class AutotransporteFederalControl : UserControl
    {
        public string IdFederal ="";
        public AutotransporteFederalControl()
        {
            InitializeComponent();
        }
        public void CargarConfigFederal(Dictionary<string, string> cFederal)
        {
            Metodos.CargarComboValores(configFederal, cFederal);
        }
        
        

        public void CargarComboPermisoSCT(Dictionary<string, string> Permisos)
        {
            Metodos.CargarComboValores(CmbPermisoSCT, Permisos);
        }

        public void AcomodarEnNuevoModificacion()
        {
            label5.Visible = false;
            configFederal.Visible = false;
            textConfig.Visible = false;

            CmbPermisoSCT.Visible = true;

            foreach(Control control in  groupBox1.Controls)
            {
                control.Location =  new Point( control.Location.X, control.Location.Y - 30);
            }
            groupBox1.Size = new Size(597, 85);


        }


        public ObjetoAutotransporte ObtenerAutotransporte()
        {
            ObjetoAutotransporte objAutoTransporte = new ObjetoAutotransporte();
            objAutoTransporte.PermisoSCT = string.IsNullOrEmpty(CmbPermisoSCT.Text)? "": CmbPermisoSCT.SelectedValue.ToString()  ;
            objAutoTransporte.NumPermisoSCT = TxtNumeroPermisoSCT.Text;
            objAutoTransporte.NombreAseguradora = TxtNombreAseguradora.Text;
            objAutoTransporte.NumPolizaSeguro = TxtNumeroPolizaSeguro.Text;
            return objAutoTransporte;
        }
        public void CargarDatosPrevios(ObjetoAutotransporte objAuto)
        {
            if (!string.IsNullOrEmpty(objAuto.PermisoSCT))
            {
                CmbPermisoSCT.SelectedValue = objAuto.PermisoSCT;
            }
            TxtNumeroPermisoSCT.Text = objAuto.NumPermisoSCT;
            TxtNombreAseguradora.Text = objAuto.NombreAseguradora;
            TxtNumeroPolizaSeguro.Text = objAuto.NumPolizaSeguro;
           
        }

        public void cargarDatos(string id,string PermSCT, string NumPermisoSCT, string NombreAseg)
        {
            IdFederal = id;
            CmbPermisoSCT.SelectedItem = null;
            textConfig.Text = PermSCT;
            TxtNumeroPermisoSCT.Text = NumPermisoSCT;
            TxtNombreAseguradora.Text = NombreAseg;
        }
        private void configFederal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (configFederal.SelectedItem != null)
            {
                string rp = ((System.Collections.Generic.KeyValuePair<string, string>)configFederal.SelectedItem).Key;

                DataTable dt = new DataTable();
                if (!string.IsNullOrEmpty(rp) || rp != "")
                    dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL, Int32.Parse(rp));

                if (dt.Rows.Count > 0)
                {
                    IdFederal = rp;
                    textConfig.Text = dt.Rows[0]["PermSCT"].ToString();
                    CmbPermisoSCT.SelectedValue = dt.Rows[0]["PermSCT"].ToString();
                    TxtNumeroPermisoSCT.Text = dt.Rows[0]["NumPermisoSCT"].ToString();
                    TxtNombreAseguradora.Text = dt.Rows[0]["NombreAseg"].ToString();
                    TxtNumeroPolizaSeguro.Text = dt.Rows[0]["NombreAseg"].ToString();
                }
            }
            
        }
    }
}
