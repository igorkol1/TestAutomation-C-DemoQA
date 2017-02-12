using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQA.TestsResources
{
    class SelectableModel
    {
        IWebDriver driver;

        public SelectableModel(IWebDriver driver)
        {
            this.driver = driver;
            CommonTools.WaitForElement(driver, By.XPath("/html/body/div[1]/div/div[1]/main/article/div/div/div[1]/div/ol/li[1]"), 15);

        }

        public void SelectElements(int[] arrOrderOfElements)
        {
            foreach(int elementNumber in arrOrderOfElements)
            {
                IWebElement elementToSelect = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/article/div/div/div[1]/div/ol/li[" + elementNumber + "]"));

                Actions act = new Actions(driver);

                act.KeyDown(Keys.Control).Click(elementToSelect).KeyUp(Keys.Control).Build().Perform();
                
            }
        }

    }
}
