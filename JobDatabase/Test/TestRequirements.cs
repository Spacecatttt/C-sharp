using JobDatabase.Expert_requirements;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase.Test {
    
    [TestFixture]
    public class TestRequirements {
        [Test]
        public void TechnicalSkills_Create_ShouldReturnTechnicalSkillsInstance() {
            // Arrange
            string skill = "Programming";

            // Act
            TechnicalSkills technicalSkills = new TechnicalSkills("Programming");

            // Assert
            Assert.IsNotNull(technicalSkills);
            Assert.AreEqual(skill, technicalSkills.Skill);
        }

        [Test]
        public void Experience_Create_ShouldReturnExperienceInstance() {
            // Arrange
            string position = "Software Developer";
            string duration = "2 years";

            // Act
            Experience experience = new Experience("Software Developer", "2 years");

            // Assert
            Assert.IsNotNull(experience);
            Assert.AreEqual(position, experience.Position);
            Assert.AreEqual(duration, experience.Duration);
        }

        [Test]
        public void Education_Create_ShouldReturnEducationInstance() {
            // Arrange
            string institutionName = "University";
            EducationLevel level = EducationLevel.BachelorDegree;

            // Act
            Education education = new Education("University",level);

            // Assert
            Assert.IsNotNull(education);
            Assert.AreEqual(institutionName, education.InstitutionName);
            Assert.AreEqual(level, education.Level);
        }

        [Test]
        public void CommunicationSkills_Create_ShouldReturnCommunicationSkillsInstance() {
            // Arrange
            string skill = "Public Speaking";

            // Act
            CommunicationSkills communicationSkills = new CommunicationSkills("Public Speaking");

            // Assert
            Assert.IsNotNull(communicationSkills);
            Assert.AreEqual(skill, communicationSkills.Skill);
        }
    }

}
