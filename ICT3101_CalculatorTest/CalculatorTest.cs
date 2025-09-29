using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // --- Add ---
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            double result = _calculator.Add(10, 20);
            Assert.That(result, Is.EqualTo(30));
        }

        // --- Subtract ---
        [TestCase(10, 3, 7)]
        [TestCase(-2, -5, 3)]
        [TestCase(0, 0, 0)]
        public void Subtract_WhenCalled_ReturnsDifference(double a, double b, double expected)
        {
            Assert.That(_calculator.Subtract(a, b), Is.EqualTo(expected));
        }

        // --- Multiply ---
        [TestCase(4, 5, 20)]
        [TestCase(-4, 5, -20)]
        [TestCase(0, 5, 0)]
        public void Multiply_WhenCalled_ReturnsProduct(double a, double b, double expected)
        {
            Assert.That(_calculator.Multiply(a, b), Is.EqualTo(expected));
        }

        // --- Divide (edge cases with zeros will be added in Step 14) ---
        [TestCase(20, 5, 4)]
        [TestCase(-20, 5, -4)]
        public void Divide_WhenNonZeroInputs_ReturnsQuotient(double a, double b, double expected)
        {
            Assert.That(_calculator.Divide(a, b), Is.EqualTo(expected));
        }

        // Step 14a/b — Divide with zero(s) throws
        [Test]
        [TestCase(0, 0, 1)]
        [TestCase(0, 10, 0)]
        public void Divide_WithZerosAsInputs_ReturnsExpected(double a, double b, double expected)
        {
            var result = _calculator.Divide(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        public void Divide_ByZero_ReturnsPositiveInfinity()
        {
            var result = _calculator.Divide(10, 0);
            Assert.That(double.IsPositiveInfinity(result), Is.True);
        }

        // Factorial tests
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(5, 120)]
        public void Factorial_WhenNonNegativeInput_ReturnsNFactorial(int n, int expected)
        {
            Assert.That(_calculator.Factorial(n), Is.EqualTo(expected));
        }

        [Test]
        public void Factorial_WhenNegativeInput_ThrowsArgumentException()
        {
            Assert.That(() => _calculator.Factorial(-3), Throws.ArgumentException);
        }

        //TDD qn16a
        [Test]
        public void TriangleArea_WithPositiveBaseAndHeight_ReturnsCorrectResult()
        {
            double result = _calculator.TriangleArea(10, 5);
            Assert.That(result, Is.EqualTo(25));  // (10*5)/2
        }

        [Test]
        public void TriangleArea_WithZeroBaseOrHeight_ReturnsZero()
        {
            Assert.That(_calculator.TriangleArea(0, 5), Is.EqualTo(0));
            Assert.That(_calculator.TriangleArea(10, 0), Is.EqualTo(0));
        }

        [Test]
        public void TriangleArea_WithNegativeInputs_ThrowsArgumentException()
        {
            Assert.That(() => _calculator.TriangleArea(-10, 5), Throws.ArgumentException);
            Assert.That(() => _calculator.TriangleArea(10, -5), Throws.ArgumentException);
        }

        //TDD qn16b
        [Test]
        public void CircleArea_WithPositiveRadius_ReturnsCorrectResult()
        {
            double result = _calculator.CircleArea(3);
            Assert.That(result, Is.EqualTo(Math.PI * 9).Within(0.0001));
        }

        [Test]
        public void CircleArea_WithZeroRadius_ReturnsZero()
        {
            Assert.That(_calculator.CircleArea(0), Is.EqualTo(0));
        }

        [Test]
        public void CircleArea_WithNegativeRadius_ThrowsArgumentException()
        {
            Assert.That(() => _calculator.CircleArea(-3), Throws.ArgumentException);
        }

        // UnknownFunctionA (nPr)
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            double result = _calculator.UnknownFunctionA(5, 5);
            Assert.That(result, Is.EqualTo(120));
        }


        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            double result = _calculator.UnknownFunctionA(5, 4);
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            double result = _calculator.UnknownFunctionA(5, 3);
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        // UnknownFunctionB (nCr)
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            double result = _calculator.UnknownFunctionB(5, 5);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            double result = _calculator.UnknownFunctionB(5, 4);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            double result = _calculator.UnknownFunctionB(5, 3);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

    }
}