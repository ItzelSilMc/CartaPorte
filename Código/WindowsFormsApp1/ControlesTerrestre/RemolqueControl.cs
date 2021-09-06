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
    public partial class RemolqueControl : UserControl
    {
        public string IdRemolque="";
        public RemolqueControl()
        {
            InitializeComponent();
        }
        public void CargarConfigRemolque(Dictionary<string, string> ConfigRemolques)
        {
            Metodos.CargarComboValores(comboRemolque, ConfigRemolques);
        }
        public void CargarComboTipoRemolque(Dictionary<string, string> Remolques)
        {
            Metodos.CargarComboValores(CmbTipoRemolque, Remolques);
        }

        public ObjetoRemolque ObtenerRemolque()
        {
            ObjetoRemolque objRemolque = new ObjetoRemolque
            {
                SubtipoRemolque = string.IsNullOrEmpty(CmbTipoRemolque.Text) ? "" : CmbTipoRemolque.SelectedValue.ToString(),
                PlacaRemolque = TxtPlacaRemolque.Text
            };

            return objRemolque;
        }

        public void CargarDatosPrevios(ObjetoRemolque remolque)
        {
            if (!string.IsNullOrEmpty(remolque.SubtipoRemolque))
            {
                CmbTipoRemolque.SelectedValue = remolque.SubtipoRemolque;
                TxtPlacaRemolque.Text = remolque.PlacaRemolque;

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void cargarDatos(string id,string SubTipoRem, string Placa)
        {
            IdRemolque = id;
            textTipoRemolque.Text = SubTipoRem;
            CmbTipoRemolque.SelectedItem = null;
            TxtPlacaRemolque.Text = Placa;
        }
        private void comboRemolque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRemolque.SelectedItem != null)
            {
                string rp = ((System.Collections.Generic.KeyValuePair<string, string>)comboRemolque.SelectedItem).Key;
                //MessageBox.Show("select item" + rp);
                DataTable dt = new DataTable();
                if (!string.IsNullOrEmpty(rp) || rp != "")
                    dt = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_REMOLQUES, Int32.Parse(rp));

                if (dt.Rows.Count > 0)
                {
                    IdRemolque = rp;
                    textTipoRemolque.Text = dt.Rows[0]["SubTipoRem"].ToString();
                    CmbTipoRemolque.SelectedValue = dt.Rows[0]["SubTipoRem"].ToString();
                    TxtPlacaRemolque.Text = dt.Rows[0]["Placa"].ToString();
                }
            }
        }
    }
}
