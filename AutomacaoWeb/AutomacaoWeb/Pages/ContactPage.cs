using AutomacaoWeb;
using AutomacaoWeb.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace AutomacaoWeb
{
    public class ContactPage : Pages<ContactPage>, IPage
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement nameTextField;

        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement emailAddressTextField;

        [FindsBy(How = How.Id, Using = "textAssunto")]
        private IWebElement assuntoTextField;

        [FindsBy(How = How.Id, Using = "setor")]
        private IWebElement setorSelector;

        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement messageTextField;


        public void Goto()
        {
            TopNavigationPage.Instance.Contact();
        }

        public bool IsAt()
        {
            var isAtContact = Browser.Driver.FindElements(By.XPath("//li[.='Contato']")).Count == 1;

            return isAtContact;
        }

        public void FillContactForm()
        {
            if(IsAt())
            {
                log.Info("Página de teste atual é Contato, inicializando teste de formulário...");

                var form = FormGenerator.Generate();

                log.Info("Setando dados do formulário nos campos da página de contato...");
                nameTextField.SendKeys(form.Name);
                emailAddressTextField.SendKeys(form.EmailAddress);
                assuntoTextField.SendKeys(form.Assunto);
                var seletor = new SelectElement(setorSelector);
                seletor.SelectByIndex(form.Setor);
                messageTextField.SendKeys(form.Mensagem);
            }
            else
            {
                log.Error("Página de contato não foi carregada corretamente.");
            }
        }
    }
}
