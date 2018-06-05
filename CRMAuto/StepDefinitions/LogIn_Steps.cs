using CRMAuto.PageObject;
using TechTalk.SpecFlow;


namespace CRMAuto.Steps
{
    public static class general
    {
        public static Common common { get; set; }
        public static LoginPageObject loginPage { get; set; }
        public static HomePageObject homePage { get; set; }
        public static RegionAndMarketPageObject regionAndMarketPageObject { get; set; }
    }

    [Binding]
    public class LogIn_FeatureSteps
    {
        Common common;
        LoginPageObject loginPage;
        HomePageObject homePage;
        RegionAndMarketPageObject regionAndMarketPageObject;

        public LogIn_FeatureSteps(Common common, LoginPageObject loginPage, HomePageObject homePage, RegionAndMarketPageObject regionAndMarketPageObject)
        {
            this.common = common;
            this.loginPage = loginPage;
            this.homePage = homePage;
            this.regionAndMarketPageObject = regionAndMarketPageObject;

            general.common = common;
            general.loginPage = loginPage;
            general.homePage = homePage;
            general.regionAndMarketPageObject = regionAndMarketPageObject;
        }

        [Given(@"User LogIn Page")]
        public void GivenUserLogInPage()
        {
            // var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Driver");
            //driver = new ChromeDriver(path);
            //driver.Url = "http://builder3.siteoneservices.net/";
            common.OpenBrowser(common.BrowserName);
            common.GoToUrl(common.Url);
            //loginPage.Login(common.driver, username, password);
        }

        [When(@"User enter '(.*)' and '(.*)'")]
        public void WhenUserEnterAnd(string username, string password)
        {
            loginPage.Login(common.driver, username, password);
        }


        [When(@"Click on the SignIn button")]
        public void WhenClickOnTheSignInButton()
        {
            string name = "debug";
        }

        [Then(@"Display the Name of current User")]
        public void ThenDisplayTheNameOfCurrentUser()
        {
            string name = "debug";
        }
    }
}
