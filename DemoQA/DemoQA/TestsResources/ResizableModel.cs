using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.TestsResources
{
    class ResizableModel
    {
        IWebDriver driver;
        By resizeHandler = By.XPath("/html/body/div[1]/div/div[1]/main/article/div/div/div[1]/div/div/div[3]");
        By resizeFrame = By.Id("tabs-1");

        public ResizableModel(IWebDriver driver)
        {
            this.driver = driver;
            CommonTools.WaitForElement(driver, resizeHandler, 15);
        }

        public void PerformResize()
        {
            Actions act = new Actions(driver);

            IWebElement frame = driver.FindElement(resizeFrame);

            int x = frame.Size.Height;
            int y = frame.Size.Width;

            act.DragAndDropToOffset(driver.FindElement(resizeHandler), x, y).Build().Perform();
        }
    }
}
