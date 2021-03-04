using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAutomation_Sainath.Utility
{
    class UtilityClass
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        private String LinkGroupURL;
        private string Error; 

        public IWebDriver Driver { get => driver;}
        public WebDriverWait Wait { get => wait;}

        

        public void browser_init()
        {
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            }
            catch(Exception e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
            }

        }


        public void teardown()
        {
            try
            {
                driver.Quit();
            }
            catch(Exception e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
            }
            
        }

        public void LaunchWebsite(String Value)
        {
            try
            {
                LinkGroupURL = ConfigurationManager.AppSettings[Value];
                driver.Navigate().GoToUrl(LinkGroupURL);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            }
            catch(Exception e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
            }
            
            

        }
        public void Sanity_Check()
        {
            try
            {
                string value = driver.Title;
                Console.WriteLine("Page Title - " + value);
                Assert_equals("Home", value);
            }
            catch(Exception e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
            }

        }

        public void Assert_equals(String Expected,String Actual)
        {
            try
            {
                Assert.AreEqual(Expected, Actual);
            }
            catch(AssertionException e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
            }
            

        }

        public void assertElement_enabled(IWebElement p0,string message)
        {
            try
            {
                Assert.True(p0.Enabled, message);
            }
            catch(AssertionException e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
            }
            
        }

        public IWebElement webdriverwait_exists(By element)
        {
            try
            {
                IWebElement method_element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
                return method_element;
            }
            catch(WebDriverTimeoutException e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
                return null;
            }
            catch(NoSuchElementException e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
                return null;
            }
            
        }

        public IWebElement webdriverwait_visible(By element)
        {
            try
            {
                IWebElement method_element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
                return method_element;
            }
            catch(WebDriverTimeoutException e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
                return null;
            }
            catch(NoSuchElementException e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
                return null;
            }
        }

        public void agree_cookie(By cookieconsent,By agreecookie)
        {
            try
            {
                IWebElement method_element = webdriverwait_exists(cookieconsent);
                if (method_element.Displayed)
                {
                    IWebElement agree_button = driver.FindElement(agreecookie);
                    agree_button.Click();

                }
            }
            catch(Exception e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
                
            }

        }

        public void searchfor(By search_dropDown,By search_textfield,By search_button,String searchvalue)
        {
            try
            {
                IWebElement Search_DropDown = driver.FindElement(search_dropDown);
                Search_DropDown.Click();
                IWebElement Search_textfield = webdriverwait_visible(search_textfield);
                IWebElement Search_button = driver.FindElement(search_button);
                Search_textfield.SendKeys(searchvalue);
                Search_button.Click();
            }
            catch(Exception e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
            }
        }

        public void searchresult(By constantvalue,By providedvalue)
        {
            try
            {
                IWebElement staticvalue = webdriverwait_visible(constantvalue);
                IWebElement uservalue = webdriverwait_visible(providedvalue);
                string Expected_value = staticvalue.Text.Replace("\r\n", "\n").Replace('\r', '\n');
                Assert_equals("You searched for:" + '\n' + "\"Leeds\"", Expected_value);
            }
            catch(Exception e)
            {
                Error = e.Message;
                Console.WriteLine(Error);

            }
            
        }

        public void active_link(By activelink,string p0)
        {
            try
            {
                IWebElement link = driver.FindElement(activelink);
                assertElement_enabled(link, "Link " + p0 + " is Active");
            }
            catch(Exception e)
            {
                Error = e.Message;
                Console.WriteLine(Error);
            }

            
        }


    }
}
