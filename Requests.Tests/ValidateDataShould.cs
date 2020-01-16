using NUnit.Framework;
using System;

namespace BusinessLayer.Tests
{
    [TestFixture]
    class ValidateDataShould
    {
        private ValidateData validate;
        private Request request;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            validate = new ValidateData();
            request = new Request();
            request.StartHour = 8;
            request.EndHour = 17;
            DateTime ExceptionDate = DateTime.Now;
            request.ExceptionDate = ExceptionDate;
        }

        [Test]
        public void AcceptCorrectWorkHours()
        {
            Assert.IsTrue(validate.CheckWorkHours(request));
        }

        [Test]
        public void AcceptCorrectDate()
        {
            Assert.IsTrue(validate.CheckDate(request));
        }
    }
}
