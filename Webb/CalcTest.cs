using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Webb
{
    [TestFixture]
    class CalcTest
    {
        Program calc = new Program();
        IWebDriver drive;
        
        [TestCase("5", "2", "7")]
        [TestCase("1", "2", "3")]
        public void TestPlus(string num1, string num2, string exp)
        {
            drive = new ChromeDriver();
            drive.Navigate().GoToUrl("file:///C:/Users/EeSmile/Desktop/refactored/index.html");
           
            drive.FindElement(By.Id(num1)).Click();
            drive.FindElement(By.Id("+")).Click();
            drive.FindElement(By.Id(num2)).Click();
            drive.FindElement(By.Id("equal")).Click();
            IWebElement output = drive.FindElement(By.Id("15"));
            string act = output.GetAttribute("value");
            Assert.AreEqual(exp, act);
            drive.Quit();
        }
        [TestCase("5", "2", "3")]
        [TestCase("2", "1", "1")]
        public void TestMinus(string num1, string num2, string exp)
        {
            drive = new ChromeDriver();
            drive.Navigate().GoToUrl("file:///C:/Users/EeSmile/Desktop/refactored/index.html");
            
            drive.FindElement(By.Id(num1)).Click();

            drive.FindElement(By.Id("-")).Click();
            drive.FindElement(By.Id(num2)).Click();
            drive.FindElement(By.Id("equal")).Click();
            IWebElement output = drive.FindElement(By.Id("15"));
            string act = output.GetAttribute("value");
            Assert.AreEqual(exp, act);
            
        }
        [TestCase("5", "2", "10")]
        [TestCase("9", "3", "27")]
        public void TestUmnoj(string num1, string num2, string exp)
        {
            drive = new ChromeDriver();
            drive.Navigate().GoToUrl("file:///C:/Users/EeSmile/Desktop/refactored/index.html");
            
            drive.FindElement(By.Id(num1)).Click();

            drive.FindElement(By.Id("*")).Click();
            drive.FindElement(By.Id(num2)).Click();
            drive.FindElement(By.Id("equal")).Click();
            IWebElement output = drive.FindElement(By.Id("15"));
            string act = output.GetAttribute("value");
            Assert.AreEqual(exp, act);

        }
        [TestCase("2", "2", "1")]
        [TestCase("9", "3", "3")]
        public void TestDelit(string num1, string num2, string exp)
        {
            drive = new ChromeDriver();
            drive.Navigate().GoToUrl("file:///C:/Users/EeSmile/Desktop/refactored/index.html");
            drive.FindElement(By.Id(num1)).Click();
            drive.FindElement(By.Id("/")).Click();
            drive.FindElement(By.Id(num2)).Click();
            drive.FindElement(By.Id("equal")).Click();
            IWebElement output = drive.FindElement(By.Id("15"));
            string act = output.GetAttribute("value");
            Assert.AreEqual(exp, act);

        }
        [TestCase("8", "dot", "2", "1","9", "6.3")]
        public void TestDrobMinus(string num1, string dot, string num1_2 , string num2, string num2_2, string exp)
        {
            drive = new ChromeDriver();
            drive.Navigate().GoToUrl("file:///C:/Users/EeSmile/Desktop/refactored/index.html");
            drive.FindElement(By.Id(num1)).Click();
            drive.FindElement(By.Id(dot)).Click();
            drive.FindElement(By.Id(num1_2)).Click();
            drive.FindElement(By.Id("-")).Click();
            drive.FindElement(By.Id(num2)).Click();
            drive.FindElement(By.Id(dot)).Click();
            drive.FindElement(By.Id(num2_2)).Click();
            drive.FindElement(By.Id("equal")).Click();
            IWebElement output = drive.FindElement(By.Id("15"));
            string act = output.GetAttribute("value");
            Assert.AreEqual(exp, act);

        }


        [TearDown]
        public void TearDown()
        {
            drive.Quit();
        }
    }
}
