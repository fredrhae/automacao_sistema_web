using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWeb.Generators
{
    public static class SetorGenerator
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly int[] SETORES = { 0, 1, 2, 3, 4 };

        public static int Generate()
        {
            var setorEscolhido = SETORES[SETORES.Length.getRandomIndex()];
            log.Info("Indice do setor escolhido foi : " + setorEscolhido);
            return setorEscolhido;
        }
    }
}
