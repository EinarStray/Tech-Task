using System;
using System.Collections.Generic;
using NUnit.Framework;
using NightTask.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;


namespace NightTask.TestCases
{
    class Task_3_1
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://qa.yotec.net");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test_3_1()
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

            //Grab a initial amount of items in search grid results
            List<IWebElement> searchGrid = new List<IWebElement>();

            for (int i = 0; i < 86; i++)
            {
                searchGrid.Add(driver.FindElement(By.ClassName("w__dealer_item")));
            }
            Console.WriteLine("Clear all filters");
            Console.WriteLine("Results: " + searchGrid.Count + " results near Indiana");
            Console.WriteLine();

            dealerButton.parts.Click();
            dealerButton.sales.Click();
            dealerButton.company.SendKeys("Wabash");
            System.Threading.Thread.Sleep(7000);

            //Verify the result
            List<IWebElement> searchGrid_1 = new List<IWebElement>();

            for (int i = 0; i < 4; i++)
            {
                searchGrid_1.Add(driver.FindElement(By.ClassName("w__dealer_item")));
            }

            if (searchGrid_1.Count == 4)
            {
                Console.WriteLine("Search: Wabash; Location Type: Sales + Parts;");
                Console.WriteLine("Results: " + searchGrid_1.Count + " results near Indiana");
            }

            Console.WriteLine();

            System.Threading.Thread.Sleep(1000);

            bool res = CheckSearch.result(searchGrid_1);

            Assert.IsTrue(res, "Amount of results in search grid are not match with expected. Expected: 4");

        }

        [TearDown]
        public void CleanUP()
        {
            driver.Quit();
        }
    }
}
