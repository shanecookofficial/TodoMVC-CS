using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TodoMVC_CS.Pages;

namespace TodoMVC_CS.Tests
{
    [TestFixture]
    public class TodoPageTests
    {
        private IWebDriver driver;
        private TodoPage todoPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            todoPage = new TodoPage(driver!);
            todoPage!.Navigate();
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }

        [Test]
        [Property("TestId", 1)]
        public void PageLoadsSuccessfully()
        {
            /*
            1. Navigate to the TodoMVC URL
            2. Verify the page title contains 'TodoMVC'
            3. Verify the header text is 'todos'
            */

            Assert.Multiple(() =>
            {
                // Navigate to the TodoMVC URL
                // Verify the page title contains 'TodoMVC'
                Assert.That(driver.Title, Does.Contain(TodoPage.TitleText));

                // Verify the header text is 'todos'
                Assert.That(todoPage.TodoHeader.Text, Is.EqualTo(TodoPage.HeaderText));
            });
        }
    }
}
