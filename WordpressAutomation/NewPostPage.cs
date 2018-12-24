﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class NewPostPage
    {
        public static void GoTo()
        {
            var newPostButton = Driver.Instance.FindElement(By.CssSelector("#header > div.masterbar__publish > a > span"));
            newPostButton.Click();
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
            Driver.Instance.FindElement(By.LinkText("Publish")).Click();
        }

    }
}
