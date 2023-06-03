using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase.Test {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class TestJobDatabase {
        [Test]
        public void TryGetFirm_Should_ReturnTrueAndCorrectFirm_When_FirmExists() {
            // Arrange
            var jobDatabase = new JobDatabase();
            var firm = new Firm("Firm Name", "Contact Info");
            jobDatabase.AddFirm(firm);

            // Act
            bool result = jobDatabase.TryGetFirm("Firm Name", out var retrievedFirm);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(firm, retrievedFirm);
        }

        [Test]
        public void TryGetFirm_Should_ReturnFalseAndNull_When_FirmDoesNotExist() {
            // Arrange
            var jobDatabase = new JobDatabase();

            // Act
            bool result = jobDatabase.TryGetFirm("Non-existent Firm", out var retrievedFirm);

            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(retrievedFirm);
        }

        [Test]
        public void GetPosition_Should_ReturnCorrectPosition_When_PositionExists() {
            // Arrange
            var jobDatabase = new JobDatabase();
            var firm = new Firm("Firm Name", "Contact Info");
            var position = new Position("Position Title", "Position Description", "Position Terms", false);
            firm.AddVacancy(position);
            jobDatabase.AddFirm(firm);

            // Act
            var retrievedPosition = jobDatabase.GetPosition(position.UniqueId.ToString());

            // Assert
            Assert.AreEqual(position, retrievedPosition);
        }

        [Test]
        public void GetPosition_Should_ReturnNull_When_PositionDoesNotExist() {
            // Arrange
            var jobDatabase = new JobDatabase();

            // Act
            var retrievedPosition = jobDatabase.GetPosition("Non-existent Id");

            // Assert
            Assert.IsNull(retrievedPosition);
        }
    }

}
