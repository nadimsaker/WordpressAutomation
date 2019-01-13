using OpenQA.Selenium;


namespace WordpressAutomation
{
    public class MenuSelector
    {
        public static void Select(string topLevelMenuId)
        {
            var newPostButton = Driver.Instance.FindElement(By.CssSelector(topLevelMenuId));
            newPostButton.Click();
        }
    }
}
