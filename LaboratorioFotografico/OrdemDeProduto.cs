using System;

namespace LaboratorioFotografico
{
    public class OrdemDeServico
    {
        private int _numeroPedido;
        private Filme _filmeCliente;
        private string _status;
        private double _valorTotal;

        public int NumeroPedido => _numeroPedido;
        public Filme FilmeCliente => _filmeCliente;
        public string Status => _status;
        public double ValorTotal => _valorTotal;

        public OrdemDeServico(int numeroPedido, Filme filme)
        {
            _numeroPedido = numeroPedido;
            _filmeCliente = filme;
            _status = "Em Fila de Espera";
            CalcularValorBase();
        }

       private void CalcularValorBase(){
            double custoFormato = _filmeCliente.Formato == "Médio Formato" ? 50.00 : 35.00;
    
            _valorTotal = custoFormato + _filmeCliente.ObterAdicionalPorTipo();
        }

        public void IniciarRevelacao()
        {
            if (_status == "Em Fila de Espera")
            {
                _status = $"Revelando no químico {_filmeCliente.ProcessoIdeal}";
                Console.WriteLine($"[Atualização Pedido #{_numeroPedido}]: Status alterado para '{_status}'.");
            }
            else
            {
                Console.WriteLine($"[Erro]: O pedido #{_numeroPedido} não pode ser iniciado.");
            }
        }

        public void FinalizarPedido()
        {
            _status = "Finalizado e Pronto para Retirada";
            Console.WriteLine($"[Atualização Pedido #{_numeroPedido}]: Status alterado para '{_status}'. Valor a pagar: R${_valorTotal:F2}");
        }
    }
}