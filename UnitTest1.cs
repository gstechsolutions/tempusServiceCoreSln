namespace tempus.service.core.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var num1 = 10; var num2 = 20;

            //act
            var total = num1 + num2;

            //assert
            Assert.Equal(30, total);
        }
    }
}