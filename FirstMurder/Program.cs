using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace FirstMurder
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
       
        }
        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("https://google.co.in");
            Console.WriteLine("Browser opened");
        }
        [Test]
        public void Execute()
        {
            IWebElement ele = driver.FindElement(By.ClassName("gsfi"));
            ele.SendKeys("Coax");
            IWebElement elebtn = driver.FindElement(By.ClassName("lsb"));
            elebtn.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Actions done");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
            Console.WriteLine("Browser closed");
        }
    }
}
