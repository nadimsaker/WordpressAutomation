using OpenQA.Selenium;

namespace WordpressAutomation
{
    public class ListPostsPage
    {
        public static void GoTo(PostType postType)
        {
            switch (postType)
            {
                case PostType.Page:
                    LeftNavigation.Pages.AllPages.Select();
                    break;
            }
        }

        public static void SelectPost(string v)
        {
            var postLink = Driver.Instance.FindElement(By.LinkText(""));
            postLink.Click();
        }
    }

    public enum PostType
    {
        Page
    }
}
