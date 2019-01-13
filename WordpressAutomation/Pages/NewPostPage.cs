using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace WordpressAutomation
{
    public class NewPostPage
    {
        public static string Title {
            get
            {
                return String.Empty;
            }
        }

        public static void GoTo()
        {
            LeftNavigation.Posts.AddNew.Select();
        }

        public static CreatePostCommand CreatePost(string title)
        {
            return new CreatePostCommand(title);
        }

        public static void GoToNewPost()
        {
            Driver.Instance.FindElement(By.CssSelector("#post-9 > h2 > a")).Click();
        }

        public static bool IsInEditMode()
        {
            return true;
        }
    }

    public class CreatePostCommand
    {
        private readonly string title;
        private string body;

        public CreatePostCommand(string title)
        {
            this.title = title;
        }

        
        public CreatePostCommand WithBody(string body)
        {
            this.body = body;
            return this;
        }

        public void Publish()
        {
           var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(30));
           wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("Id") == "post-title-0");

            Driver.Instance.FindElement(By.Id("post-title-0")).SendKeys(title);
            Driver.Instance.FindElement(By.Id("mce_0")).SendKeys(body);

            Driver.Wait(TimeSpan.FromSeconds(1));

            Driver.Instance.FindElement(By.LinkText("Publish")).Click();
        }

    }
}
