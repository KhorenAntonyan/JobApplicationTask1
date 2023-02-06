namespace JobApplicationTask.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_a5_b7_c9_17_41Returned()
        {
            //arrange
            var triangle = new Triangle(5, 7, 9);
            double expected = 17.41228014936585;

            //act
            double result = triangle.GetArea();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsRectangular_a6_b8_c10_TrueReturned()
        {
            //arrange
            var triangle = new Triangle(6, 8, 10);
            bool expected = true;

            //act
            bool result = triangle.IsRectangular();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsRectangular_a5_b7_c9_FalseReturned()
        {
            //arrange
            var triangle = new Triangle(5, 7, 9);
            bool expected = false;

            //act
            bool result = triangle.IsRectangular();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsValidTriangle_a3_b3_c7_ThrowsArgumentException()
        {
            //arrange
            var triangle = new Triangle(3, 3, 7);

            //assert
            Assert.ThrowsAny<ArgumentException>(() => triangle.GetArea());
        }
    }
}
