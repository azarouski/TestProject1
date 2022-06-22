using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using NLog.Config;
using NLog.Targets;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using ZebrunnerAgent.Attributes;


namespace TestProject1
{   

    public class TestProject
    {
        // private static NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        [TestFixture]
        [ZebrunnerClass, ZebrunnerTest]
        public class Ready
        {   

            [OneTimeSetUp]
            public void Setup()
            {
            
            }

            // [Test]
            // public void Test1()
            // {
            //     Logger.Info("test-test");
            //     
            //     ////////////////////////////////////////
            //     var chromeOptions = new ChromeOptions();
            //     Logger.Fatal("driver starts here");
            //     var uri = new Uri("https://qps:dd43lIi6xvd2l8JA@engine.zebrunner.com/wd/hub");
            //     // var uri = new Uri(Environment.GetEnvironmentVariable("ZEBRUNNER_HUB_URL"));
            //     
            //     var driver = new RemoteWebDriver(uri, chromeOptions);
            //     //////////////////// or
            //     // var driver = new RemoteWebDriver(new ChromeOptions());
            //     ////////////////////////////////////////
            //     
            //     driver.Manage().Window.Maximize();
            //
            //     driver.Url = "https://azar.zebrunner.dev";
            //
            //     Thread.Sleep(5000);
            //
            //     var username = driver.FindElement(By.XPath("//input[@id='username']"));
            //     username.SendKeys("mainAdmin");
            //
            //
            //     var password = driver.FindElement(By.XPath("//input[@id='password']"));
            //     password.SendKeys("mainAdmin");
            //
            //
            //     var loginButton = driver.FindElement(By.XPath("//button[@id='signin']"));
            //     loginButton.Click();
            //
            //     Thread.Sleep(7000);
            //
            //     Assert.AreEqual("https://azar.zebrunner.dev/projects/DEF/test-runs", driver.Url);
            //     Logger.Info("test2-test2");
            //
            //     driver.Quit();
            // }

            // [Test]
            // [Maintainer("testAdmin")]
            // public void Test2()
            // {
            //     Console.WriteLine("test");
            //     Logger.Info("asd1");
            //     Thread.Sleep(50);
            //     
            //     Logger.Debug("dbg1");
            //     Thread.Sleep(100);
            //
            //     var x = 0;
            //     while (x < 100)
            //     {
            //         x += 1;
            //         Logger.Fatal(x);
            //         Thread.Sleep(50);
            //     }
            //     Assert.AreEqual("1", "1");
            //
            // }

            [Test]
            public void Test3()
            {
                Console.WriteLine("QAZ");
            }
        }
    }
}