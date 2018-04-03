using System;
using InputValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class InputValidation
    {
        protected IValidator validator;

        protected void Valid(string data) => Assert.IsTrue(validator.IsValid(data));
        protected void Invalid(string data) => Assert.IsFalse(validator.IsValid(data));

        [TestMethod]
        public void UrlValidator()
        {
            validator = new UrlValidator();
            Invalid(null);
            Invalid("");
            Invalid("https://website");
            Invalid(" website.com");
            Invalid("website.com");
            Valid("https://website.com");
            Invalid("abc.def..bc.de");
            Valid("https://gml-jbpm.gomel.iba.by/openolat/CourseNode/94045318676652");
            Invalid("http://website.com//");
            Valid("http://website.com/page.html");
        }

        [TestMethod]
        public void FilePathValidator()
        {
            validator = new FilePathValidator();
            Invalid(null);
            Invalid("");
            Invalid(@"C:\");
            Invalid(@"C:\data");
            Valid(@"C:\data.txt");
            Valid(@"C:\folder\en-us\resources.resx");
            Invalid(@"C:\\");
            Invalid(@"C:\da|ta\text.txt");
        }

        [TestMethod]
        public void EmailValidator()
        {
            validator = new EmailValidator();
            Invalid(null);
            Invalid("");
            Valid("k1rikkk@mail.ru");
            Valid("username@web-site.com.ua");
            Invalid("username website.com");
            Invalid("username @website.com");
            Invalid("username@website");
            Invalid("username@.com");
            Invalid("user@name@website.com");
        }
    }
}
