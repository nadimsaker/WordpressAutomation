using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;

namespace WordpressTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
        
        [TestMethod]
        public void Admin_user_can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("nadimsaker").WithPassword("k7x^KER4DufFRPET4#@vb6H").Login();
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
