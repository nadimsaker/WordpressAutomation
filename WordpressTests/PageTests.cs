using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordpressAutomation;

namespace WordpressTests
{
    [TestClass]
    public class PageTests
    {

        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Can_Create_A_Basic_Post()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("nadimsaker").WithPassword("k7x^KER4DufFRPET4#@vb6H").Login();

            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sample Page");

            Assert.IsTrue(NewPostPage.IsInEditMode(), "wasn't in edit mode.");
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did not match");

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
