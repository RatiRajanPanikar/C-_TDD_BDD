using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectModelTestSuite;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UI_TestCases
{
    [TestClass]
    public class EmployeeInformationTests
    {
        [TestInitialize]
        public void Setup()
        {
            LoginObject login = new LoginObject();
        }

        [TestMethod]
        public void Recruitment()
        {
        }
    }
}
