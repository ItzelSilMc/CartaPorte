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
    public partial class IdentificacionVehicularControl : UserControl
    {
        public string IdVehicular = "";
        public IdentificacionVehicularControl()
        {
            InitializeComponent();
        }



        public void AcomodarEnNuevoModificacion()
        {
            label5.Visible = false;
            comboVehiculo.Visible = false;
            textconfVehiculo.Visible = false;

            CmbConfigVehicular.Visible = true;
            

            foreach (Control control in GBIdentificacion.Controls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y - 30);
            }
            GBIdentificacion.Size = new Size(573, 85);


        }
        public void CargarConfigVehicular(Dictionary<string, string> configVehicular)
        {
            Metodos.CargarComboValores(comboVehiculo, configVehicular);
        }
        public void CargarComboConfigVehicular(Dictionary<string, string> ConfiguracionesVehiculares)
        {
            Metodos.CargarComboValores(CmbConfigVehicular, ConfiguracionesVehiculares);
        }

        public ObjetoIdentificacionVehicular ObtenerIdentificacionVehicular()
        {
            ObjetoIdentificacionVehicular objetoIdentificacion = new ObjetoIdentificacionVehicular
            {
                ConfiguracionVehicular = string.IsNullOrEmpty(CmbConfigVehicular.Text) ? "" : CmbConfigVehicular.SelectedValue.ToString(),
                PlacaVehiculo = TxtPlacaVehicular.Text,
                AñoModelo = int.Parse(TxtAñoModelo.Text),
                NumPolizaSeguro = TxtNumPoliza.Text
                
            };

            return objetoIdentificacion;
        }


        public void CargarDatosPrevios(ObjetoIdentificacionVehicular identificacion)
        {
            if (!string.IsNullOrEmpty(identificacion.ConfiguracionVehicular))
            {
                CmbConfigVehicular.SelectedValue = identificacion.ConfiguracionVehicular;
            }
            TxtAñoModelo.Text = identificacion.AñoModelo.ToString();
            TxtPlacaVehicular.Text = identificacion.PlacaVehiculo;
            TxtNumPoliza.Text = identificacion.NumPolizaSeguro;
        }
        public void cargarDatos(string id,string ConfigVehicular, string PlacaVM, string AnioModeloVM,string NumPolizaSeguro)
        {
            IdVehicular = id;
            textconfVehiculo.Text = ConfigVehicular;
            CmbConfigVehicular.SelectedItem = null;
            TxtPlacaVehicular.Text = PlacaVM;
            TxtAñoModelo.Text = AnioModeloVM;
            TxtNumPoliza.Text = NumPolizaSeguro;
        }

        private void comboVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVehiculo.SelectedItem != null)
            {
                string rp = ((System.Collections.Generic.KeyValuePair<string, string>)comboVehiculo.SelectedItem).Key;

                DataTable dt = new DataTable();
                if (!string.IsNullOrEmpty(rp) || rp != "")
                    dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR, Int32.Parse(rp));

                if (dt.Rows.Count > 0)
                {
                    IdVehicular = rp;
                    textconfVehiculo.Text = dt.Rows[0]["ConfigVehicular"].ToString();
                    CmbConfigVehicular.SelectedValue = dt.Rows[0]["ConfigVehicular"].ToString();
                    TxtPlacaVehicular.Text = dt.Rows[0]["PlacaVM"].ToString();
                    TxtAñoModelo.Text = dt.Rows[0]["AnioModeloVM"].ToString();
                    TxtNumPoliza.Text = dt.Rows[0]["NumPolizaSeguro"].ToString();
                }
            }
        }
    }
}
