using BusinessLayer.ScheduleRequest.Commands;
using BusinessLayer.ScheduleRequest.Validator;
using NUnit.Framework;
using System;

namespace BusinessLayer.Tests
{
    [TestFixture]
    class ValidateDataShould
    {
        private ValidateData validate;
        private AddScheduleRequestCommand request;
        private ScheduleLimitsQueryHandler scheduleLimits;
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            scheduleLimits = new ScheduleLimitsQueryHandler();
            validate = new ValidateData(scheduleLimits);
            request = new AddScheduleRequestCommand();
            request.StartHour = 8;
            request.EndHour = 17;
            request.ExceptionDate = DateTime.Now;
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
