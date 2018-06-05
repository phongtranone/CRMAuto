using System;
using System.Collections.Generic;
using CRMAuto.PageObject;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace CRMAuto.Steps
{
    [Binding]
    public class CreateNewInsurancePoliciesSteps
    {
        Common common;
        LoginPageObject loginPage;
        HomePageObject homePage;
        InsurancePoliciesPageObject insurancePoliciesPage;
        string dataInput = "Insurance 1";

        public CreateNewInsurancePoliciesSteps(Common common, LoginPageObject loginPage, HomePageObject homePage, InsurancePoliciesPageObject insurancePoliciesPage)
        {
            this.common = common;
            this.loginPage = loginPage;
            this.homePage = homePage;
            this.insurancePoliciesPage = insurancePoliciesPage;
        }


        [Given(@"User clicks on the left-menu")]
        public void GivenUserClicksOnTheLeft_Menu()
        {
            common.ClickOnElement(homePage.HamburgerMenuIcon);
        }

        [Given(@"User select the menu Insurance policies")]
        public void GivenUserSelectTheMenuInsurancePolicies()
        {
            common.ClickOnElement(homePage.InsurancePoliciesMenu);
        }


        [When(@"User Navigate to the modal New Insurance policies")]
        public void WhenUserNavigateToTheModalNewInsurancePolicies()
        {
            common.ClickOnElement(insurancePoliciesPage.NewButton);
        }
        
        [When(@"User input new Insurance policies")]
        public void WhenUserInputNewInsurancePolicies()
        {
            common.InputData(insurancePoliciesPage.InsuranceTextInput,dataInput);
        }
        
        [When(@"User clicks on the DONE button")]
        public void WhenUserClicksOnTheDONEButton()
        {
            common.ClickOnElement(insurancePoliciesPage.DoneButton);
        }

        [Then(@"Display new Insurance policies")]
        public void ThenDisplayNewInsurancePolicies()
        {
            IWebElement tableElement = common.driver.FindElement(By.XPath("//table[@class='table table-hover']/tbody"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));
            IList<IWebElement> rowTD;
            foreach (IWebElement row in tableRow)
            {
                rowTD = row.FindElements(By.TagName("td"));
                foreach (IWebElement column in rowTD)
                {
                    if (string.Equals(dataInput, column.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                }
            }
        }

    }
}
