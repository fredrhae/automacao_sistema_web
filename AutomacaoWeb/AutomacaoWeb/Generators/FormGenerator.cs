using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWeb.Generators
{
    public static class FormGenerator
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static Form Generate()
        {
            log.Info("Inicializando geração de dados do preenchimento do formulário.");
            var form = new Form
            {
                Name = NameGenerator.Generate(),
                EmailAddress = EmailAddressGenerator.Generate(),
                Assunto = AssuntoGenerator.Generate(),
                Setor = SetorGenerator.Generate(),
                Mensagem = MensagemGenerator.Generate()
            };

            return form;
        }
    }

    public class Form
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Assunto { get; set; }
        public int Setor { get; set; }
        public string Mensagem { get; set; }
    }
}
