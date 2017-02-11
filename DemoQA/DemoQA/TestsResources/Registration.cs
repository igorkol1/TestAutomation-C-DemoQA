using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.TestsResources
{
    class Registration
    {
        IWebDriver driver;

        By firstNameField = By.Name("first_name");
        By lastNameField = By.Id("name_3_lastname");
        By submitButton = By.Name("pie_submit");
        By hobbies = By.Name("checkbox_5[]");

        public By phone = By.Id("phone_9");
        public By userName = By.Id("username");
        public By emailField = By.Id("email_1");
        public By passwordField = By.Id("password_2");
        public By confirmPassword = By.Id("confirm_password_password_2");
        public By SuccesRegistrationMessage = By.CssSelector(".piereg_message");


        public Registration(IWebDriver driver)
        {

            this.driver = driver;
            CommonTools.WaitForElement(driver, firstNameField, 30);
        }

        public void SetFirstName(string name)
        {
            driver.FindElement(firstNameField).SendKeys(name);
        }

        public void SetLastName(string lastName)
        {
            driver.FindElement(lastNameField).SendKeys(lastName);
        }

        public void SetHobby(string hobby)
        {
            ReadOnlyCollection<IWebElement> checkBoxes = driver.FindElements(hobbies);
            if (hobby.Contains("dance"))
            {
                checkBoxes[0].Click();
            }
            else if (hobby.Contains("reading"))
            {
                checkBoxes[1].Click();
            }
            else if (hobby.Contains("cricket "))
            {
                checkBoxes[2].Click();
            }
        }

        public void SetPhone(string phoneNumber)
        {
            driver.FindElement(this.phone).SendKeys(phoneNumber);
        }

        public void SetUserName(string userName)
        {
            driver.FindElement(this.userName).SendKeys(userName);
        }

        public void SetEmail(string email)
        {
            driver.FindElement(this.emailField).SendKeys(email);
        }

        public void SetPassword(string password)
        {
            driver.FindElement(this.passwordField).SendKeys(password);
        }

        public void ConfirmPassword(string password)
        {
            driver.FindElement(this.confirmPassword).SendKeys(password);
        }

        public void VeryfiRegistrationMessage()
        {
            CommonTools.WaitForElement(driver, SuccesRegistrationMessage, 15);
        }

        public void SubmitForm()
        {
            driver.FindElement(submitButton).Click();
        }



    }
}
