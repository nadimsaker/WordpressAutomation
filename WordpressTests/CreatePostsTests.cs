using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;

namespace WordpressTests
{
    [TestClass]
    public class CreatePostsTests:WordpressTest
    {
        [TestMethod]
        public void Can_Create_A_Basic_Post()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("nadimsaker").WithPassword("k7x^KER4DufFRPET4#@vb6H").Login();

            NewPostPage.GoTo();
            NewPostPage.CreatePost("This is a test post")
                .WithBody("Hi, this is the body")
                .Publish();
            NewPostPage.GoToNewPost();

            Assert.AreEqual(PostPage.Title, "This is a test post title.", "Title did not match.");
        }
    }
}
