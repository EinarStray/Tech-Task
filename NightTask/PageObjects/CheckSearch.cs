using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace NightTask.PageObjects
{
    class CheckSearch
    {
        public static bool result(List<IWebElement> searchGrid)
        {
            bool res = false;

            if (searchGrid.Count == 4)
            {
                res = true;
                return res;
            }
            else
            {
                return res;
            }
        }

        public static bool resultA(List<IWebElement> searchGrid, List<IWebElement> searchGrid1)
        {
            bool res = false;

            if (searchGrid.Equals(searchGrid1))
            {            
                res = true;
                return res;
            }
            else
            {
                return res;
            }
        }
    }
}
