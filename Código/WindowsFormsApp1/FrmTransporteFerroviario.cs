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

namespace WindowsFormsApp1
{
    public partial class FrmTransporteFerroviario : Form
    {
        public FrmTransporteFerroviario()
        {
            InitializeComponent();
        }

        private void FrmTransporteFerroviario_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> tipoServicio = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoServicio);
            Dictionary<string, string> DerechosPaso = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.DerechosPaso);
            Dictionary<string, string> TipoCarros = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoCarro);
            Dictionary<string, string> TipoContenedor = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoContenedor);


            CargarComboTipoServicio(tipoServicio);

            //Estos metodos cargan los combos para cada uno de los controles.
            carroControlControl1.CargarComboTipoCarro(TipoCarros);
            derechosPasoControl1.CargarComboDerechosPaso(DerechosPaso);
            contenedorFerroviarioControl1.CargarComboTipoContenedor(TipoContenedor);
        }

        private  void CargarComboTipoServicio(Dictionary<string, string> TipoServicio)
        {
            //foreach(Modelos.Catalogos  ts in TipoServicio)
            //{
            //    CmbTipoServicio.Items.Add(ts.Descripcion);
            //}

            CmbTipoServicio.DataSource = new BindingSource(TipoServicio, null);
            CmbTipoServicio.DisplayMember = "Value";
            CmbTipoServicio.ValueMember = "Key";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ObjetoTransporteFerroviario objFerroviario = new ObjetoTransporteFerroviario();

            
        }
    }
}
