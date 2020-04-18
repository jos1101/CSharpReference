using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void HighestGradeTest()
        {
            // arrange
            var book = new Book("Test Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var expectedHighGrade = 90.5;
            var actualHighGrade = book.HighestGrade();

            // assert
            Assert.Equal(expectedHighGrade, actualHighGrade);
        }

        [Fact]
        public void LowestGradeTest()
        {
            // arrange
            var book = new Book("Test Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var expectedLowestGrade = 77.3;
            var actualLowestGrade = book.LowestGrade();

            // assert
            Assert.Equal(expectedLowestGrade, actualLowestGrade);
        }

        [Fact]
        public void AverageGradeTest()
        {
            // arrange
            var book = new Book("Test Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var expectedAverageGrade = (89.1+90.5+77.3)/3;
            var actualAverageGrade = book.AverageGrade();

            // assert
            Assert.Equal(expectedAverageGrade, actualAverageGrade);
        }

    }
}
