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

        By registrationLink = By.Id("menu-item-374");
        By draggableLink = By.Id("menu-item-140");
        By droppableLink = By.Id("menu-item-141");
        By resizableLink = By.Id("menu-item-143");
        By selectableLink = By.Id("menu-item-142");
        By sortableLink = By.Id("menu-item-151");


        public NavigationModel(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Registration NavigateToRegistration()
        {
            driver.FindElement(registrationLink).Click();

            var RegistrationModel = new Registration(driver);

            return RegistrationModel;
        }

        public DraggableModel NavigateToDraggable()
        {
            driver.FindElement(draggableLink).Click();

            var Draggable = new DraggableModel(driver);

            return Draggable;
        }

        public DroppableModel NavigateToDroppable()
        {
            driver.FindElement(droppableLink).Click();

            var Droppable = new DroppableModel(driver);

            return Droppable;
        }

        public ResizableModel NavigateToResizable()
        {
            driver.FindElement(resizableLink).Click();

            var Resizable = new ResizableModel(driver);

            return Resizable;
        }

        public SelectableModel NavigateToSelectable()
        {
            driver.FindElement(selectableLink).Click();

            var Selecteable = new SelectableModel(driver);

            return Selecteable;
        }



    }
}
