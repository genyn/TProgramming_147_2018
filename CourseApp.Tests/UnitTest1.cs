using System;
using Xunit;
using Matan;
namespace CourseApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.y(0, 0);
            Assert.Equal(double.NaN, res);
        }
        [Fact]
        public void Test2()
        {
            var res = Program.y(1, 0);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.y(1, 0);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.y(2, 0);
            Assert.Equal(-0.099, res, 3);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.y( -1, 0);
            Assert.Equal(Double.PositiveInfinity, res, 3);
        }
        [Fact]
        public void Test6()
        {
            var res = Program.y( 0, 1);
            Assert.Equal(Double.NaN, res, 3);
        }
        [Fact]
        public void Test7()
        {
            var res = Program.y( 1, 1);
            Assert.Equal(Double.PositiveInfinity, res);
        }
        [Fact]
        public void Test8()
        {
            var res = Program.y(-6, 1);
            Assert.Equal(-1.555, res, 3);
        }
    }
}

