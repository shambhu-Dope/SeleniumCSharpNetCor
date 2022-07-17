using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Page;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCSharpNetCore
{
    public class Tests:DriverHelper
    {
        
        [SetUp]
        public void Setup()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver();
            Console.WriteLine("SetUp");
        }

        [Test]
        public void Test1()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Test1");
            Assert.Pass();
        }
        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();

            loginPage.EnterUserNameAndPassword("admin", "password");

            loginPage.clickLogin();

            Assert.That(homePage.isLoggoffExist,Is.True,"Log off doesn't exist");

        }
    }
}