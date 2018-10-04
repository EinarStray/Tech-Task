using System;
using System.Collections.Generic;
using NUnit.Framework;
using NightTask.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;


namespace NightTask.TestCases
{
    class Task_3_2
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://qa.yotec.net");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test_3_2()
        {
            var homePage = new HomePage();
            var dealerButton = new DealerButton();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, dealerButton);
            var action = new OpenQA.Selenium.Interactions.Actions(driver);

            //Go on Location Search - Dealer
            action.MoveToElement(homePage.locationSearch).Perform();
            System.Threading.Thread.Sleep(500);
            homePage.dealer.Click();
            System.Threading.Thread.Sleep(1000);

            //Clear all filters before searching
            dealerButton.clearAll.Click();
            System.Threading.Thread.Sleep(9000);

            //Grab a initial amount of items in search grid results
            List<IWebElement> searchGrid = new List<IWebElement>();

            for (int i = 0; i < 86; i++)
            {
                searchGrid.Add(driver.FindElement(By.ClassName("w__dealer_item")));
            }

            //Perform a test
            //Choose search options
            dealerButton.brenner.Click();
            dealerButton.wabashNationalTrailers.Click();
            dealerButton.walker.Click();
            dealerButton.beall.Click();
            dealerButton.benson.Click();
            dealerButton.transcraft.Click();
            dealerButton.bulk.Click();

            System.Threading.Thread.Sleep(9000);

            //Clear all filters
            dealerButton.clearAll.Click();
            System.Threading.Thread.Sleep(9000);

            List<IWebElement> searchGrid_1 = new List<IWebElement>();

            for (int i = 0; i < 86; i++)
                try
                {
                    searchGrid_1.Add(driver.FindElement(By.ClassName("w__dealer_item")));
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }
                
            System.Threading.Thread.Sleep(1000);

            bool res = CheckSearch.resultA(searchGrid, searchGrid_1);

            Assert.IsTrue(res, "Actual amount of results is 0. Expected: 86");

        }

        [TearDown]
        public void CleanUP()
        {
            driver.Quit();
        }
    }
}
