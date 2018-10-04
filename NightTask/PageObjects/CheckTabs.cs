using System;

namespace NightTask.PageObjects
{
    class CheckTabs
    {
        public static bool result(String tabN, String tabU, String subtabN, String subtabU)
        {
            bool res = false;

            if (tabN.Equals(tabU) && subtabN.Equals(subtabU))
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
