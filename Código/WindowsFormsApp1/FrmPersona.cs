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
        int IdSeleccionado = 0;

        private ObjetoPersona personaPrevia;
        private ObjetoDireccion direccionPrevia;

        private bool AbiertoDesdeConfiguracion = false;

        private bool ActualizarRegistro = false;

        public FrmPersona()
        {
            InitializeComponent();
        }


        public FrmPersona(ObjetoPersona Persona)
        {
            InitializeComponent();

            LlenarInformacion(Persona);
            ActualizarRegistro = true;
            personaPrevia = Persona;
            direccionPrevia = personaPrevia.objDireccion;
        }

        public void AbrirParaSeleccionar()
        {
            AbiertoDesdeConfiguracion = true;
            CmbSeleccionar.Visible = true;
            LblTitulo.Visible = true;
            BtnGuardar.Text = "Seleccionar";
        }

        public int RetornarIdSeleccionado()
        {
            return IdSeleccionado;
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
            Text = cadenaTipo;

            // Aqui vamos a buscar las personas involucradas para meterlas al combobox
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
            
          
            if(!AbiertoDesdeConfiguracion)
            {
                if (ActualizarRegistro)
                {
                    string CadenaWhere = "";
                    switch(tipo)
                    {
                        case TipoPersona.Operador:
                            CadenaWhere = " WHERE ID_OPERADOR = " + personaPrevia.ID;
                            break;

                        case TipoPersona.Notificado:
                            CadenaWhere = " WHERE ID_NOTIFICADO = " + personaPrevia.ID;
                            break;
                    }
                    string CadenaSet = ObtenerCadenaSET();

                    if (!string.IsNullOrEmpty(CadenaSet))
                    {
                        TablasCartaPorte tabla = tipo == TipoPersona.Notificado ? TablasCartaPorte.VMX_FE_CP_NOTIFICADO : TablasCartaPorte.VMX_FE_CP_OPERADOR;
                        Metodos.ActualizarRegistro( tabla , CadenaSet + CadenaWhere);
                        GuardadoExitoso = true;
                    }
                }
                else
                {
                    ObjetoPersona persNueva = ObtenerInformacionPersona();
                    persNueva.SetTipoPersona(tipo);

                    int idDomicilio = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_DOMICILIO, persNueva.objDireccion);

                    persNueva.ActualizarDomicilio(idDomicilio);
                    TablasCartaPorte tablaInsertar = TablasCartaPorte.VMX_FE_CP_TRANSPORTISTA;



                    switch (tipo)
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
                    GuardadoExitoso = true;
                }
                
            }
            else   //Esta opcion es para seleccionar.
            {
                string key = ((KeyValuePair<string, string>)CmbSeleccionar.SelectedItem).Key;
                IdSeleccionado =   int.Parse(key);
                GuardadoExitoso = true;
            }
            this.Close();
        }
        public string ObtenerCadenaSET()
        {
            ObjetoPersona personaNueva = ObtenerInformacionPersona();
            string CadenaUpdate = " SET ";
            switch(tipo)
            {
                case TipoPersona.Notificado:
                    if (personaPrevia.RFC != personaNueva.RFC)
                        CadenaUpdate += " RFCNotificado = '" + personaNueva.RFC + "',";
                    if (personaPrevia.Nombre != personaNueva.Nombre)
                        CadenaUpdate += "NombreNotificado = '" + personaNueva.Nombre + "',";
                    if (personaPrevia.NumRegistro != personaNueva.NumRegistro)
                        CadenaUpdate += " NumRegIdTribNotificado = '" + personaNueva.NumRegistro + "',";
                    if (personaPrevia.ResidenciaFiscal != personaNueva.ResidenciaFiscal)
                        CadenaUpdate += " ResidenciaFiscalNotificado = '" + personaNueva.ResidenciaFiscal + "',";
                    break;



                case TipoPersona.Operador:
                    if (personaPrevia.RFC != personaNueva.RFC)
                        CadenaUpdate += " RFCOperador = '" + personaNueva.RFC + "',";
                    if (personaPrevia.Nombre != personaNueva.Nombre)
                        CadenaUpdate += "NombreOperador = '" + personaNueva.Nombre + "',";
                    if (personaPrevia.NumRegistro != personaNueva.NumRegistro)
                        CadenaUpdate += " NumRegIdTribOperador = '" + personaNueva.NumRegistro + "',";
                    if (personaPrevia.ResidenciaFiscal != personaNueva.ResidenciaFiscal)
                        CadenaUpdate += " ResidenciaFiscalOperador = '" + personaNueva.ResidenciaFiscal + "',";
                    if (personaPrevia.NumLicencia != personaNueva.NumLicencia)
                        CadenaUpdate += " NumLicencia = '" + personaNueva.NumLicencia + "',"; 

                    break;
            }

            return  CadenaUpdate.Length == 5 ? "" : CadenaUpdate.Substring(0, CadenaUpdate.Length-1);
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

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            TablasCartaPorte TablaElegida;
           switch(tipo)
            {
                case TipoPersona.Transportista:
                    TablaElegida = TablasCartaPorte.VMX_FE_CP_TRANSPORTISTA;
                    break;

                case TipoPersona.Operador:
                    TablaElegida = TablasCartaPorte.VMX_FE_CP_OPERADOR;
                    break;

                case TipoPersona.Notificado:
                    TablaElegida = TablasCartaPorte.VMX_FE_CP_NOTIFICADO;
                    break;

                default:
                    TablaElegida = TablasCartaPorte.VMX_FE_CP_OPERADOR;
                    break;


            }

            DataTable  TablaInfo = Metodos.ObtenerValoresConsulta(TablaElegida);
            if (TablaInfo.Rows.Count > 0)
            {
                Dictionary<string, string> Diccionario = ObtenerDiccionario(TablaInfo);

                Metodos.CargarComboValores(CmbSeleccionar, Diccionario);
            }

        }

        private Dictionary<string, string> ObtenerDiccionario(DataTable tablaInfo)
        {
            Dictionary<string, string> NuevoDiccionario = new Dictionary<string, string>();

            foreach(DataRow fila in tablaInfo.Rows)
            {
                NuevoDiccionario.Add(fila[0].ToString(), fila[1].ToString() + " | " + fila[2] + " | " + Tipo);
            }
            return NuevoDiccionario;
            
        }

        private void CmbSeleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int  IdSeleccionado = 0;
            if (CmbSeleccionar.SelectedValue != null)
            {
                string key = ((KeyValuePair<string, string>)CmbSeleccionar.SelectedItem).Key;
                IdSeleccionado = int.Parse(key);

                TablasCartaPorte tabla = tipo == TipoPersona.Operador ? TablasCartaPorte.VMX_FE_CP_OPERADOR : TablasCartaPorte.VMX_FE_CP_NOTIFICADO;
                DataTable informacion = Metodos.ObtenerValoresConsulta(tabla, IdSeleccionado);
                int IdDomicilio = int.Parse(informacion.Rows[0]["ID_DOMICILIO"].ToString());
                DataTable infoDomicilio = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_DOMICILIO, IdDomicilio);
                ObjetoDireccion direccion = Metodos.ObtenerDireccionDesdeTabla(infoDomicilio);
                
                ObjetoPersona persona = new ObjetoPersona();
                switch(tipo)
                {
                    case TipoPersona.Operador:
                        persona = Metodos.obtenerOperadorDesdeTabla(informacion);
                        break;
                    case TipoPersona.Notificado:
                        persona = Metodos.ObtenerNotificadoDesdeTabla(informacion);
                        break;
                }
                persona.objDireccion = direccion;
                LlenarInformacion(persona);
                


            }
        }
    }
}
