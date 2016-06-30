using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomacaoWeb
{
    public class TopNavigationPage
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        [FindsBy(How = How.CssSelector, Using = "[href*='contato.html")]
        private IWebElement contactLink;

        public void Contact()
        {
            log.Info("Selecionando contato na barra de navegação superior...");
            contactLink.Click();
        }

    }
}
