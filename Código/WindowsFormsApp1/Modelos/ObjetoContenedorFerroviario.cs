

namespace WindowsFormsApp1.Modelos
{
    public class ObjetoContenedorFerroviario
    {
        public string TipoContenedor;
        public decimal PesoContenedorVacio, PesoNetoMercancia;

        private int IdCarro;

        public void ActualizarIdCarro(int IdCarro)
        {
            this.IdCarro = IdCarro;
        }


        public override string ToString()
        {
            return "'"+ TipoContenedor+ "',"+PesoContenedorVacio +","+PesoNetoMercancia+ ","+ IdCarro;
        }
    }

    
}
