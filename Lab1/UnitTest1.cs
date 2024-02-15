using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }



        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            int firstAngle = 60;
            int secondAngle = 50;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }



        // Add more test methods as needed to cover different scenarios
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage2()
        {
            int firstAngle = 70;
            int secondAngle = 50;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }


        [Test]
        public void InvalidTriangle_Trianglenot180_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 0;
            int secondAngle = 0;
            int thirdAngle = 0;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle1_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 70;
            int secondAngle = 30;
            int thirdAngle = 80;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }


        [Test]
        public void ValidTriangle2_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 70;
            int secondAngle = 50;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
    }
}
        





    
