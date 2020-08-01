using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace PageObjectModelTestSuite.POM_Objects
{
    class Recruitment_Candidates
    {
        public IWebDriver driver;

        public void  RecruitmentCandidatePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'mainHeading')]")]
        public IWebElement title;
    }
}
