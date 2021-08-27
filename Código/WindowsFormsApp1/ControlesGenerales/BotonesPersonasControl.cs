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

namespace WindowsFormsApp1.ControlesGenerales
{
    public partial class BotonesPersonasControl : UserControl
    {

        private bool TransportistaCapturado,EmbarcadorCapturado,  ArrendatarioCapturado , PropietarioCapturado = false;
        public List<ObjetoPersona> ListaPersonas = new List<ObjetoPersona>();
         

        public BotonesPersonasControl()
        {
            InitializeComponent();
        }

        private void BtnTransportista_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer;
            if (TransportistaCapturado)
            {
                ObjetoPersona transportista = ListaPersonas.Where( p => p.tipoPersona == TipoPersona.Transportista).FirstOrDefault();
                ListaPersonas.Remove(transportista);

                FrmPer = new FrmPersona(transportista);
                FrmPer.SetTipo(TipoPersona.Transportista);
                FrmPer.ShowDialog();
            }
            else
            {
                FrmPer = new FrmPersona();
                FrmPer.SetTipo(TipoPersona.Transportista);
                FrmPer.ShowDialog();
            }

            if (FrmPer.GuardadoExitoso)
            {
                TransportistaCapturado = true;
                ObjetoPersona transportista = FrmPer.ObtenerInformacionPersona();
                transportista.tipoPersona = TipoPersona.Transportista;
                ListaPersonas.Add(transportista);
                BtnTransportista.BackColor = Color.Cyan;
                BtnTransportista.Text = BtnTransportista.Text.Replace("Añadir", "Modificar");
            }
        }

        private void BtnEmbarcador_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer;
            if (EmbarcadorCapturado)
            {
                ObjetoPersona embarcador = ListaPersonas.Where(p => p.tipoPersona == TipoPersona.Embarcador).FirstOrDefault();
                ListaPersonas.Remove(embarcador);

                FrmPer = new FrmPersona(embarcador);
                FrmPer.SetTipo(TipoPersona.Embarcador);
                FrmPer.ShowDialog();
            }
            else
            {
                FrmPer = new FrmPersona();
                FrmPer.SetTipo(TipoPersona.Embarcador);
                FrmPer.ShowDialog();
            }

            if (FrmPer.GuardadoExitoso)
            {
                EmbarcadorCapturado = true;
                ObjetoPersona embarcador = FrmPer.ObtenerInformacionPersona();
                embarcador.tipoPersona = TipoPersona.Embarcador;
                ListaPersonas.Add(embarcador);
                BtnEmbarcador.BackColor = Color.Cyan;
                BtnEmbarcador.Text = BtnEmbarcador.Text.Replace("Añadir", "Modificar");
            }
        }

        private void BtnArrendatario_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer;
            if (ArrendatarioCapturado)
            {
                ObjetoPersona arrendatario = ListaPersonas.Where(p => p.tipoPersona == TipoPersona.Arrendatario).FirstOrDefault();
                ListaPersonas.Remove(arrendatario);

                FrmPer = new FrmPersona(arrendatario);
                FrmPer.SetTipo(TipoPersona.Arrendatario);
                FrmPer.ShowDialog();
            }
            else
            {
                FrmPer = new FrmPersona();
                FrmPer.SetTipo(TipoPersona.Arrendatario);
                FrmPer.ShowDialog();
            }

            if (FrmPer.GuardadoExitoso)
            {
                ArrendatarioCapturado = true;
                ObjetoPersona arrendatario = FrmPer.ObtenerInformacionPersona();
                arrendatario.tipoPersona = TipoPersona.Arrendatario;
                ListaPersonas.Add(arrendatario);
                BtnArrendatario.BackColor = Color.Cyan;
                BtnArrendatario.Text = BtnArrendatario.Text.Replace("Añadir", "Modificar");
            }
        }

        private void BtnPropietario_Click(object sender, EventArgs e)
        {
            FrmPersona FrmPer;
            if (PropietarioCapturado)
            {
                ObjetoPersona propietario = ListaPersonas.Where(p => p.tipoPersona == TipoPersona.Propietario).FirstOrDefault();
                ListaPersonas.Remove(propietario);

                FrmPer = new FrmPersona(propietario);
                FrmPer.ShowDialog();
            }
            else
            {
                FrmPer = new FrmPersona();
                FrmPer.SetTipo(TipoPersona.Propietario);
                FrmPer.ShowDialog();
            }
            if (FrmPer.GuardadoExitoso)
            {
                PropietarioCapturado = true;
                ObjetoPersona propietario = FrmPer.ObtenerInformacionPersona();
                propietario.tipoPersona = TipoPersona.Propietario;
                ListaPersonas.Add(propietario);
                BtnPropietario.BackColor = Color.Cyan;
                BtnPropietario.Text = BtnPropietario.Text.Replace("Añadir", "Modificar");
                
            }

          
        }


        public List<ObjetoPersona> ObtenerPersonas()
        {
            return ListaPersonas;
        }

        private void BotonesPersonasControl_Load(object sender, EventArgs e)
        {

        }

        public void CargarDatosPrevios(List<ObjetoPersona> listaPersonas)
        {
            this.ListaPersonas = listaPersonas;
            foreach (ObjetoPersona persona in listaPersonas)
            { 
                switch(persona.tipoPersona)
                {
                    case TipoPersona.Transportista:
                        TransportistaCapturado = true;
                        BtnTransportista.BackColor = Color.Cyan;
                        BtnTransportista.Text = BtnTransportista.Text.Replace("Añadir", "Modificar");
                        break;

                    case TipoPersona.Propietario:
                        PropietarioCapturado = true;
                        BtnPropietario.BackColor = Color.Cyan;
                        BtnPropietario.Text = BtnPropietario.Text.Replace("Añadir", "Modificar");
                        break;

                    case TipoPersona.Operador:
                        
                       
                        break;

                    case TipoPersona.Embarcador:
                        EmbarcadorCapturado = true;
                        BtnEmbarcador.BackColor = Color.Cyan;
                        BtnEmbarcador.Text = BtnEmbarcador.Text.Replace("Añadir", "Modificar");
                        break;

                    case TipoPersona.Arrendatario:
                        ArrendatarioCapturado = true;
                        BtnArrendatario.BackColor = Color.Cyan;
                        BtnArrendatario.Text = BtnArrendatario.Text.Replace("Añadir", "Modificar");
                        break;
                }
               
            }
        }
    }
}
