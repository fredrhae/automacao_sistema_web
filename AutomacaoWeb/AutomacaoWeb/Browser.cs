using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Drawing.Imaging;

namespace AutomacaoWeb
{
    public static class Browser
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static string baseUrl = "http://www.dbserver.com.br/";
        private static string evidencesFolder = "C:/Projeto/";
        private static IWebDriver webDriver = new FirefoxDriver();

        public static void Initialize()
        {
            log.Info("Inicializando browser para testar aplicação...");
            Goto("");
            MaximizeBrowser();
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            var fullUrl = baseUrl + url;
            log.Info("Carregando url: " + fullUrl);
            webDriver.Url = fullUrl;
        }

        public static void MaximizeBrowser()
        {
            log.Info("Maximizando o browser atual...");
            webDriver.Manage().Window.Maximize();
        }

        public static void TakeScreenShot()
        {

            ScrollToTop();

            log.Info("Criando a evidência de screenshot da página em teste.");
            
            Screenshot ss = ((ITakesScreenshot)webDriver).GetScreenshot();

            ss.SaveAsFile(evidencesFolder + "current_screenshot.png", ImageFormat.Png);
        }

        public static void ScrollToTop()
        {
            log.Info("Setando o scroll para a parte de cima da página...");
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.scrollTo(0, 0);");
        }

        public static void Close()
        {
            log.Info("Finalizando o teste e fechando o browser...");
            webDriver.Close();
        }
    }
}
