using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NightTask.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        //tabs
        [FindsBy(How = How.LinkText, Using = "WE ARE WABASH")]
        public IWebElement weAreWabash { get; set; }

        [FindsBy(How = How.LinkText, Using = "TRADITION OF INNOVATION")]
        public IWebElement traditionOfInnovation { get; set; }

        [FindsBy(How = How.LinkText, Using = "OUR PRODUCTS")]
        public IWebElement ourProducts { get; set; }

        [FindsBy(How = How.LinkText, Using = "OUR BRANDS")]
        public IWebElement ourBrands { get; set; }

        [FindsBy(How = How.LinkText, Using = "WORK WITH WABASH")]
        public IWebElement workWithWabash { get; set; }

        [FindsBy(How = How.LinkText, Using = "TIMELINE")]
        public IWebElement timeLine { get; set; }

        [FindsBy(How = How.LinkText, Using = "LOCATION SEARCH")]
        public IWebElement locationSearch { get; set; }
        [FindsBy(How = How.LinkText, Using = "BY WABASH NATIONAL")]
        public IWebElement byWabashNational { get; set; }

        //subtabs
        [FindsBy(How = How.LinkText, Using = "OUR CULTURE")]
        public IWebElement ourCulture { get; set; }
        [FindsBy(How = How.LinkText, Using = "FUTURE FOCUS")]
        public IWebElement futureFocus { get; set; }
        [FindsBy(How = How.LinkText, Using = "SILOS")]
        public IWebElement silos { get; set; }
        [FindsBy(How = How.LinkText, Using = "BEALL")]
        public IWebElement beall { get; set; }
        [FindsBy(How = How.LinkText, Using = "MY HR")]
        public IWebElement myHr { get; set; }
        [FindsBy(How = How.LinkText, Using = "DEALER")]
        public IWebElement dealer { get; set; }
        [FindsBy(How = How.LinkText, Using = "TEST")]
        public IWebElement test { get; set; }
    }
}
