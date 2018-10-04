using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NightTask.PageObjects
{
    class HowHelp
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "ContentPlaceHolderFooter_TADBF704B033_ctl00_ctl00_ctl02_C015_ctl00_ctl00_dropDown")]
        public IWebElement choice { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='Second Choice']")]
        public IWebElement secondChoice { get; set; }

        [FindsBy(How = How.Id, Using = "ContentPlaceHolderFooter_TADBF704B033_ctl00_ctl00_ctl02_C019_ctl00_ctl00_dropDownCountry")]
        public IWebElement country { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='CA']")]
        public IWebElement canada { get; set; }

        [FindsBy(How = How.Id, Using = "ContentPlaceHolderFooter_TADBF704B033_ctl00_ctl00_C006_ctl00_ctl00_textBox_write")]
        public IWebElement name { get; set; }

        [FindsBy(How = How.Id, Using = "ContentPlaceHolderFooter_TADBF704B033_ctl00_ctl00_C008_ctl00_ctl00_textBox_write")]
        public IWebElement company { get; set; }

        [FindsBy(How = How.Id, Using = "ContentPlaceHolderFooter_TADBF704B033_ctl00_ctl00_C010_ctl00_ctl00_textBox_write")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "ContentPlaceHolderFooter_TADBF704B033_ctl00_ctl00_C011_ctl00_ctl00_textBox_write")]
        public IWebElement phone { get; set; }

        [FindsBy(How = How.Id, Using = "ContentPlaceHolderFooter_TADBF704B033_ctl00_ctl00_ctl09_C009_ctl00_ctl00_textBox_write")]
        public IWebElement comments { get; set; }

        [FindsBy(How = How.Id, Using = "ContentPlaceHolderFooter_TADBF704B033_ctl00_ctl00_ctl10_C007")]
        public IWebElement submit { get; set; }

    }
}
