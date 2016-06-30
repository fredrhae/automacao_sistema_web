using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWeb.Generators
{
    public static class NameGenerator
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly string[] NAMES = { "Hidelbrando da Silva", "Steve Jobs", "Bill Gates", "Bóris Conceição"};

        public static string Generate()
        {
            var nomeEscolhido = NAMES[NAMES.Length.getRandomIndex()];
            log.Info("Nome escolhido foi : " + nomeEscolhido);
            return NAMES[NAMES.Length.getRandomIndex()];
        }
    }

}
