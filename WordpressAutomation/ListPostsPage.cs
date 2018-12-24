using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class ListPostsPage
    {
        public static void GoTo(PostType postType)
        {
            switch (postType)
            {
                case PostType.Page:
                    Driver.Instance.FindElement(By.Id(""));
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
