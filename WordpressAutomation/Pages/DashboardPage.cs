using OpenQA.Selenium;

namespace WordpressAutomation
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                //Can we create a generalized IsAt for all pages?
                if(Driver.Instance.FindElement(By.CssSelector("#header > a:nth-child(1) > span")).Text=="My Site")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}