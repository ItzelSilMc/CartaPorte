using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using static WindowsFormsApp1.Modelos.EstructurasEnums;

namespace WindowsFormsApp1
{
    public partial class FrmConfAutotransporte : Form
    {
        Dictionary<string, string> Permisos ;

        ObjetoAutotransporte objetoTerrestre;
        ObjetoAutotransporte objetoPrevio;

        public bool CargadoParaActualizar = false;

        public FrmConfAutotransporte()
        {
            Inicializar();
            autotransporteFederalControl1.AcomodarEnNuevoModificacion();
            
        }

        public FrmConfAutotransporte(ObjetoAutotransporte objetoTerrestre)
        {

            Inicializar();
            this.objetoTerrestre = objetoTerrestre;

            CargarDatosPrevios();
            autotransporteFederalControl1.AcomodarEnNuevoModificacion();
        }
        public void PrepararParaActualizar()
        {
            CargadoParaActualizar = true;
            objetoPrevio = autotransporteFederalControl1.ObtenerAutotransporte();
            
            
        }
        private void Inicializar()
        {
            InitializeComponent();
            Permisos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoPermiso);
            CargarCombos();
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

            if (!CargadoParaActualizar)
            {
                Metodos.InsertarRegistroTabla(EstructurasEnums.TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL, transporte);
                MessageBox.Show("Se han guardado correctamente el transporte", "Carta porte", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                List<string> CamposActualizar = new List<string>();
                if(objetoPrevio.NombreAseguradora != transporte.NombreAseguradora )
                {
                    CamposActualizar.Add("NombreAseg = '" + transporte.NombreAseguradora + "'");
                }

                if(objetoPrevio.PermisoSCT != transporte.PermisoSCT)
                {
                    CamposActualizar.Add("PermisoSCT = '" + transporte.PermisoSCT + "'");

                }

                if(objetoPrevio.NumPermisoSCT != transporte.NumPermisoSCT)
                {
                    CamposActualizar.Add("NumPermisoSTC = "+ transporte.NumPermisoSCT + "'");

                }
                string cadenaSet  = "SET ";
                string CadenaWhere = " WHERE ID_FEDERAL = " + objetoTerrestre.ID;
                foreach(string Campo in CamposActualizar)
                {
                    cadenaSet += Campo + ",";
                }
                if(CamposActualizar.Count > 0)
                {
                    cadenaSet = cadenaSet.Substring(0, cadenaSet.Length - 1);
                    
                }

                Metodos.ActualizarRegistro(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL, cadenaSet + CadenaWhere);
            }
            Close();
        }
    }
}
 