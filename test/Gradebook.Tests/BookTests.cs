using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(82.5);
            book.AddGrade(91.4);
            book.AddGrade(76.2);

            // act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(83.4,result.Average, 1);
            Assert.Equal(91.4, result.High, 1);
            Assert.Equal(76.2, result.Low, 1);

        }
    }
}
