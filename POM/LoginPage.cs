using OpenQA.Selenium;

namespace SampleAutomationFramework.POM
{
    public class LoginPage
    {
        IWebDriver driver;

        private By _email = By.Id("email");
        private By _password = By.Id("password");
        private By _loginButton = By.XPath("//*[@id=\"app\"]/section/div/div/div/div[2]/div[2]/form/div[4]/button");

        public LoginPage(IWebDriver d) //d is coming from test class
        {
            driver = d;
            driver.Url = "http://crm.qaauto.co.nz/login";
        }

        public IWebElement Email => driver.FindElement(_email);
        public IWebElement Password => driver.FindElement(_password);
        public IWebElement LoginButton => driver.FindElement(_loginButton);

        public void Login(string username, string password)
        {
            Email.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Click();
        }
    }
}
