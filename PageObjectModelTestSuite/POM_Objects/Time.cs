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
    class Time
    {
        public IWebDriver driver;


        public Time(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Time')]")]
        public IWebElement timeTitle;


        [FindsBy(How = How.XPath, Using = "//select[@id='leaveperiod_cmbStartMonth']")]
        public IWebElement monthCalendar;

        [FindsBy(How = How.XPath, Using = "//select[@id='leaveperiod_cmbstartmonth']//option[contains(text(),'february')]")]
        public IWebElement febcalendar;

        [FindsBy(How = How.XPath, Using = "//select[@id='leaveperiod_cmbStartDate']")]
        public IWebElement dayCalendar;

        [FindsBy(How = How.XPath, Using = "//select[@id='leaveperiod_cmbStartDate']//option[contains(text(),'12')]")]
        public IWebElement birthDay;

        
        [FindsBy(How = How.XPath, Using = "///input[@id='btnEdit']")]
        public IWebElement SaveBtn;




    }
}
