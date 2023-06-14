using Xunit;

namespace Jarai.CSharp.Pattern.State.Tests
{
    public class TelefonTests
    {
        [Fact()]
        public void Kann_abheben_wählen_sprechen_sprechen_auflegen() // Happy Path
        {
            // Arrange
            var telefon = new Telefon();

            // Act
            telefon.Abheben();
            telefon.Wählen();
            telefon.Sprechen();
            telefon.Sprechen();
            telefon.Auflegen();
        }


        [Fact()]
        public void Kann_annehmenAnruf_auflegen()
        {
            // Arrange
            var telefon = new Telefon();

            // Act
            telefon.AnnehmenAnruf();
            telefon.Auflegen();

        }

        [Fact()]
        public void Kann_abheben_auflegen()
        {
            // Arrange
            var telefon = new Telefon();

            // Act
            telefon.Abheben();
            telefon.Auflegen();

        }

        [Fact()]
        public void Kann_NICHT_im_Zustand_Abgehoben_sprechen()
        {
            // Arrange
            var telefon = new Telefon();
            telefon.Abheben();

            // Act
            
            // Assert
            Assert.Throws<InvalidOperationException>(telefon.Sprechen);
        }


        [Fact()]
        public void Kann_NICHT_im_Zustand_Verbunden_wählen()
        {
            // Arrange
            var telefon = new Telefon();
            telefon.AnnehmenAnruf();

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(telefon.Wählen);
        }

        [Fact()]
        public void Kann_NICHT_im_Zustand_Verbunden_abheben()
        {
            // Arrange
            var telefon = new Telefon();
            telefon.AnnehmenAnruf();

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(telefon.Abheben);
        }

        [Fact()]
        public void Kann_NICHT_im_Zustand_Verbunden_annehmenAnruf()
        {
            // Arrange
            var telefon = new Telefon();
            telefon.AnnehmenAnruf();

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(telefon.AnnehmenAnruf);
        }


        [Fact()]
        public void Kann_NICHT_im_Zustand_Abgehoben_annehmenAnruf()
        {
            // Arrange
            var telefon = new Telefon();
            telefon.Abheben();

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(telefon.AnnehmenAnruf);
        }

        [Fact()]
        public void Kann_NICHT_im_Zustand_Aufgelegt_wählen()
        {
            // Arrange
            var telefon = new Telefon();

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(telefon.Wählen);
        }

        [Fact()]
        public void Kann_NICHT_im_Zustand_Aufgelegt_sprechen()
        {
            // Arrange
            var telefon = new Telefon();

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(telefon.Sprechen);
        }

        [Fact()]
        public void Kann_NICHT_im_Zustand_Aufgelegt_auflegen()
        {
            // Arrange
            var telefon = new Telefon();

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(telefon.Auflegen);
        }


        [Fact()]
        public void Kann_NICHT_im_Zustand_Abgehoben_abheben()
        {
            // Arrange
            var telefon = new Telefon();
            telefon.Abheben();

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(telefon.Abheben);
        }


    }
}