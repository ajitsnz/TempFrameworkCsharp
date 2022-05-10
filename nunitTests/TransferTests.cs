using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleAutomationFramework.Models;
using SampleAutomationFramework.POM;

namespace SampleAutomationFramework.nunitTests
{
    [Category("Transfer")]
    public class TransferTests : TestBase
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //Execute before test case.....
        }

        [OneTimeSetUp]
        public void OneTimesetup()
        {
            Login(driver);
        }

        //[TestCaseSource("TransferDatadCSV")]
        [TestCaseSource(nameof(TransferCSVData))]
        public void FirstTest(Transfer transfer)
        {
            //Login

            //have all data here.....
            //send it to your page class
            TestContext.WriteLine(transfer.TransferFrom);
            TestContext.WriteLine(transfer.TransferTo);
            TestContext.WriteLine(transfer.Address);
            TestContext.WriteLine(transfer.Amount);

            TransferPage transferPage = new TransferPage(driver);
            transferPage.FillTransferForm(transfer);
        }

        [TearDown]
        public void Cleanup()
        {
            //Execute before test case.....
            driver.Quit();
        }

    }
}
