using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.TestsResources
{
    class NavigationModel
    {
        IWebDriver driver;

        By registrationLink = By.Id("menu - item - 374");

        NavigationModel(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Registration NavigateToRegistration()
        {
            driver.FindElement(registrationLink).Click();

            var RegistrationModel = new Registration(driver);

            return RegistrationModel;
        }

    }
}
