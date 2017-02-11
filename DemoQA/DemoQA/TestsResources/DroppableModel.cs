using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.TestsResources
{
    class DroppableModel
    {
        IWebDriver driver;

        By drapElement = By.Id("draggableview");
        By drapDestination = By.CssSelector("#droppableview");

        public DroppableModel(IWebDriver driver)
        {
            this.driver = driver;

            CommonTools.WaitForElement(driver, drapElement, 20);
        }

        public void DragAndDropAtDestnation()
        {
            Actions act = new Actions(driver);

            act.DragAndDrop(driver.FindElement(drapElement), driver.FindElement(drapDestination)).Build().Perform();
        }



    }
}
