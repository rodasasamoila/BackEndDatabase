using BusinessLayer.ScheduleRequest;
using BusinessLayer.ScheduleRequest.Abstract;
using NUnit.Framework;


namespace BusinessLayer.Tests
{
    [TestFixture]
    class SupervisorShould
    {
        private SupervisorQueryHandler supervisorList;
        private CurrentUserId currentUserId; 

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            supervisorList = new SupervisorQueryHandler();
            currentUserId = new CurrentUserId(1);
        }

        [Test]
        public void ReturnAtLeastOneSupervisor()
        {
            Assert.That(supervisorList.Handle(currentUserId).Count >= 1);
        }
    }
}
