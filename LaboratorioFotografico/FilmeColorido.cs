namespace LaboratorioFotografico
{
    public class FilmeColorido : Filme
    {
       public bool PossuiCamadaRemjet { get; private set; }

        public FilmeColorido(string marca, int iso, string formato, string processo, bool remjet) 
            : base(marca, iso, formato, "C-41")
        {
           PossuiCamadaRemjet = remjet;
        }

        public override double ObterAdicionalPorTipo() 
        {
            return PossuiCamadaRemjet ? 15.00 : 0.0;
        }
    }
}
