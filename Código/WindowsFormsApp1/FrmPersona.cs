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
    public partial class FrmPersona : Form
    {

        string Tipo = "";

        public bool GuardadoExitoso = false;
        public FrmPersona()
        {
            InitializeComponent();
        }

        public  void SetTipo(TipoPersona tipo)
        {
            string cadenaTipo =  "";
            switch(tipo)
            {
                case TipoPersona.Arrendatario:
                    cadenaTipo = "Arrendatario";
                    break;

                case TipoPersona.Embarcador:
                    cadenaTipo = "Embarcador";
                    break;

                case TipoPersona.Operador:
                    cadenaTipo = "Operador";
                    break;

                case TipoPersona.Transportista:
                    cadenaTipo = "Transportista";
                    break;

                case TipoPersona.Propietario:
                    cadenaTipo = "Propietario";
                    break;


            }
            this.Tipo = cadenaTipo;
            this.Text = cadenaTipo;
            LblRFC.Text = LblRFC.Text.Replace("-", cadenaTipo);
            LblNombre.Text = LblNombre.Text.Replace("-", cadenaTipo);
        }


        public bool validarDatos()
        {
            return true;
        }

        private bool ValidacionCorrectaPersona()
        {
            return true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(ValidacionCorrectaPersona())
            {
                GuardadoExitoso = true;
            }
            this.Close();
        }

        public ObjetoPersona RetornarInformacionPersona()
        {
            ObjetoPersona objetoPersona = new ObjetoPersona();


            objetoPersona.objDireccion = domicilioControl1.RetornarDireccion();

            objetoPersona.RFC = TxtRFC.Text;
            objetoPersona.Nombre = TxtNombre.Text;
            objetoPersona.NumLicencia = TxtLicencia.Text;
            objetoPersona.NumRegistro = TxtNumeroIdentificacion.Text;



            return objetoPersona;
        }
    }
}
