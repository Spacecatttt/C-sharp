using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase.Test {
    [TestFixture]
    public class TestPosition {
        [Test]
        public void GetTitleAndSalary_Should_ReturnTitleAndSalaryString() {
            // Arrange
            var position = new Position("Position Title", "Position Description", "Position Terms", false);

            // Act
            string result = position.GetTitleAndSalary();

            // Assert
            Assert.AreEqual("Посада: Position Title    Зарплата: Position Terms", result);
        }

        [Test]
        public void GetDescription_Should_ReturnDescriptionStringWithRequirements() {
            // Arrange
            var firm = new Firm("Firm Name", "Contact Info");
            var position = new Position("Position Title", "Position Description", "Position Terms", false);
            firm.AddVacancy(position);

            // Act
            string result = position.GetDescription();

            // Assert
            Assert.AreEqual("Посада: Position Title    Зарплата: Position Terms\n" +
                "Контактна інформація: Contact Info\n" +
                "Опис: Position Description\n", result);
        }
    }
}
