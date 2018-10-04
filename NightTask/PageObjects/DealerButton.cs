using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NightTask.PageObjects
{
    class DealerButton
    {
        private IWebDriver driver;

        //Checkboxes Brand
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList1_ctl00")]
        public IWebElement brenner { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList1_ctl01")]
        public IWebElement wabashNationalTrailers { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList1_ctl02")]
        public IWebElement walker { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList1_ctl03")]
        public IWebElement beall { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList1_ctl04")]
        public IWebElement benson { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList1_ctl05")]
        public IWebElement transcraft { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList1_ctl06")]
        public IWebElement bulk { get; set; }


        //Checkboxes Location Type
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList2_ctl00")]
        public IWebElement sales { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList2_ctl01")]
        public IWebElement warranty { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList2_ctl02")]
        public IWebElement manufacturing { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList2_ctl03")]
        public IWebElement corporate { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList2_ctl04")]
        public IWebElement service { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderContent_C001_RadCheckBoxList2_ctl05")]
        public IWebElement parts { get; set; }


        //Text fields
        [FindsBy(How = How.Id, Using = "CompanyName")]
        public IWebElement company { get; set; }

        [FindsBy(How = How.Id, Using = "ContentPlaceHolderContent_C001_txtSourceZip")]
        public IWebElement location { get; set; }


        //Clear button
        [FindsBy(How = How.Id, Using = "clear")]
        public IWebElement clearAll { get; set; }
    }
}
