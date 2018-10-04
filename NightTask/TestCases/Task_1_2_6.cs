using System;
using NUnit.Framework;
using NightTask.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;


namespace NightTask.TestCases
{
    class Task_1_2_6
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://qa.yotec.net");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test_1_2_6()
        {
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            var action = new OpenQA.Selenium.Interactions.Actions(driver);

            //Clicking on the tabs
            homePage.timeLine.Click();

            //Check that URL of the page is correct
            String pageUrl = driver.Url;
            Console.WriteLine("URL of the page is : " + pageUrl);

            String[] urlParts;
            String tabUrl;
            String subtabUrl;
            String tabName = "TIMELINE";
            String subtabName = "TIMELINE";

            urlParts = pageUrl.Split('/', '/', '/', '/');
            tabUrl = urlParts[3];
            subtabUrl = urlParts[3];

            Console.WriteLine("Name of the tab is : " + tabName + ';');
            Console.WriteLine("Name of the tab in URL is : " + tabUrl + ';');
            Console.WriteLine("Name of the subtab is : " + subtabName + ';');
            Console.WriteLine("Name of the subtab in URL is : " + subtabUrl + ';');

            //Removing any symbols from tab and subtab names
            tabName = tabName.Replace(" ", "").ToLower();
            subtabName = subtabName.Replace(" ", "").ToLower();
            tabUrl = tabUrl.Replace("-", "");
            subtabUrl = subtabUrl.Replace("-", "");

            bool res = CheckTabs.result(tabName, tabUrl, subtabName, subtabUrl);

            Console.WriteLine("Trimed names of tab on the page and in URL are : " + tabName + " and " + tabUrl);
            Console.WriteLine("Trimed names of subtab on the page and in URL are : " + subtabName + " and " + subtabUrl);

            System.Threading.Thread.Sleep(2000);

            Assert.IsTrue(res, "Actual page URL is not matched with expected: timeline");
        }

        [TearDown]
        public void CleanUP()
        {
            driver.Quit();
        }
    }
}
