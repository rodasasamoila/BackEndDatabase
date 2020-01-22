using NUnit.Framework;
using System.Collections.Generic;

namespace BusinessLayer.Tests
{
    [TestFixture]
    class SupervisorEmailSenderShould
    {
        private SupervisorEmailSenderCommandHandler supervisorEmailSenderCommandHandler;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            supervisorEmailSenderCommandHandler = new SupervisorEmailSenderCommandHandler();
            
        }

        [Test]
        public void ThrowExceptionIfSupervisorListIsEmpty()
        {
            List<int> supervisorList = new List<int>();
            Assert.That(() => supervisorEmailSenderCommandHandler.Handle(supervisorList), Throws.Exception);
        }
    }
}
