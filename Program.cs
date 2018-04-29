using System;
using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


    [TestFixture]
    public class Program
    {
        private IWebDriver driver;

        [SetUp]
        public void SetupTest() {
        ChromeDriverService service = ChromeDriverService.CreateDefaultService();
        service.Port = 64444;
        driver = new ChromeDriver(service);
        driver.Url = "http://www2.hm.com/sv_se/index.html";

    }

    [TearDown]
    public void TeardownTest() {
        driver.Quit();
    }

    [Test]
    public void TestMethod() {
        String title = driver.Title;
        System.Console.WriteLine("Title of this page is " + title);

        IWebElement shoppingBag = driver.FindElement(By.CssSelector(".minicart.parbase"));

//        Assert.AreEqual("Download for Mac\nStable build", button.Text);
    }
}
