using Lab_3;

namespace Lab3Tests
{
    public class UnitTest1
    {
        [Fact]
        public void rangesOfNumbers()
        {
            string[] arr = { "4", "8", "15", "16" };
            int result = Program.avarageNumber(arr, 4);
            Assert.Equal(result, 10);
        }

        [Fact]
        public void AllNumberAreZero()
        {
            string[] arr = { "0", "0", "0", "0" };
            int result = Program.avarageNumber(arr, 4);
            Assert.Equal(result, 0);
        }
    }
}