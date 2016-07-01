using AutomacaoWeb;
using OpenQA.Selenium.Support.PageObjects;


namespace AutomacaoWeb
{
    public interface IPage
    {
        void Goto();
        bool IsAt();
    }

    public abstract class Pages<T> where T : IPage, new()
    {

        private static T _instance = default(T);

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GetPage();
                }

                return _instance;
            }
        }

        public static T GetPage()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }
    }
}
