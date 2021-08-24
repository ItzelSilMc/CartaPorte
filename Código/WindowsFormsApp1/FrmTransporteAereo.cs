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
using static WindowsFormsApp1.Modelos.EstructurasFunciones;

namespace WindowsFormsApp1
{
    public partial class FrmTransporteAereo : Form
    {
        public bool GuardadoExitoso = false;

        public ObjetoPersona transportista;
        public  ObjetoPersona embarcador;
        
        public FrmTransporteAereo()
        {
            InitializeComponent();
        }

        private void FrmTransporteAereo_Load(object sender, EventArgs e)
        {

            Dictionary<string, string> Permisos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoPermiso);

            transporteAereoControl1.CargarComboPermisos(Permisos);

            
        }

        //private void BtnTransportista_Click(object sender, EventArgs e)
        //{
        //    FrmPersona FrmPer = new FrmPersona();
        //    FrmPer.SetTipo(TipoPersona.Transportista);
        //    FrmPer.ShowDialog();

        //    if (FrmPer.GuardadoExitoso)
        //    {
        //        transportista = FrmPer.RetornarInformacionPersona();
        //        BtnTransportista.BackColor = Color.Cyan;
        //        BtnTransportista.Text = BtnTransportista.Text.Replace("Añadir", "Modificar");
        //    }
        //}

        //private void BtnEmbarcador_Click(object sender, EventArgs e)
        //{
        //    FrmPersona FrmPer = new FrmPersona();
        //    FrmPer.SetTipo(TipoPersona.Embarcador);
        //    FrmPer.ShowDialog();

        //    BtnEmbarcador.BackColor = Color.Cyan;
        //}

        //private void BtnArrendatario_Click(object sender, EventArgs e)
        //{
        //    FrmPersona FrmPer = new FrmPersona();
        //    FrmPer.SetTipo(TipoPersona.Arrendatario);
        //    FrmPer.ShowDialog();

        //    BtnArrendatario.BackColor = Color.Cyan;
        //}

        //private void BtnPropietario_Click(object sender, EventArgs e)
        //{
        //    FrmPersona FrmPer = new FrmPersona();
        //    FrmPer.SetTipo(TipoPersona.Propietario);
        //    FrmPer.ShowDialog();

        //    BtnPropietario.BackColor = Color.Cyan;
        //}

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            if(ValidarDatosTransporteAereo())
            {
                GuardadoExitoso = true;
            }
            Close();
        }

        private bool ValidarDatosTransporteAereo()
        {
            return true;
        }

        private void botonesPersonasControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
