using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationExample
{
    public class Class1
    {
        IWebDriver driver;


        [SetUp]
        public void InitDriver()
        {
            driver = new ChromeDriver("D:\\Work\\SharpProject\\Tools");
        }

        [Test]
        public void test()
        {
            driver.Url = "https://www.google.com/";
           
        }


        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
