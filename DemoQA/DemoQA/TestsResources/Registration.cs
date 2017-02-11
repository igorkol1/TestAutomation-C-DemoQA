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

        public Registration(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
