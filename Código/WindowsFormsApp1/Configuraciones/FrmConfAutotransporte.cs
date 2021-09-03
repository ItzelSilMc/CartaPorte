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
    public partial class FrmConfAutotransporte : Form
    {
        Dictionary<string, string> Permisos ;

        ObjetoAutotransporte objetoTerrestre;
        
        public FrmConfAutotransporte()
        {
            Inicializar();
            
        }

        private void Inicializar()
        {
            InitializeComponent();
            Permisos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoPermiso);
            CargarCombos();
        }
        public FrmConfAutotransporte(ObjetoAutotransporte objetoTerrestre)
        {

            Inicializar();
            this.objetoTerrestre = objetoTerrestre;

            CargarDatosPrevios();
        }

        private void CargarDatosPrevios()
        {
            autotransporteFederalControl1.CargarDatosPrevios(objetoTerrestre);
        }

        private void CargarCombos()
        {
            autotransporteFederalControl1.CargarComboPermisoSCT(Permisos);
           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void GuardarDatos()
        {
           
            ObjetoAutotransporte transporte = autotransporteFederalControl1.ObtenerAutotransporte();

            
            Metodos.InsertarRegistroTabla(EstructurasEnums.TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL, transporte);

            //int IdTransporte = Metodos.InsertarRegistroTabla(EstructurasEnums.TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL, transporte);


            MessageBox.Show("Se han guardado correctamente el transporte", "Carta porte", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
