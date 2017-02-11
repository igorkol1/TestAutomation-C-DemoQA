using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.TestsResources
{
    class Registration
    {
        IWebDriver driver;

        By firstNameField = By.Id("name_3_firstname");
        By lastNameField = By.Id("name_3_lastname");


        public Registration(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SetFirstName(string name)
        {
            driver.FindElement(firstNameField).SendKeys(name);
        }

        public void SetLastName(string lastName)
        {
            driver.FindElement(lastNameField).SendKeys(lastName);
        }

    }
}
