using System;
using Xunit;

namespace Jarai.CSharp.Refresher.Relations.Tests
{
    public class MotorTests
    {
        [Fact]
        public void Can_NOT_start_motor_twice()
        {
            // Arrange
            var motor = new Motor(100);

            // Act
            motor.Start();

            // Assert
            Assert.Throws<InvalidOperationException>(motor.Start);
        }

        [Fact]
        public void Motor_is_NOT_running_after_Stop()
        {
            // Arrange
            var motor = new Motor(100);

            // Act
            motor.Start();
            motor.Stop();

            // Assert
            Assert.False(motor.IstAngelassen);
        }

        [Fact]
        public void Motor_is_running_after_Start()
        {
            // Arrange
            var motor = new Motor(100);

            // Act
            motor.Start();

            // Assert
            Assert.True(motor.IstAngelassen);
        }
    }
}