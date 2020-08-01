using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace PageObjectModelTestSuite.POM_Objects
{
    class Login
    {
        private IWebDriver driver;



        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='txtUsername']")]
        private IWebElement userID;

        [FindsBy(How = How.XPath, Using = "//input[@id='txtPassword']")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//input[@name='Submit']")]
        private IWebElement loginButton;
        private object driver1;

     

        //Open application in the browser
        public void GoToLoginPage()
        {
            driver.Navigate().GoToUrl("https://s2.demo.opensourcecms.com/orangehrm/symfony/web/index.php/auth/login");


        }

        //Enter username, password and click on Login button
        public void LoginSuccessfully()
        {
            userID.Click();
            userID.SendKeys("opensourcecms");

            password.Click();
            password.SendKeys("opensourcecms");

            loginButton.Click();
        }


        //Navigate to EmployeeInformationPage
        public EmployeeInformation EmployeeInformation()
        {
            return new EmployeeInformation(driver);
        }



    }
}
