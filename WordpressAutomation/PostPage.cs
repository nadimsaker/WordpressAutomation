﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class PostPage
    {
        public static string Title
        {
            get
            {
               var title = Driver.Instance.FindElement(By.CssSelector("#post-9 > h2"));
                if (title != null)
                {
                    return title.Text;
                }
                else
                {
                    return String.Empty;
                }
            }
        
        }
    }
}
