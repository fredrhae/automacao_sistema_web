using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWeb.Generators
{
    public static class EmailAddressGenerator
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly string[] EMAILS = { "esse_e_meu_email@gmail.com", "gamer@live.com", "new_developer@dbserver.com.br", "boomer_generation@yahoo.com.br" };

        public static string Generate()
        {

            var emailEscolhido = EMAILS[EMAILS.Length.getRandomIndex()];
            log.Info("Email escolhido foi : " + emailEscolhido);
            return emailEscolhido;
        }
    }
}
