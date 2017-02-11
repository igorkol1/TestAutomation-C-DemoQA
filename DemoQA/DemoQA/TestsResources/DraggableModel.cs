using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using System.Threading;

namespace DemoQA.TestsResources
{
    class DraggableModel
    {
        IWebDriver driver;

        By dragElement = By.Id("draggable");
        By dragFrame = By.Id("tabs-1");

        public DraggableModel(IWebDriver driver)
        {
            this.driver = driver;

            CommonTools.WaitForElement(driver, dragElement, 15);
        }


        public void DragObjectToCorner()
        {
            
            Actions act = new Actions(driver);

            IWebElement frame = driver.FindElement(dragFrame);

            int x = frame.Size.Height;
            int y = frame.Size.Width;

            Console.WriteLine(x);
            Console.WriteLine(y);
            //act.
            //act.DragAndDrop(driver.FindElement(dragElement), x, y).perform();

            //act.ClickAndHold(driver.FindElement(dragElement)).MoveByOffset(x, y).Release().Build().Perform();

            act.DragAndDropToOffset(driver.FindElement(dragElement), x, y).Build().Perform();

        }

    }
}
