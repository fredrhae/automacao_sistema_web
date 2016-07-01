using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using AutomacaoWeb;

namespace AutomacaoWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactPage.Instance.Goto();
            ContactPage.Instance.FillContactForm();
            Browser.TakeScreenShot();
            Browser.Close();
        }
    }
}
