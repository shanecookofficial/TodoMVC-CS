using OpenQA.Selenium;

namespace TodoMVC_CS.Pages
{
    public class TodoPage : BasePage
    {
        #region Constructor
        public TodoPage(IWebDriver driver) : base(driver) { }
        #endregion

        #region Constants
        protected override string Url => "https://todomvc.com/examples/react/dist/";
        public static string TitleText => "TodoMVC";
        public static string HeaderText => "todos";
        #endregion

        #region Locators
        private static readonly By TodoHeaderBy =
            By.XPath("//header/h1");
        #endregion

        #region Elements
        public IWebElement TodoHeader => Driver.FindElement(TodoHeaderBy);
        #endregion

        #region Methods
        
        #endregion
    }
}
