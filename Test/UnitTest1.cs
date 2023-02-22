using Operations;

namespace Test
{
    [TestClass]
    public class MathOperationsTest
    {
        [TestMethod]
        public void Test_Add_Method()
        {
            // Arrange.
            Double firstA = 5.32;
            Double firstB = -94.13;

            Double secondA = 0.132;
            Double secondB = -0.132;

            Double thirdA = 1233.11;
            Double thirdB = 5767.0;

            // Act.
            Double actualFirst = MathOperations.Add(firstA, firstB);
            Double actualSecond = MathOperations.Add(secondA, secondB);
            Double actualThird = MathOperations.Add(thirdA, thirdB);


            // Assert.
            Assert.AreEqual(-88.81, actualFirst);
            Assert.AreEqual(0, actualSecond);
            Assert.AreEqual(7000.11, actualThird);
        }

        [TestMethod]
        public void Test_Substract_Method()
        {
            // Arrange.
            Double firstA = 5.32;
            Double firstB = -94.13;

            Double secondA = 0.132;
            Double secondB = -0.132;

            Double thirdA = 1233.11;
            Double thirdB = 5767.0;

            // Act.
            Double actualFirst = MathOperations.Substract(firstA, firstB);
            Double actualSecond = MathOperations.Substract(secondA, secondB);
            Double actualThird = MathOperations.Substract(thirdA, thirdB);


            // Assert.
            Assert.AreEqual(99.45, actualFirst, 0.1);
            Assert.AreEqual(0.264, actualSecond, 0.1);
            Assert.AreEqual(-4533.89, actualThird, 0.1);
        }

        [TestMethod]
        public void Test_Multiply_Method()
        {
            // Arrange.
            Double firstA = 5.32;
            Double firstB = -94.13;

            Double secondA = 0.132;
            Double secondB = -0.132;

            Double thirdA = 1233.11;
            Double thirdB = 5767.0;

            // Act.
            Double actualFirst = MathOperations.Multiply(firstA, firstB);
            Double actualSecond = MathOperations.Multiply(secondA, secondB);
            Double actualThird = MathOperations.Multiply(thirdA, thirdB);


            // Assert.
            Assert.AreEqual(-500.7716, actualFirst, 0.1);
            Assert.AreEqual(-0.015129, actualSecond, 0.1);
            Assert.AreEqual(7111345.37, actualThird, 0.1);
        }
        
        [TestMethod]
        public void Test_Divide_Method()
        {
            // Arrange.
            Double firstA = 5.32;
            Double firstB = -94.13;

            Double secondA = 0.132;
            Double secondB = -0.132;

            Double thirdA = 1233.11;
            Double thirdB = 5767.0;

            // Act.
            Double actualFirst = MathOperations.Divide(firstA, firstB);
            Double actualSecond = MathOperations.Divide(secondA, secondB);
            Double actualThird = MathOperations.Divide(thirdA, thirdB);

            // Assert.
            Assert.AreEqual(-0.0565, actualFirst, 0.1);
            Assert.AreEqual(-1, actualSecond, 0.1);
            Assert.AreEqual(0.21, actualThird, 0.1);

        }

        [TestMethod]
        public void Test_Divide_Method_DividedByZeroException()
        {
            // Arrange.
            Double firstA = 5.32;
            Double firstB = 0;

            Double secondA = 0.132;
            Double secondB = 0;

            Double thirdA = 1233.11;
            Double thirdB = 0;

            // Act.
            try
            {
                Double actualFirst = MathOperations.Divide(firstA, firstB);

            }
            // Assert.
            catch (Exception ex) { Assert.AreEqual("Can`t divide by zero", ex.Message); }

            // Act.
            try
            {
                Double actualSecond = MathOperations.Divide(secondA, secondB);

            }
            // Assert.

            catch (Exception ex) { Assert.AreEqual("Can`t divide by zero", ex.Message); }
            // Act.
            try
            {
                Double actualThird = MathOperations.Divide(thirdA, thirdB);

            }
            // Assert.
            catch (Exception ex) { Assert.AreEqual("Can`t divide by zero", ex.Message); }
        }

        [TestMethod]
        public void Test_SquareRoot_Method()
        {
            // Arrange.
            Double firstA = 9;

            Double secondA = 3.14;

            Double thirdA = 196.9;

            // Act.
            Double actualFirst = MathOperations.SquareRoot(firstA);
            Double actualSecond = MathOperations.SquareRoot(secondA);
            Double actualThird = MathOperations.SquareRoot(thirdA);

            // Assert.
            Assert.AreEqual(3, actualFirst, 0.1);
            Assert.AreEqual(1.77, actualSecond, 0.1);
            Assert.AreEqual(14.03, actualThird, 0.1);
        }

        [TestMethod]
        public void Test_SquareRoot_Method_NegativeRootException()
        {
            // Arrange.
            Double firstA = -9;

            Double secondA = -3.14;

            Double thirdA = -196.9;

            // Act.
            try
            {
                Double actualFirst = MathOperations.SquareRoot(firstA);

            }
            // Assert.
            catch (Exception ex) { Assert.AreEqual("Can`t calculate root", ex.Message); }

            // Act.
            try
            {
                Double actualSecond = MathOperations.SquareRoot(secondA);

            }
            // Assert.

            catch (Exception ex) { Assert.AreEqual("Can`t calculate root", ex.Message); }
            // Act.
            try
            {
                Double actualThird = MathOperations.SquareRoot(thirdA);

            }
            // Assert.
            catch (Exception ex) { Assert.AreEqual("Can`t calculate root", ex.Message); }
        }

        [TestMethod]
        public void Test_Cos_Method()
        {
            // Arrange.
            Double firstA = 30;

            Double secondA = 60;

            Double thirdA = -60;

            // Act.
            Double actualFirst = MathOperations.Cos(firstA);
            Double actualSecond = MathOperations.Cos(secondA);
            Double actualThird = MathOperations.Cos(thirdA);

            // Assert.
            Assert.AreEqual(0.86, actualFirst, 0.1);
            Assert.AreEqual(0.5, actualSecond, 0.1);
            Assert.AreEqual(0.5, actualThird, 0.1);
        }

        [TestMethod]
        public void Test_OneDividedBy_Method()
        {
            // Arrange.
            Double firstA = 5.32;

            Double secondA = -0.132;

            Double thirdA = 0.5;

            // Act.
            Double actualFirst = MathOperations.OneDividedBy(firstA);
            Double actualSecond = MathOperations.OneDividedBy(secondA);
            Double actualThird = MathOperations.OneDividedBy(thirdA);

            // Assert.
            Assert.AreEqual(0.19, actualFirst, 0.1);
            Assert.AreEqual(-7.57, actualSecond, 0.1);
            Assert.AreEqual(2, actualThird, 0.1);

        }

        [TestMethod]
        public void Test_OneDividedBy_Method_DividedByZeroException()
        {
            // Arrange.
            Double firstA = 0.0;

            Double secondA = 0;

            Double thirdA = 0.01;

            // Act.
            try
            {
                Double actualFirst = MathOperations.OneDividedBy(firstA);

            }
            // Assert.
            catch (Exception ex) { Assert.AreEqual("Can`t divide by zero", ex.Message); }

            // Act.
            try
            {
                Double actualSecond = MathOperations.OneDividedBy(secondA);

            }
            // Assert.

            catch (Exception ex) { Assert.AreEqual("Can`t divide by zero", ex.Message); }
            // Act.
            try
            {
                Double actualThird = MathOperations.OneDividedBy(thirdA);

            }
            // Assert.
            catch (Exception ex) { Assert.AreEqual("Can`t divide by zero", ex.Message); }
        }
    }

    [TestClass]
    public class DigitsTest
    {
        [TestMethod]
        public void Test_Clear_Method()
        {
            // Arrange.
            Digits actualFirst = new Digits();
            actualFirst.ValueOfA = 5.32;
            actualFirst.ValueOfB = -94.13;

            Digits actualSecond = new Digits();
            actualSecond.ValueOfA = 93.11;
            actualSecond.ValueOfB = 0.132;

            Digits actualThird = new Digits();
            actualThird.ValueOfA = 1233.11;
            actualThird.ValueOfB = 5767.0;

            // Act.
            actualFirst.Clear();
            actualSecond.Clear();
            actualThird.Clear();

            // Assert.
            Assert.AreEqual(0, actualFirst.ValueOfA);
            Assert.AreEqual(0, actualFirst.ValueOfB);

            Assert.AreEqual(0, actualSecond.ValueOfA);
            Assert.AreEqual(0, actualSecond.ValueOfB);

            Assert.AreEqual(0, actualThird.ValueOfA);
            Assert.AreEqual(0, actualThird.ValueOfB);
        }

        [TestMethod]
        public void Test_ValueOfA_Property() 
        {
            // Arrange.
            Digits actualFirst = new Digits();
            Digits actualSecond = new Digits();
            Digits actualThird = new Digits();

            // Act.
            actualFirst.ValueOfA = 5.32;
            actualSecond.ValueOfA = 0.5;
            actualThird.ValueOfA = -31.52;

            // Assert.
            Assert.AreEqual(5.32, actualFirst.ValueOfA);
            Assert.AreEqual(0.5, actualSecond.ValueOfA);
            Assert.AreEqual(-31.52, actualThird.ValueOfA);

        }

        [TestMethod]
        public void Test_ValueOfB_Property()
        {
            // Arrange.
            Digits actualFirst = new Digits();
            Digits actualSecond = new Digits();
            Digits actualThird = new Digits();

            // Act.
            actualFirst.ValueOfB = 1.364;
            actualSecond.ValueOfB = 4.1;
            actualThird.ValueOfB = -231.52;

            // Assert.
            Assert.AreEqual(1.364, actualFirst.ValueOfB);
            Assert.AreEqual(4.1, actualSecond.ValueOfB);
            Assert.AreEqual(-231.52, actualThird.ValueOfB);
        }
    }
}