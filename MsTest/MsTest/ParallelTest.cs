﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MsTest
{
    [TestClass]
 public class ParallelTest : IDisposable
    {

        public IWebDriver driver;


        public void Driver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                case "Firefox":
                    driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                case "IE":
                    driver = new InternetExplorerDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                default:
                    driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
            }
        }



        public void InitalizeDriver()
        {

            // driver = new ChromeDriver();

            Driver("Chrome");
            string url = "https://www.cricbuzz.com";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

        }




        [TestMethod]
        public void VerifyTitle1()
        {
            InitalizeDriver();
            string title = driver.Title;
            Thread.Sleep(3000);

            Assert.AreEqual("World Cup 2019, Cricket Score, Schedule, Latest News, Stats & Videos | Cricbuzz.com", title);
            driver.Quit();
        }


        [TestMethod]
        public void VerifyTitle2()
        {
            InitalizeDriver();
            string title = driver.Title;
            Thread.Sleep(3000);

            Assert.AreEqual("World Cup 2019, Cricket Score, Schedule, Latest News, Stats & Videos | Cricbuzz.com", title);
            driver.Quit();
        }



        [TestMethod]
        public void VerifyTitle3()
        {
            InitalizeDriver();
            string title = driver.Title;
            Thread.Sleep(3000);

            Assert.AreEqual("World Cup 2019, Cricket Score, Schedule, Latest News, Stats & Videos | Cricbuzz.com", title);
            driver.Quit();
        }


        [TestMethod]
        public void VerifyTitle7()
        {
            InitalizeDriver();
            string title = driver.Title;
            Thread.Sleep(3000);

            Assert.AreEqual("World Cup 2019, Cricket Score, Schedule, Latest News, Stats & Videos | Cricbuzz.com", title);
            driver.Quit();
        }



        [TestMethod]
        public void VerifyTitle5()
        {
            InitalizeDriver();
            string title = driver.Title;
            Thread.Sleep(3000);

            Assert.AreEqual("World Cup 2019, Cricket Score, Schedule, Latest News, Stats & Videos | Cricbuzz.com", title);
            driver.Quit();
        }




        /**********Helper Methods *******/




        public void Dispose()
        {
            driver.Quit();
        }



    }
}
