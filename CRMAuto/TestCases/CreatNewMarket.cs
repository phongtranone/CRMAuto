using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using testSampleOne.PageObject;

namespace testSampleOne.TestCases
{
    public class CreatNewMarket:TestCase
    {
        Common common = new Common();
        LoginPageObject loginPage = new LoginPageObject();
        HomePageObject homePage = new HomePageObject();
        RegionAndMarketPageObject RegionAndMarketPage = new RegionAndMarketPageObject();

        public CreatNewMarket()
        {
            
        }

        public void RunTest()
        {
            common.OpenBrowser(common.BrowserName);
            common.GoToUrl(common.Url);
            loginPage.Login(common.driver, common.UsernameValue, common.PasswordValue);
            common.ClickOnElement(homePage.HamburgerMenuIcon);
            common.ClickOnElement(homePage.RegionAndMarketsMenu);
            common.ClickOnElement(RegionAndMarketPage.NewBtn);
            common.ClickOnElement(RegionAndMarketPage.MarketItem);
            common.InputData(RegionAndMarketPage.MarketName, "Market name " + common.GetCurrentDate);
            common.InputData(RegionAndMarketPage.MarketDescription, "Market description " + common.GetCurrentDate);
            common.ClickOnElement(RegionAndMarketPage.DoneButtonMarket);
            common.WaitLoad(5000);
            common.CloseBrowser();
        }
    }
}
