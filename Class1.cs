using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void TestChromeDriver()
        {
            using (var driver = new ChromeDriver((Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))))
            {
                driver.Navigate().GoToUrl("htttp://www.google.com");
                Thread.Sleep(100);
                driver.Quit();
            }
        }
        [Test]
        public void TestFireFoxDriver()
        {
            using (var driver = new FirefoxDriver((Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))))
            {
                driver.Navigate().GoToUrl("htttp://www.google.com");
				Thread.Sleep(100);
                driver.Quit();
            }
        }
        }
}
