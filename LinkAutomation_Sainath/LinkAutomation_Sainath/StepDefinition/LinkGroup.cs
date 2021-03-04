using LinkAutomation_Sainath.Pages;
using LinkAutomation_Sainath.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using TechTalk.SpecFlow;




namespace LinkAutomation_Sainath.StepDefinition
{
    [Binding]
    public class SearchResultsSteps
    {

        private LinkGroup_dashboard dashboard_page;
        private LinkGroup_searchresult searchresult_page;

        [BeforeScenario]
        public void BeforeScenarioHook()
        {
            dashboard_page = new LinkGroup_dashboard();
            searchresult_page = new LinkGroup_searchresult();
            dashboard_page.browser_init();
        }

        [AfterScenario]
        public void AfterScenarioHook()
        {
            dashboard_page.teardown();
        }

        [When(@"I open the home page '(.*)'")]
        public void WhenIOpenTheHomePage(String value)
        {
  
            dashboard_page.LaunchWebsite(value);
          
        }

        [Then(@"the page is displayed")]
        public void ThenThePageIsDisplayed()
        {
            dashboard_page.Sanity_Check();

        }
        [Given(@"I have opened the home page '(.*)'")]
        public void GivenIHaveOpenedTheHomePage(String value)
        {
            dashboard_page.LaunchWebsite(value);
        }

        [Given(@"I have agreed to the cookie policy")]
        public void GivenIHaveAgreedToTheCookiePolicy()
        {

            dashboard_page.agree_cookie(dashboard_page.Cookieconsent,dashboard_page.Cookieagree_button);

        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string p0)
        {

                Console.WriteLine("Search Melthod");
                dashboard_page.searchfor(dashboard_page.Dashboard_dropdown, dashboard_page.Search_textfield, dashboard_page.Search_button, p0);

        }

        [Then(@"the search results are displayed")]
        public void ThenTheSearchResultsAreDisplayed()
        {
                dashboard_page.searchresult(searchresult_page.Searchresults_staticvalue, searchresult_page.Searchresults_uservalue);
        }
    }
}
