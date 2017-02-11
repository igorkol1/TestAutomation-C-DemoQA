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

            Registration RegistrationModel = navigation.NavigateToRegistration();

        }

    }
}
