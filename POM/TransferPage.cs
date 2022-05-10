using OpenQA.Selenium;
using SampleAutomationFramework.Models;

namespace SampleAutomationFramework.POM
{
    public class TransferPage
    {
        IWebDriver driver;
        public TransferPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By _transferTo = By.Id("");
        IWebElement TransferTo => driver.FindElement(_transferTo);
        IWebElement TransferFrom => driver.FindElement(By.Id(""));
        IWebElement TransferAmount => driver.FindElement(By.Id(""));
        IWebElement TransferAddress => driver.FindElement(By.Id(""));
        IWebElement TransferButton => driver.FindElement(By.Id(""));


        public void FillTransferForm(Transfer data)
        {
            TransferTo.SendKeys(data.TransferTo);
            TransferFrom.SendKeys(data.TransferFrom);
            TransferAmount.SendKeys(data.Amount);
            TransferAddress.SendKeys(data.Address);
            TransferButton.Click();
        }

    }
}
