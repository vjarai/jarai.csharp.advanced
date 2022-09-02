using Xunit;

namespace Jarai.CSharp.Refresher.Relations.Tests
{
    public class PkwTests
    {
        [Fact]
        public void Fahren_erhöht_den_Tachostand()
        {
            // Arrange
            var pkw = new Pkw("VW", new Motor(100));

            // Act
            pkw.Fahren(100);

            // Assert
            Assert.Equal(100, pkw.TachoStand);
        }
    }
}