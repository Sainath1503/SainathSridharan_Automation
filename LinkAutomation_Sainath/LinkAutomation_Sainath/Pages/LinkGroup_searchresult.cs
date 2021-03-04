using LinkAutomation_Sainath.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAutomation_Sainath.Pages
{
    class LinkGroup_searchresult : UtilityClass
    {
        
        private By searchresults_staticvalue;
        private By searchresults_uservalue;

        public LinkGroup_searchresult()
        {

            searchresults_staticvalue = By.XPath("//*[@id='SearchResults']/h3");
            searchresults_uservalue = By.XPath("//*[@id='SearchResults']/h3/em");



        }

        public By Searchresults_staticvalue { get => searchresults_staticvalue;}
        public By Searchresults_uservalue { get => searchresults_uservalue;}
    }
}
