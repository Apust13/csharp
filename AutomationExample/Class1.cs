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
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Test]
        public void test()
        {
      
            var element = driver.FindElement(By.Name("q"));

            element.SendKeys("Selenium C# examples");

            var button = driver.FindElements(By.XPath(".//input[@type='submit' and contains(@value, 'Google')]"))[1];

            button.Click();

        }


        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
