using OpenQA.Selenium;

namespace TodoMVC_CS.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver { get; }

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected abstract string Url { get; }

        public void Navigate()
        {
            Driver.Navigate().GoToUrl(Url);
        }
    }
}
