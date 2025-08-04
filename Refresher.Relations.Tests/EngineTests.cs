using Xunit;

namespace Jarai.CSharp.Advanced.Refresher.Relations.Tests
{
    public class EngineTests
    {
        [Fact]
        public void Start_WhenAlreadyStarted_ThrowsInvalidOperationException()
        {
            // Arrange
            var Engine = new Engine(100);

            // Act
            Engine.Start();

            // Assert
            Assert.Throws<InvalidOperationException>(Engine.Start);
        }

        [Fact]
        public void Stop_WhenCalled_EngineIsNotRunning()
        {
            // Arrange
            var Engine = new Engine(100);

            // Act
            Engine.Start();
            Engine.Stop();

            // Assert
            Assert.False(Engine.IsRunning);
        }

        [Fact]
        public void Start_WhenCalled_EngineIsRunning()
        {
            // Arrange
            var Engine = new Engine(100);

            // Act
            Engine.Start();

            // Assert
            Assert.True(Engine.IsRunning);
        }
    }
}