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

namespace WindowsFormsApp1.Configuraciones
{
    public partial class FrmConfRemolque : Form
    {
        Dictionary<string, string> Subtipos;

        ObjetoRemolque objetoPrevio;
        ObjetoRemolque remolque;
        bool CargadoParaActualizar = false;


        public FrmConfRemolque()
        {
            Inicializar();
        }
        public FrmConfRemolque(ObjetoRemolque remolque)
        {
            Inicializar();
            this.remolque = remolque;
            CargarDatosPrevios();
        }


        private void Inicializar()
        {
            InitializeComponent();
            Subtipos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoRemolque);

            CargarCombos();
        }

        private void CargarDatosPrevios()
        {
           
            remolqueControl1.CargarDatosPrevios(remolque);
        }
        

        public void PrepararParaActualizar()
        {
            CargadoParaActualizar = true;
            objetoPrevio = remolqueControl1.ObtenerRemolque();   
        }
        private void CargarCombos()
        {
            remolqueControl1.CargarComboTipoRemolque(Subtipos);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string CadenaWhere = " WHERE ID_REMOLQUE = " + remolque.ID;
            remolque = remolqueControl1.ObtenerRemolque();
            if (!CargadoParaActualizar)
            {
                
                int idRemolque = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_REMOLQUES, remolque);

                MessageBox.Show("Se ha guardado correctamente el remolque", "Carta porte", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
            }
            else  //es porque es para actualizar
            {
                
                string CadenaUpdate = ObtenercadenaUpdate();

                if(Metodos.ActualizarRegistro(TablasCartaPorte.VMX_FE_CP_REMOLQUES, CadenaUpdate + CadenaWhere))
                {
                    MessageBox.Show("Registro actualizado correctamente", "Carta porte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

            }

            Close();

        }
        private string ObtenercadenaUpdate()
        {
            List<string> CamposActualizados = new List<string>();
            if(objetoPrevio.SubtipoRemolque != remolque.SubtipoRemolque)
            {
                CamposActualizados.Add(" SubTipoRem = '" + remolque.SubtipoRemolque + "',");
            }

            if(objetoPrevio.PlacaRemolque != remolque.PlacaRemolque)
            {
                CamposActualizados.Add(" Placa = '" + remolque.PlacaRemolque + "',");
            }

            string cadenaSet = " SET ";
            foreach(string campo in CamposActualizados)
            {
                cadenaSet += campo;
            }
            if(CamposActualizados.Count > 0)
            {
                cadenaSet = cadenaSet.Substring(0, cadenaSet.Length - 1);

            }
            return cadenaSet;
        }
    }
}
