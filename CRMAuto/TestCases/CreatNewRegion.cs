using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using testSampleOne.PageObject;

namespace testSampleOne.TestCases
{
    public class CreatNewRegion:TestCase
    {
        Common common;
        LoginPageObject loginPage;
        HomePageObject homePage;
        RegionAndMarketPageObject regionAndMarketPageObject;

        public CreatNewRegion()
        {
            common = new Common();
            loginPage = new LoginPageObject();
            homePage = new HomePageObject();
            regionAndMarketPageObject = new RegionAndMarketPageObject();
        }

        public void RunTest()
        {
            common.OpenBrowser(common.BrowserName);
            common.GoToUrl(common.Url);
            loginPage.Login(common.driver, common.UsernameValue,common.PasswordValue);
            common.ClickOnElement(homePage.HamburgerMenuIcon);
            common.ClickOnElement(homePage.RegionAndMarketsMenu);
            common.ClickOnElement(regionAndMarketPageObject.NewBtn);
            common.ClickOnElement(regionAndMarketPageObject.RegionItem);
            common.InputData(regionAndMarketPageObject.RegionName, "Region name " + common.GetCurrentDate);
            common.InputData(regionAndMarketPageObject.RegionDescription, "Region description " + common.GetCurrentDate);
            common.ClickOnElement(regionAndMarketPageObject.DoneButtonRegion);
            common.WaitLoad(5000);
            common.CloseBrowser();
        }
    }
}
