using Unit_5___Unit_testing_TDD;

namespace TestProject1
{
    public class AlgebraTests
    {
        [Fact]
        public void Algebra_Sum_Two_Numbers_equals_three()
        {
            // Arrange - creating your objects you want test!
            // sut stands for "system under test"... the thing you are testing
            var sut = new Algebra();

            // Act - calling the method you want to test (call a method and get a result)
            var result = sut.Add(1, 2);

            // Assert - predicting the "ACTED" value is EQUAL to what YOU the developer
            // expects
            Assert.Equal(3, result);

            // does restult == 3
        }

        [Fact]
        public void Algebra_Multiply_Two_Numbers_equals_thirty_five()
        {
            // Arrange
            var sut = new Algebra();

            // Act
            var result = sut.Multiply(5, 7);

            // Assert
            Assert.Equal(35, result);
        }
    }
}