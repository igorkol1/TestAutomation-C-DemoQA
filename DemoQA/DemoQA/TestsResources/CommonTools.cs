using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.TestsResources
{
    static class CommonTools
    {
        public static void WaitForElement(IWebDriver driver,By elementLocation, int timeOut)
        {
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(timeOut));
            wait.Until(ExpectedConditions.ElementExists(elementLocation));
        }


        public static string CreateRandomString(int lenght)
        {
            string temp = "";
            Random rnd = new Random(DateTime.UtcNow.Millisecond);

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for(int i = 0; i < lenght; i++)
            {
                temp = temp + chars[rnd.Next(chars.Length)];
            }

            return temp;
        }

        public static int CreateRandomInt(int min, int max)
        {
            Random rnd = new Random(DateTime.UtcNow.Millisecond);

            return rnd.Next(min, max);
        }

    }
}
