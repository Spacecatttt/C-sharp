using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JobDatabase.Test {

    [TestFixture]
    public class TestFirm {
        [Test]
        public void AddVacancy_Should_AddPositionToVacanciesList() {
            // Arrange
            var firm = new Firm("Firm Name", "Contact Info");
            var position = new Position("Position Title", "Position Description", "Position Terms", false);

            // Act
            firm.AddVacancy(position);

            // Assert
            Assert.Contains(position, firm.Vacancies);
            Assert.AreEqual(firm, position.Firm);
        }

        [Test]
        public void RemoveVacancy_Should_RemovePositionFromVacanciesList() {
            // Arrange
            var firm = new Firm("Firm Name", "Contact Info");
            var position = new Position("Position Title", "Position Description", "Position Terms", false);
            firm.AddVacancy(position);

            // Act
            firm.Vacancies.Remove(position);

            // Assert
            Assert.IsEmpty(firm.Vacancies);
        }
    }
}
