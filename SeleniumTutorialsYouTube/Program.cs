using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorialsYouTube
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div/div[1]/div/div[1]/input")).SendKeys("Learn Automation");
            driver.Quit();
        }
    }
}
