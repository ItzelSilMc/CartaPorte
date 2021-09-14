using WindowsFormsApp1.Modelos;

namespace WindowsFormsApp1
{
    public class Ubicaciones
    {
        public int idUbicacion;
        public string TipoEstacion, NumeroEstacion, NombreEstacion;
        public ObjetoDireccion dir;

        public override string ToString()
        {
            return "'"+TipoEstacion + "','" + NumeroEstacion + "', '" + NombreEstacion + "'" ;
        }
    }
}