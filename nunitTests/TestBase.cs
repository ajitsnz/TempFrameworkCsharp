using OpenQA.Selenium;
using SampleAutomationFramework.POM;

namespace SampleAutomationFramework.nunitTests
{
    public class TestBase : TestData
    {
        public void Login(IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("ddd", "dde");
        }

    }
}
