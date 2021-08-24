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

namespace WindowsFormsApp1.ControlesTerrestre
{
    public partial class AutotransporteFederalControl : UserControl
    {
        public AutotransporteFederalControl()
        {
            InitializeComponent();
        }
        public void CargarComboPermisoSCT(Dictionary<string, string> Permisos)
        {
            EstructurasFunciones.CargarComboValores(CmbPermisoSCT, Permisos);
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
    }
}
