﻿using System;
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
    }
}
