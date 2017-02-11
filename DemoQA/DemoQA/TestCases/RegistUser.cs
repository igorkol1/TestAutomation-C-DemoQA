using DemoQA.TestsResources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.TestCases
{
    class RegistUser
    {
        private IWebDriver driver;
        private Registration RegistrationModel;

        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        [Test, Order(0)]
        public void NavigateToDemoQA()
        {
            driver.Navigate().GoToUrl("http://demoqa.com/");
        } 

        [Test, Order(1)]
        public void ClickRegistrationLink()
        {
            NavigationModel navigation = new NavigationModel(driver);

            RegistrationModel = navigation.NavigateToRegistration();

        }

        [Test, Order(2)]
        public void FillMandatoryFields()
        {
            RegistrationModel.SetFirstName(CommonTools.CreateRandomString(5));

            RegistrationModel.SetLastName(CommonTools.CreateRandomString(10));

            RegistrationModel.SetHobby("dance");

            RegistrationModel.SetPhone("0148123456789");

            RegistrationModel.SetUserName(CommonTools.CreateRandomString(5));

            RegistrationModel.SetEmail(CommonTools.CreateRandomString(10) + "@test.com");

            string password = CommonTools.CreateRandomString(10);

            RegistrationModel.SetPassword(password);

            RegistrationModel.ConfirmPassword(password);

            RegistrationModel.SubmitForm();
        }

        [Test,Order(3)]
        public void VerifySuccesMessage()
        {
            RegistrationModel.VeryfiRegistrationMessage();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
