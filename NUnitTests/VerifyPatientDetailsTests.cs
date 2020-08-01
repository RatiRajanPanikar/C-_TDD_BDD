using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit;
using NUnit.Framework;
using NUnitTests;
using OOP_Project;

namespace NUnitTests
{
    [TestFixture]
    class VerifyPatientDetailsTests
    {
        [Test]
        public void VerifyInvalidNameThrowsError()
        {
            var mock = new Mock<ImembershipVerification>();

            var instance = new PatientDetails
            {
                PatientFullName = ""
            };


            var sut = new VerifyPatientDetails(mock.Object);

            var errors = sut.Validate(instance);

            Assert.That(errors, Has.Exactly(1).EqualTo("Name cannot be blank."));
        }
    }
}
