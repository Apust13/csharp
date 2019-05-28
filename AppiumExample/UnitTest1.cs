using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumExample
{
    [TestClass]
    public class UnitTest1
    {

        private AppiumDriver<IWebElement> driver;


        [TestMethod]
        public void TestMethod1()
        {
            var cap = new DesiredCapabilities();

            cap.SetCapability("platformName", "Android");
            cap.SetCapability("platformVersion", "8");
            cap.SetCapability("deviceName", "name");
            cap.SetCapability("automationName", "UiAutomator2");
            cap.SetCapability("app", "D:\\Work\\SC\\ftm-1905.1-google-prod-debug.apk");
            cap.SetCapability("appPackage", "");
            cap.SetCapability("appActivity", "");
            cap.SetCapability("newCommandTimeout", "3600");
            cap.SetCapability("autoGrantPermissions", "true");
//            cap.SetCapability("noReset", "true");

            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);


            Assert.IsNotNull(driver.Context);



        }
    }
}