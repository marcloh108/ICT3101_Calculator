using Moq;
using NUnit.Framework;
using ICT3101_Calculator;

namespace ICT3101_Calculator.UnitTests
{
    [TestFixture]
    internal class AdditionalCalculatorTests
    {
        private Calculator _calculator = null!;
        private Mock<IFileReader> _mockFileReader = null!;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();

            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader
                .Setup(fr => fr.Read(It.IsAny<string>()))
                .Returns(new[] { "-2", "50" });
        }

        [Test]
        public void GenMagicNum_Index0_NegativeLine_ReturnsPositiveDoubleMagnitude()
        {
            // index 0 -> "-2" -> -2 * (-2) = 4
            var result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void GenMagicNum_Index1_PositiveLine_ReturnsDoubleValue()
        {
            // index 1 -> "50" -> 2 * 50 = 100
            var result = _calculator.GenMagicNum(1, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void GenMagicNum_IndexOutOfRange_DefaultsToZero_DoubledStaysZero()
        {
            var result = _calculator.GenMagicNum(999, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
