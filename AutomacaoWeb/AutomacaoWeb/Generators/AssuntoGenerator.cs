using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWeb.Generators
{
    public static class AssuntoGenerator
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly string[] ASSUNTOS = { "Candidato desenvolvedor automação", "Solicitação de orçamento", "Parabenização de campanha", "Solicitação de boleto de pagamento" };

        public static string Generate()
        {
            var assuntoEscolhido = ASSUNTOS[ASSUNTOS.Length.getRandomIndex()];
            log.Info("Assunto escolhido foi : " + assuntoEscolhido);
            return assuntoEscolhido;
        }
    }
}
