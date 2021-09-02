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
    public partial class FrmPersona : Form
    {
        public bool GuardadoExitoso = false;
        public string Tipo = "";

        public bool AbiertoDesdeConfiguracion = false;

        public FrmPersona()
        {
            InitializeComponent();
        }


        public FrmPersona(ObjetoPersona Persona)
        {
            InitializeComponent();

            LlenarInformacion(Persona);
        }

        private void LlenarInformacion(ObjetoPersona Persona)
        {
            domicilioControl1.CargarInformacionPrevia(Persona.objDireccion);

            TxtRFC.Text = Persona.RFC;
            TxtNombre.Text = Persona.Nombre;
            TxtLicencia.Text = Persona.NumLicencia;
            TxtNumeroIdentificacion.Text = Persona.NumRegistro;
            TxtResidenciaFiscal.Text = Persona.ResidenciaFiscal;

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
                    LblCodigo.Visible = true;
                    TxtCodigoTransportista.Visible = true;
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
            if(AbiertoDesdeConfiguracion)
            {
                ObjetoPersona persNueva = ObtenerInformacionPersona();

                int idDomicilio = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_DOMICILIO, persNueva.objDireccion);

              
                Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_TRANSPORTISTA, persNueva);
                
            }
            this.Close();
        }

        public ObjetoPersona ObtenerInformacionPersona()
        {
            ObjetoPersona objetoPersona = new ObjetoPersona();
            objetoPersona.objDireccion = domicilioControl1.ObtenerDireccion();
            objetoPersona.RFC = TxtRFC.Text;
            objetoPersona.Nombre = TxtNombre.Text;
            objetoPersona.NumLicencia = TxtLicencia.Text;
            objetoPersona.NumRegistro = TxtNumeroIdentificacion.Text;
            objetoPersona.ResidenciaFiscal = TxtResidenciaFiscal.Text;



            return objetoPersona;
        }
    }
}
