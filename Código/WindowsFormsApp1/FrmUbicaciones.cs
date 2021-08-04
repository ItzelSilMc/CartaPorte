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
    public partial class FrmUbicaciones : Form
    {

        Size tamGB;
        Size TamVentana;
        public bool GuardadoCorrectamente = false;

        public FrmUbicaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(validacionesCorrectas())
            {
                GenerarUbicacionNueva();
                GuardadoCorrectamente = true;
                this.Close();
            }
        }

        public bool validacionesCorrectas()
        {
            return true;
        }

        public void GenerarUbicacionNueva()
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "02 Intermedia")
            {
                domicilioControl1.Visible = false;

                GBOrigen.Size = new Size(GBOrigen.Size.Width, GBOrigen.Size.Height - 300);
                Size = new Size(Size.Width, Size.Height - 200);
               
            }
            else
            {
                domicilioControl1.Visible = true;
                GBOrigen.Size = tamGB;
                Size = TamVentana;
            }
            switch(comboBox1.Text)
            {
                case "02 Intermedia":
                    break;

                case "":
                    break;
                case " ":
                    break;
            }
            textBox1.Visible = false;
            label2.Visible = false;
        }

        private void GBOrigen_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void FrmUbicaciones_Load(object sender, EventArgs e)
        {
            tamGB = GBOrigen.Size;
            TamVentana = Size;
        }
        public int ObtenerDatos()
        {
            return 1;
        }
    }
}
