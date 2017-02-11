using DemoQA.TestsResources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQA.TestCases
{
    class InteractionTest
    {
        private IWebDriver driver;
        private DraggableModel Draggable;
        private DroppableModel Droppable;
        private NavigationModel navigation;


        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test, Order(0)]
        public void NavigateToDemoQA()
        {
            driver.Navigate().GoToUrl("http://demoqa.com/");

        }

        [Test, Order(1)]
        public void ClickDraggableLink()
        {
            navigation = new NavigationModel(driver);

            Draggable = navigation.NavigateToDraggable();
        }

        [Test, Order(2)]
        public void PerformDrag()
        {
            Thread.Sleep(3000);
            //TO DO
            Draggable.DragObjectToCorner();
        }

        [Test, Order(3)]
        public void ClickDroppableLink()
        {
           Droppable = navigation.NavigateToDroppable();
        }

        [Test, Order(4)]
        public void PerformDragAndDrop()
        {
            Droppable.DragAndDropAtDestnation();
        }
    }
}
