using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        private FileReader getTheMagic;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            // Lab 4 Q4
            getTheMagic = new FileReader();
        }
        // MethodNameWe’reTesting_ScenarioWe’reTesting_ExpectedBehaviourOrResult
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Multiply_WhenMultiplyTwoNumbers_ResultEqualToProduct()
        {
            // Act
            double result = _calculator.Multiply(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivision()
        {
            // Act
            double result = _calculator.Divide(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
        /*[Test]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }*/

        [Test]
        public void Factorial_WhenFactorial_ResultEqualToFactorial()
        {
            // Act
            double result = _calculator.Factorial(5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void AreaTriangle_WhenGettingAreaOfTriangle_ResultEqualToArea()
        {
            // Act
            double result = _calculator.AreaTriangle(3,2);
            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 5)]
        [TestCase(5, 0)]
        public void AreaTriangle_WhenInputsAreLessOrEqualToZeros_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.AreaTriangle(a,b), Throws.ArgumentException);
        }

        [Test]
        public void AreaCircle_WhenGettingAreaOfCircle_ResultEqualToArea()
        {
            // Act
            double result = _calculator.AreaCircle(5);
            // Assert
            Assert.That(result, Is.EqualTo(78.54));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void AreaCircle_WhenInputsAreLessOrEqualToZeroOrDecimal_ResultThrowArgumentException(double a)
        {
            Assert.That(() => _calculator.AreaCircle(a), Throws.ArgumentException);
        }

        // UnknownFunctionA aka Permutation
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
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {

            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {

            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        // UnknownFunctionB aka Combination
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
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
        //-1,0,1
        public void MagicNumber_WithChoiceNegative_ResultIsZero()
        {
            double result = _calculator.GenMagicNum(-1, getTheMagic);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void MagicNumber_StringRetrievedIsPositiveNumber_ResultIsDoubleTheNumber()
        {
            double result = _calculator.GenMagicNum(0, getTheMagic);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void MagicNumber_WithStringRetrievedIsNegativeNumber_ResultIsPositiveAndDoubleTheNumber()
        {
            double result = _calculator.GenMagicNum(1, getTheMagic);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MagicNumber_WithStringRetrievedIsZero_ResultIsZero()
        {
            double result = _calculator.GenMagicNum(2, getTheMagic);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void MagicNumber_WithChoiceNumberEqualsToNumberOfLines_ResultIsZero()
        {

            double result = _calculator.GenMagicNum(4, getTheMagic);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MagicNumber_WithChoiceMoreThanNumberOfLines_ResultIsZero()
        {
            double result = _calculator.GenMagicNum(5, getTheMagic);
            Assert.That(result, Is.EqualTo(0));
        }

    }

}