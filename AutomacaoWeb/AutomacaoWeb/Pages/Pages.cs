using AutomacaoWeb;
using OpenQA.Selenium.Support.PageObjects;


namespace AutomacaoWeb
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static TopNavigationPage TopNavigation
        {
            get { return GetPage<TopNavigationPage>(); }
        }

        public static ContactPage Contact
        {
            get { return GetPage<ContactPage>(); }
        }
    }
}
