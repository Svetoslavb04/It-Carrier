using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        private string id;
        private Book next;

        public string BookId
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public Book Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Book(string bookId)
        {
            this.BookId = bookId;
        }

        public override string ToString()
        {
            return $"Book: {id}";
        }
    }
}
