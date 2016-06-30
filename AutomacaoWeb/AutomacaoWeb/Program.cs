using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using AutomacaoWeb;

namespace AutomacaoWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Browser.Initialize();
            Pages.Contact.Goto();
            Pages.Contact.FillContactForm();
            Browser.TakeScreenShot();
            Browser.Close();
        }
    }
}
