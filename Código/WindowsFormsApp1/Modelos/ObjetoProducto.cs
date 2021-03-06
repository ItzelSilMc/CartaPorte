using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    class ObjetoProducto
    {
        public int ID;

        public string BienesTransp, ClaveSTCC, Descripcion, ClaveUnidad, Unidad, MaterialPeligroso, CveMaterialPeligroso,
            Embalaje, DescripcionEmbalaje, Moneda, FraccioArancelaria, UUIDComercioExterior, PART_ID;


        public override string ToString()
        {
            return "'" + BienesTransp + "','" + ClaveSTCC + "','" + Descripcion + "','" + ClaveUnidad + "','" + Unidad  +
                "','" + MaterialPeligroso + "','" + CveMaterialPeligroso + "','" + Embalaje + "','" + DescripcionEmbalaje +
                "','" + Moneda + "','" + FraccioArancelaria + "','" + UUIDComercioExterior + "','" +
                PART_ID + "'"; 
        }
    }
}
