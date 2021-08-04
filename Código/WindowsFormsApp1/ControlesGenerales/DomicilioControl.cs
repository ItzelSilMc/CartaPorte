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
    public partial class DomicilioControl : UserControl
    {
        public DomicilioControl()
        {
            InitializeComponent();
        }

        public void InsertarTipoDmicilio(string tipo)
        {
            label10.Text = "Domicilio " + tipo;
        }
    }
}
