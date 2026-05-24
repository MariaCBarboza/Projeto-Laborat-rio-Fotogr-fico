namespace LaboratorioFotografico
{
    public abstract class Filme
    {
        protected string _marca;
        protected int _iso;
        protected string _formato;
        protected string _processoIdeal;

        public string Marca => _marca;
        public int Iso => _iso;
        public string Formato => _formato;
        public string ProcessoIdeal => _processoIdeal;

        public Filme(string marca, int iso, string formato, string processoIdeal)
        {
            _marca = marca;
            _iso = iso;
            _formato = formato;
            _processoIdeal = processoIdeal;
        }

        public virtual double ObterAdicionalPorTipo() => 0.0;
    }
}