
using NUnit.Framework;


namespace FacebookBasicDemo
{
    public class Tests : Base.BaseClass
    {
        [Test]
        public void InputEmailAndPassword_into_InputFields()
        {
            Pages.LoginPage.AssertAfterLaunching(driver);
            Pages.LoginPage.LoginToFacebook(driver);
        }
    }
}