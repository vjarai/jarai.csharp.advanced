using Xunit;

namespace Jarai.CSharp.Advanced.Refresher.Relations.Tests
{
    public class LkwTests
    {
        [Fact()]
        public void Ladung_ist_nicht_null_nach_Beladen()
        {
           // Arrange
           var lkw = new Lkw("MAN");

           // Act
           lkw.Beladen();

           // Assert
           Assert.NotNull(lkw.Ladung);
        }
    }
}