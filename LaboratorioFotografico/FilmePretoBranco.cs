namespace LaboratorioFotografico
{
    public class FilmePretoBranco : Filme
    {
        public string ReveladorSugerido { get; private set; }

        public FilmePretoBranco(string marca, int iso, string formato, string revelador) 
            : base(marca, iso, formato, "Manual PB"){
            ReveladorSugerido = revelador;
        }

        public override double ObterAdicionalPorTipo() {
            return 10.00;
        }
    }
}