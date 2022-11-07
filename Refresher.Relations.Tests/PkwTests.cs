using Moq;
using Xunit;

namespace Jarai.CSharp.Advanced.Refresher.Relations.Tests
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

        [Fact]
        public void Fahren_mindert_den_Tankinhalt()
        {
            // Arrange
            var pkw = new Pkw("VW", new Motor(100));

            // Act
            var tankinhaltVorher = pkw.Tankinhalt;
            pkw.Fahren(100);

            // Assert
            Assert.True(tankinhaltVorher > pkw.Tankinhalt);
        }

        [Fact]
        public void Fahren_throws_TankleerException()
        {
            // Arrange
            var pkw = new Pkw("VW", new Motor(100));

            // Assert
            Assert.Throws<TankleerException>(() => pkw.Fahren(1000));
        }


        [Fact]
        public void Fahren_startet_motor()
        {
            // Arrange
            var motorMock = new Mock<Motor>(100);
            var target = new Pkw("VW", motorMock.Object);

            // Act
            // Erwartung: Anlassen wird aufgerufen
            motorMock.Setup(mock => mock.Start());
            target.Fahren(100);

            // Assert
            // Erwartungen erfüllt?
            motorMock.VerifyAll();
        }
    }
}