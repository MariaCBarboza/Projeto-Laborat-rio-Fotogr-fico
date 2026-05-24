using System;

namespace LaboratorioFotografico
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("--- Sistema do Laboratório Fotográfico ---");

            
            FilmeColorido filmeKodak = new FilmeColorido("Kodak ColorPlus", 200, "35mm", "C-41", false); 
            FilmePretoBranco filmeIlford = new FilmePretoBranco("Ilford HP5", 400, "120mm", "Rodinal");

            
            OrdemDeServico pedido1 = new OrdemDeServico(1001, filmeKodak);
            OrdemDeServico pedido2 = new OrdemDeServico(1002, filmeIlford);

            Console.WriteLine($"\nStatus inicial do pedido #{pedido1.NumeroPedido}: {pedido1.Status}");
            pedido1.IniciarRevelacao();
            pedido1.FinalizarPedido();

            Console.WriteLine($"\nStatus inicial do pedido #{pedido2.NumeroPedido}: {pedido2.Status}");
            pedido2.IniciarRevelacao();
            pedido2.FinalizarPedido();
        }
    }
}