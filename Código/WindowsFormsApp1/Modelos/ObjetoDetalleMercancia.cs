using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    class ObjetoDetalleMercancia
    {
        public int ID;

        public int ID_MERCANCIAS;
        public int ID_PRODUCTO;
        public decimal Cantidad;
        public string Dimensiones;
        public decimal PesoEnKg;
        public string ValorMercancia, UnidadPeso;
        public decimal PesoBruto, PesoNeto, PesoTara;
        public int NumPiezas;

        public void ActualizarIdProducto (int ID_PRODUCTO)
        {
            this.ID_PRODUCTO = ID_PRODUCTO;
        }

        public void ActualizarIdMercancias(int ID_MERCANCIAS)
        {
            this.ID_MERCANCIAS = ID_MERCANCIAS;
        }

        public override string ToString()
        {
            return  ID_MERCANCIAS+ "," + ID_PRODUCTO + "," + Cantidad + ",'" + Dimensiones + "'," + PesoEnKg + ",'" + ValorMercancia + "','" +
                UnidadPeso + "'," + PesoBruto + "," + PesoNeto + "," + PesoTara + "," + NumPiezas;
        }

    }
}
