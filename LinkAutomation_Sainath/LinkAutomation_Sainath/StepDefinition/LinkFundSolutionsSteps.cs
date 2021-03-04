using LinkAutomation_Sainath.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace LinkAutomation_Sainath.StepDefinition
{
    [Binding]
    public class LinkFundSolutionsSteps
    {

        private LinkFundSolutionPage fundsolutionpage;

        [BeforeScenario]
        public void BeforeScenarioHook()
        {
            fundsolutionpage = new LinkFundSolutionPage();
            fundsolutionpage.browser_init();
        }

        [AfterScenario]
        public void AfterScenarioHook()
        {
            fundsolutionpage.teardown();
        }

        [When(@"I open the Fund Solutions page '(.*)'")]
        public void WhenIOpenTheFoundSolutionsPage(string value)
        {
            fundsolutionpage.LaunchWebsite(value);
        }
        
        [Then(@"I can select the (.*) jurisdiction")]
        public void ThenICanSelecttheJurisdiction(String po)
        {

            fundsolutionpage.setxpath(po);
            fundsolutionpage.active_link(fundsolutionpage.Jurisdiction,po);

        }
    }
}
