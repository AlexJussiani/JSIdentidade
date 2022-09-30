using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JS.Core.Messages.Integration
{
    public class DeletarMovimentacaoFinanciraaIntegrationEvent : IntegrationEvent
    {
        public Guid IdConta { get; private set; }      

        public DeletarMovimentacaoFinanciraaIntegrationEvent(Guid idConta)
        {  
            IdConta = idConta;         
        }
    }
}
