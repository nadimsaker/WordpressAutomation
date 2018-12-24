using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace WordpressAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string BaseAddress
        {
            get
            {
                return "https://wordpress.com/";
            }
        }

        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));  
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}