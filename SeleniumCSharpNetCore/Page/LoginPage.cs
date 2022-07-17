using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCore.Page
{
    class LoginPage : DriverHelper
    {
        IWebElement txtUsername => Driver.FindElement(By.Name("UserName"));

        IWebElement txtPasswrord => Driver.FindElement(By.Name("Password"));

        IWebElement btnLogin => Driver.FindElement(By.CssSelector("input[type='submit']"));


        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUsername.SendKeys(userName);
            txtPasswrord.SendKeys(password);
        }

        public void clickLogin()
        {
            btnLogin.Click();
        }
    }
}
