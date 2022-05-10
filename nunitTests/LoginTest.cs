using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleAutomationFramework.Models;
using SampleAutomationFramework.nunitTests;
using SampleAutomationFramework.POM;

namespace SampleAutomationFramework.Tests
{
    [Category("Regression")]
    public class LoginTest : TestBase
    {
        IWebDriver driver;

        [SetUp]
        public void Setup() => driver = new ChromeDriver();

        [TestCase("user1@sector36.com", "user@001", "valid")]
        public void TC1(string username, string password, string status)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(username, password);

            HomePage homePage = new HomePage(driver);
            homePage.Customer.Click();
        }

        [TestCaseSource(nameof(UserLoginCSVData))]
        public void TC2(User user)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(user.Username, user.Password);

            HomePage homePage = new HomePage(driver);
            homePage.Customer.Click();
        }


        [TearDown]
        public void Cleanup()
        {
            TestContext.WriteLine("Cleanup");
            driver.Quit();
        }



    }
}
