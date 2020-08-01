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
    class Admin
    {
        public IWebDriver driver;


        public Admin(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'admin')]")]
        public IWebElement adminTitle;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Organization')]")]
        public IWebElement organizationTitle;

    }
}
