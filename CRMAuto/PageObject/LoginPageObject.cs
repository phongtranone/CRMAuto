using System;
using System.IO;
using OpenQA.Selenium;
using testSampleOne.Parser.LocationElements;

namespace testSampleOne.PageObject
{
    public class LoginPageObject:Elements
    {
       
        private static string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LocationElements\\Login.xml");
        public LoginPageObject() : base(xmlFilePath)
        {
        }

        public By GetUsername => FindElementByKey("Username");
        public By GetPassword => FindElementByKey("Password");
        public By GetRememberMe => FindElementByKey("RememberMe");
        public By GetLoginButton => FindElementByKey("LoginButton");
        
        public void Login(IWebDriver driver, string username, string password)
        {
            driver.FindElement(this.GetUsername).SendKeys(username);
            driver.FindElement(this.GetPassword).SendKeys(password);
            driver.FindElement(this.GetRememberMe).Click();
            driver.FindElement(this.GetLoginButton).Click();
        }
    }
}
