using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookManagement.Test
{
    [TestClass]
    public class BookRepositoryMethodTest
    {

        [TestMethod]
        public void RetrieveAllOrders()
        {
            var books = CreateBooksRepository();

            var result = books.RetrieveAllBooks().Count();
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void RetrieveOrderByYearDescending()
        {
            var books = CreateBooksRepository();

            var result1 = books.RetrieveAllOrderByYearDescending().First().Title.Should().Be("Poirot Investigates");
        }

        [TestMethod]
        public void RetrieveOrderByYearAscending()
        {
            var books = CreateBooksRepository();

            var result1 = books.RetrieveAllOrderByYearAscending().First().Title.Should().Be("The Mysterious Affair at Styles");
        }

        [TestMethod]
        public void RetrieveOrderByPriceAscending()
        {
            var books = CreateBooksRepository();

            var result1 = books.RetriveAllOrderByPriceAscending().First().Title.Should().Be("The Mysterious Affair at Styles");
        }

        [TestMethod]
        public void RetrieveOrderByPriceDescending()
        {
            var books = CreateBooksRepository();

            var result1 = books.RetriveAllOrderByPriceDescending().First().Title.Should().Be("The Murder on the Links");
        }

        [TestMethod]
        public void Give_ABookRepositoryInstance_When_Genre_Is_Given()
        {
            var books = CreateBooksRepository();

            var booksGroupedByGenre = books.RetriveAllBooksGroupedByGenre();

            booksGroupedByGenre[Genre.NonFiction].Count.Should().Be(1);
            booksGroupedByGenre[Genre.Fiction].Count.Should().Be(2);
        }


        private BookRepositoryMethod CreateBooksRepository()
        {
            var bookRepository = new BookRepositoryMethod(
                new List<Book>
                {
                    Book.Create("The Mysterious Affair at Styles", 1920, 14, Genre.Fiction),
                    Book.Create("The Murder on the Links", 1923, 56, Genre.NonFiction),
                    Book.Create("Poirot Investigates", 1924, 44, Genre.Fiction)
                });
            return bookRepository;
        }
    }
}
