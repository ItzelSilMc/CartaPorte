using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMercancias : Form
    {
        public FrmMercancias()
        {
            InitializeComponent();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            int NumeroMercancias = int.Parse(textBox4.Text);

            int PosicionX = 0;
            int PosicionY = 0;
            
            int total = PNMercancias.Controls.Count;
            for(int i =0; i< total; i++)
            {
                PNMercancias.Controls.RemoveAt(0);
            } 

            for(int i = 1; i<= NumeroMercancias; i++)
            {
                MercanciaControl mc = new MercanciaControl
                {
                    Location = new Point(PosicionX, PosicionY)
                };

                // Se añade el control al panel
                PNMercancias.Controls.Add(mc);

                //Se calcula la proxima localizacion del proximo control de Mercancia
                PosicionY = PosicionY + mc.Size.Height + 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
