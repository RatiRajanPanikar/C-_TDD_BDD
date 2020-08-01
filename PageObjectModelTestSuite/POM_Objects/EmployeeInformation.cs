using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PageObjectModelTestSuite.POM_Objects
{
    class EmployeeInformation
    {
        public IWebDriver driver;
      

        public EmployeeInformation(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public EmployeeInformation()
        {
        }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Employee Information')]")]
        public IWebElement title;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Recruitment')]")]
        public IWebElement recruitment;

        [FindsBy(How = How.XPath, Using = "//h2[@id='srchCandidatesHeading']")]
        public IWebElement candidates;



    }
}
