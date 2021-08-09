using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPersona : Form
    {

        string Tipo = "";

        public FrmPersona()
        {
            InitializeComponent();
        }

        public  void SetTipo(string Tipo)
        {
            this.Tipo = Tipo;
            this.Text = Tipo;
            LblRFC.Text = LblRFC.Text.Replace("-", Tipo);
            LblNombre.Text = LblNombre.Text.Replace("-", Tipo);
        }


        public bool validarDatos()
        {
            return true;
        }

        public string RetornarInformacion()
        {
            return Tipo;
        }

    }
}
