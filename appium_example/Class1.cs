using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumExample
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
           // driver.FindElement(XPathLookupException);
        }


        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
