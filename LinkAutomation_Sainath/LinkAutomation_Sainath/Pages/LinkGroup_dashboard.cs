using LinkAutomation_Sainath.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAutomation_Sainath.Pages
{
    class LinkGroup_dashboard : UtilityClass 
    {

        private By cookieconsent;
        private By cookieagree_button;
        private By dashboard_dropdown;
        private By search_textfield;
        private By search_button;
        


        public LinkGroup_dashboard()
        {
            
            
            cookieagree_button = By.XPath("//*[@id='LinkGroupEU']/div[2]/div/a[2]");
            dashboard_dropdown = By.XPath("//*[@id='navbardrop']");
            search_textfield = By.Name("searchTerm");
            search_button = By.XPath("//*[@id='TN-search']/div/form/button");
            cookieconsent = By.XPath("//*[@id='cookieconsent:desc']/p[1]/strong");
        }

        public By Cookieagree_button { get => cookieagree_button;}
        public By Dashboard_dropdown { get => dashboard_dropdown;}
        public By Search_textfield { get => search_textfield;}
        public By Search_button { get => search_button;}
        public By Cookieconsent { get => cookieconsent;}
    }
}
