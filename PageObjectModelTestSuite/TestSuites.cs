using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjectModelTestSuite.POM_Objects;
using OpenQA.Selenium.Chrome;

namespace PageObjectModelTestSuite
{
    [TestClass]
    public class TestSuites
    {
        private IWebDriver driver;
        

        [TestInitialize]
        public void Setup()
        {
            //Initialize Browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login
            Login login = new Login(driver);
            login.GoToLoginPage();
            login.LoginSuccessfully();


        }
        

        //Confirm user is on the correct page
        [TestMethod]
        public void Recruitment()
        {
            
            EmployeeInformation emp = new EmployeeInformation(driver);
            String ConfirmTitle = emp.title.Text;
            //String Title = ConfirmTitle.Text;
            Assert.AreEqual(ConfirmTitle, "Employee Information");
        }


        //Confirm horizontal menu is visible and clickable
        [TestMethod]
        public void ClickRecruitment()
        {
            EmployeeInformation emp = new EmployeeInformation(driver);
            IWebElement rec = emp.recruitment;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //IWebElement Visible = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(rec));

            emp.recruitment.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement title = emp.candidates;
            string ConfirmTitle = title.Text;

            Assert.AreSame(ConfirmTitle, "Candidates");

        }


        //Verify Time
        [TestMethod]
        public void Time()
        {
            Time time = new Time(driver);
            IWebElement slector = time.timeTitle;
            slector.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            IWebElement mnth2 = time.monthCalendar;
            mnth2.Click();
            SelectElement drp = new SelectElement(time.febcalendar);
            
            IWebElement day = time.dayCalendar;
            day.Click();

            SelectElement dd = new SelectElement(time.birthDay);

            //Click Save
            IWebElement Save = time.SaveBtn;
            Save.Click();
        }

        //Verify Admin's funtionality
        [TestMethod]
        public void ClickAdmin()
        {
            Admin admin = new Admin(driver);
            IWebElement ad = admin.adminTitle;
            ad.Click();

            
            
        }




        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
