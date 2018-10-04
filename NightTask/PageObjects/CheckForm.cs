using System;
using OpenQA.Selenium;

namespace NightTask.PageObjects
{
    class CheckForm
    {
        public static bool result(IWebElement element)
        {
            bool res = false;

            if (element != null)
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
