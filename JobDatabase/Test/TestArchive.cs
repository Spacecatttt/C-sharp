using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase.Test {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class TestArchive {
        [Test]
        public void AddArchive_Should_AddPositionToArchivedPositionsList() {
            // Arrange
            var archive = new Archive();
            var position = new Position("Position Title", "Position Description", "Position Terms", false);

            // Act
            archive.AddArchive(position);

            // Assert
            Assert.AreEqual(1, archive.GetCount());

        }

        [Test]
        public void DeleteArchived_Should_RemovePositionFromArchivedPositionsList() {
            // Arrange
            var archive = new Archive();
            var position = new Position("Position Title", "Position Description", "Position Terms", false);
            archive.AddArchive(position);

            // Act
            archive.DeleteArchived(position);

            // Assert
            Assert.AreEqual(0, archive.GetCount());

        }
    }

}
