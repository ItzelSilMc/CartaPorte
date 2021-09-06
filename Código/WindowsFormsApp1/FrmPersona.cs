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
        TipoPersona tipo;

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
            this.tipo = tipo;

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

                case TipoPersona.Notificado:
                    cadenaTipo = "Notificado";
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
            if(!AbiertoDesdeConfiguracion)
            {
                ObjetoPersona persNueva = ObtenerInformacionPersona();
                persNueva.SetTipoPersona(tipo);

                int idDomicilio = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_DOMICILIO, persNueva.objDireccion);

                persNueva.ActualizarDomicilio(idDomicilio);
              TablasCartaPorte tablaInsertar = TablasCartaPorte.VMX_FE_CP_TRANSPORTISTA;



              switch(tipo)
                {
                    case TipoPersona.Transportista:
                        tablaInsertar = TablasCartaPorte.VMX_FE_CP_TRANSPORTISTA;
                        break;

                    case TipoPersona.Notificado:
                        tablaInsertar = TablasCartaPorte.VMX_FE_CP_NOTIFICADO;
                        break;

                    case TipoPersona.Operador:
                        tablaInsertar = TablasCartaPorte.VMX_FE_CP_OPERADOR;
                        break;
                }
                Metodos.InsertarRegistroTabla(tablaInsertar, persNueva);
                
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
