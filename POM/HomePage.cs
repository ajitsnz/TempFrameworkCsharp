using OpenQA.Selenium;

namespace SampleAutomationFramework.POM
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver d) //d is coming from test class
        {
            driver = d;
            //driver.Url = "http://crm.qaauto.co.nz/login";
        }

        private By _customer = By.XPath("//*[@id=\"sidebar-wrapper\"]/ul/li[4]/a/span");

        public IWebElement Customer => driver.FindElement(_customer);
    }
}
