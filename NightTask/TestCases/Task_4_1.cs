using System;
using NUnit.Framework;
using NightTask.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;


namespace NightTask.TestCases
{
    class Task_4_1
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://qa.yotec.net");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test_4_1()
        {
            var howHelp = new HowHelp();
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, howHelp);
            var action = new OpenQA.Selenium.Interactions.Actions(driver);

            //Clicking on the tabs
            action.MoveToElement(homePage.weAreWabash).Perform();
            System.Threading.Thread.Sleep(500);
            homePage.ourCulture.Click();

            System.Threading.Thread.Sleep(2000);

            //Scroll page down
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");

            //Choose Choice
            howHelp.choice.Click();
            System.Threading.Thread.Sleep(500);
            howHelp.secondChoice.Click();

            //Choose Country
            howHelp.country.Click();
            System.Threading.Thread.Sleep(500);
            howHelp.canada.Click();

            //Type Name
            howHelp.name.SendKeys("T-800");

            //Type Company
            howHelp.company.SendKeys("SkyNet");

            //Type E-Mail
            howHelp.email.SendKeys("terminator@skynet.com");

            //Type Phone number
            howHelp.phone.SendKeys("123-456-789");

            //Type Comments
            howHelp.comments.SendKeys("Can you give me your dress and motorbike?");
            System.Threading.Thread.Sleep(2000);
            howHelp.submit.Click();
            System.Threading.Thread.Sleep(2000);

            //Scroll page down
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
            System.Threading.Thread.Sleep(3000);

            IWebElement element = driver.FindElement(By.ClassName("sfSuccess"));

            bool res = CheckForm.result(element);

            System.Threading.Thread.Sleep(2000);

            Assert.IsTrue(res, "The form was not submited");
        }

        [TearDown]
        public void CleanUP()
        {
            driver.Quit();
        }
    }
}

