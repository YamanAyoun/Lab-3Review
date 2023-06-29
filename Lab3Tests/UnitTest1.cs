using Lab_3;

namespace Lab3Tests
{
    public class UnitTest1
    {
       
        [Fact]
        public void TestChallenge2()
        {
            Assert.Equal(2, Program.avarageNumber(new int[] { 1, 2, 3, 4 }, 4));
            Assert.Equal(3, Program.avarageNumber(new int[] { 4, 2, 3 }, 3));
            Assert.Equal(0, Program.avarageNumber(new int[] { 0, 0, 0, 0 }, 4));
        }

        [Fact]
        public void TestChallenge4()
        {
            Assert.Equal(1, Program.numberMost(new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }));
            Assert.Equal(2, Program.numberMost(new int[] { 1, 2, 3, 4, 2, 2 }));
            Assert.Equal(2, Program.numberMost(new int[] { 2, 2, 2, 2 }));
        }

        [Fact]
        public void TestChallenge5()
        {
            Assert.Equal(-1, Program.maximumValue(new int[] { -2, -5, -22, -1, -9, -3 }));
            Assert.Equal(2, Program.maximumValue(new int[] { 2, 2, 2, 2, 2, 2 }));
        }

    }
}