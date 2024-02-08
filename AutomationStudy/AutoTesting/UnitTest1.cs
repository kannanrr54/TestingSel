using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace AutoTesting
{
    public class Tests
    {
        IWebDriver driver; 

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://www.google.com/";
        }
        [Test]
        public void Test2()
        {
            driver.Url = "https://www.google.com/";
        }
        [TearDown]
        public void TearDown() {
            driver.Quit();
        }
    }
}