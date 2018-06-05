using TechTalk.SpecFlow;

namespace CRMAuto.Steps
{
    [Binding]
    public class AddNewRequestTypeSteps
    {
        Common common;
        //LoginPageObject loginPage;
        //HomePageObject homePage;
        //InsurancePoliciesPageObject insurancePoliciesPage;
        string dataInput = "Insurance 1";

        public AddNewRequestTypeSteps()
        {
            common = new Common();
            //loginPage = new LoginPageObject();
            //homePage = new HomePageObject();
            //insurancePoliciesPage = new InsurancePoliciesPageObject();
        }

        [Given(@"User select the menu Request types")]
        public void GivenUserSelectTheMenuRequestTypes()
        {
            //common.ClickOnElement();
        }

        [When(@"User click on the New button")]
        public void WhenUserClickOnTheNewButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User input new Request type")]
        public void WhenUserInputNewRequestType()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"User input new Request type")]
        public void GivenUserInputNewRequestType()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"User clicks on the DONE button")]
        public void GivenUserClicksOnTheDONEButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Display new Request type")]
        public void ThenDisplayNewRequestType()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
