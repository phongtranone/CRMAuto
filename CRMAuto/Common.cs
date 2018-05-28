using System;
using System.IO;
using System.Threading;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using testSampleOne.PageObject;
using testSampleOne.Parser.LocationElements;

namespace testSampleOne
{
    public class Common : Elements
    {
        private static string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "InputData\\CommonsData.xml");
        private static string driverPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Driver");
        public string BrowserName => GetNodeByKey("Browser").Value;
        public string Url => GetNodeByKey("Url").Value;
        public string UsernameValue => GetNodeByKey("Email").Value;
        public string PasswordValue => GetNodeByKey("Password").Value;
        public IWebDriver driver;
        public DateTime GetCurrentDate = DateTime.Now;

        public Common() : base(xmlFilePath)
        {
        }

        public void OpenBrowser(string browserName)
        {
            if (string.Equals(browserName, BrowserValue.chrome.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                this.driver = new ChromeDriver(driverPath);
                this.driver.Manage().Window.Maximize();
            }
        }

        public void OpenBrowser(BrowserValue browser)
        {
            switch (browser)
            {
                default:
                    {
                        throw new InvalidOperationException(nameof(browser));
                    }

                case BrowserValue.chrome:
                    {
                        this.driver = new ChromeDriver("\\Driver");
                        this.driver.Manage().Window.Maximize();

                        break;
                    }

                case BrowserValue.firefox:
                    {
                        break;
                    }

                case BrowserValue.internetExplorer:
                    {
                        break;
                    }
            }
        }

        public void CloseBrowser()
        {
            this.driver.Close();
        }

        public void GoToUrl(String Url)
        {
            this.driver.Url = Url;
        }

        public void WaitLoad(int MiliSecond)
        {
            Thread.Sleep(MiliSecond);
        }

        public bool WaitForVisbleElement(By element)
        {
            bool flag = false;
            while (true)
            {
                try
                {
                    driver.FindElement(element);
                    flag = true;
                    break;
                }
                catch (Exception e)
                {
                    WaitLoad(1000);
                }
            }
            return flag;
        }

        public void ClickOnElement(By ElementLocator)
        {
            while (true)
            {
                try
                {
                    driver.FindElement(ElementLocator).Click();
                    break;
                }
                catch (Exception e)
                {
                    WaitLoad(1000);
                }
            }
        }

        public void InputData(By ElementLocator, String DataInput)
        {
            while (true)
            {
                try
                {
                    driver.FindElement(ElementLocator).SendKeys(DataInput);
                    break;
                }
                catch (Exception e)
                {
                    WaitLoad(1000);
                }
            }
        }
    }

    public enum BrowserValue
    {
        chrome,
        firefox,
        internetExplorer
    }

}
