using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static WindowsFormsApp1.Modelos.EstructurasFunciones;

namespace WindowsFormsApp1
{
    public partial class FrmMercancias : Form
    {
        public FrmMercancias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNumTotalMercancias_Leave(object sender, EventArgs e)
        {
            int NumeroMercancias = int.Parse(TxtNumTotalMercancias.Text);

            int PosicionX = 0;
            int PosicionY = 0;

            int total = PNMercancias.Controls.Count;
            for (int i = 0; i < total; i++)
            {
                PNMercancias.Controls.RemoveAt(0);
            }

            // Obtener informacion de todos los catalogos

            List<string> ClavesUnidad = Metodos.ObtenerCatalogosCFDI("ClaveUnidad");
            List<string> ClavesProdServ = Metodos.ObtenerCatalogosCFDI("ClaveProdServ");

            //Catalogos Carta Porte
            Dictionary<string, string> ClaveSTCC = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.ClaveProdSTCC);
            Dictionary<string, string> MaterialesPeligrosos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.MaterialPeligroso);
            Dictionary<string, string> Embalajes = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoEmbalaje);

            for (int i = 1; i <= NumeroMercancias; i++)
            {
                MercanciaControl mc = new MercanciaControl
                {
                    Location = new Point(PosicionX, PosicionY)
                };



                mc.CargarCombos(ClavesUnidad, ClaveSTCC, ClavesProdServ, MaterialesPeligrosos, Embalajes  );
                
                // Se añade el control al panel
                PNMercancias.Controls.Add(mc);

                //Se calcula la proxima localizacion del proximo control de Mercancia
                PosicionY = PosicionY + mc.Size.Height + 10;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            foreach(Control c in PNMercancias.Controls)
            {
                if(c is MercanciaControl )
                {

                }
            }
        }
    }
}
