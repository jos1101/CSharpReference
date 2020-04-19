using System;
using Xunit;


namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            log += ReturnMessage;
            log += IncrementCount;


            var result = log("Hello!");
            Assert.Equal(3, count);
            Assert.Equal("Hello!", result);
        }

        private string ReturnMessage(string message)
        {
            count++;
            return message;
        }
        private string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "James";
            var upper = MakeUppercase(name);
            
            Assert.Equal("James", name);
            Assert.Equal("JAMES", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref Int32 z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
         public void CSharpCanPassByRef()
        {
            // arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            // act

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book1, string name)
        {
            book1.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            // act

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }
        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            // act

            // assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
