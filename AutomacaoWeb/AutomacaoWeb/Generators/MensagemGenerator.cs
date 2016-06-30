using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWeb.Generators
{
    public static class MensagemGenerator
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly string MENSAGEM = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas ultrices sit amet ipsum at egestas. Suspendisse nec tempus velit. Vestibulum luctus arcu vitae metus posuere, ac suscipit urna consectetur. Donec risus velit, tempus ut sapien malesuada, pellentesque feugiat felis. Cras eu nisi suscipit, consectetur lorem id, vulputate nibh. Nullam eget ligula sed nunc sagittis laoreet. Phasellus vel arcu vestibulum, lobortis dui a, lacinia tellus. Nullam nibh ipsum, pretium vel ligula et, posuere rhoncus libero. Donec tempus molestie dui quis hendrerit. Aenean vitae commodo turpis, id molestie nisi. Vestibulum ullamcorper, dolor nec luctus vulputate, quam leo laoreet libero, in finibus purus sapien ut lorem. Quisque velit tellus, malesuada ac lorem vitae, bibendum congue lorem.";

        public static string Generate()
        {
            log.Info("Mensagem padrão gerada");
            return MENSAGEM;
        }
    }
}
