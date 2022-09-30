using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JS.Core.Messages.Integration
{
    public class AdicionarMovimentacaoFinanceiraIntegrationEvent : IntegrationEvent
    {
        public Guid IdConta { get; private set; }
        public int Codigo { get; private set; }        
        public decimal Valor { get; private set; }
        public DateTime DataRegistro { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public int TipoConta { get; private set; }

        public AdicionarMovimentacaoFinanceiraIntegrationEvent(Guid idConta, int codigo, decimal valor, DateTime dataRegistro, DateTime dataPagamento, int tipoConta)
        {            
            Codigo = codigo;
            IdConta = idConta;
            Valor = valor;
            DataRegistro = dataRegistro;
            DataPagamento = dataPagamento;
            TipoConta = tipoConta;
        }
    }
}
