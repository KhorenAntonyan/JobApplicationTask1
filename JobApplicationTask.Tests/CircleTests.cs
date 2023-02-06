namespace JobApplicationTask.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_radius5_78_5Returned()
        {
            //arrange
            var circle = new Circle(5);
            double expected = 78.5;

            //act
            double result = circle.GetArea();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetArea_negative_radius_ThrowsArgumentException()
        {
            //arrange
            var circle = new Circle(-5);

            //assert
            Assert.ThrowsAny<ArgumentException>(() => circle.GetArea());
        }
    }
}
