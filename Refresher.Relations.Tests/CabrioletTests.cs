using Moq;
using Xunit;

namespace Jarai.CSharp.Advanced.Refresher.Relations.Tests
{
    public class CabrioletTests
    {
        [Fact]
        public void Drive_WhenCalled_IncreasesOdometer()
        {
            // Arrange
            var pkw = new Cabriolet("VW", new Engine(100));

            // Act
            pkw.Drive(100);

            // Assert
            Assert.Equal(100, pkw.Odometer);
        }

        [Fact]
        public void Drive_WhenCalled_DecreasesFuelLevel()
        {
            // Arrange
            var pkw = new Cabriolet("VW", new Engine(100));

            // Act
            var tankinhaltVorher = pkw.FuelLevel;
            pkw.Drive(100);

            // Assert
            Assert.True(tankinhaltVorher > pkw.FuelLevel);
        }

        [Fact]
        public void Drive_WhenFuelInsufficient_ThrowsTankleerException()
        {
            // Arrange
            var pkw = new Cabriolet("VW", new Engine(100));

            // Assert
            Assert.Throws<FuelEmptyException>(() => pkw.Drive(1000));
        }

        [Fact]
        public void Drive_WhenCalled_StartsEngine()
        {
            // Arrange
            var engineMock = new Mock<Engine>(100);
            var target = new Cabriolet("VW", engineMock.Object);

            // Act
            engineMock.Setup(mock => mock.Start());
            target.Drive(100);

            // Assert
            engineMock.VerifyAll();
        }
    }
}