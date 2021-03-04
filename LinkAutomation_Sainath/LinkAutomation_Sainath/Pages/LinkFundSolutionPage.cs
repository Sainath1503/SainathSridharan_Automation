using LinkAutomation_Sainath.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAutomation_Sainath.Pages
{
    class LinkFundSolutionPage : UtilityClass
    {
        private By jurisdiction;

        public LinkFundSolutionPage()
        {
            jurisdiction = By.XPath("//*[text()='']");
        }

        public By Jurisdiction { get => jurisdiction;}
        public void setxpath(string value)
        {
            jurisdiction = By.XPath("//*[text()=" + "'" + value + "'" + "]");
        }
    }

    }


