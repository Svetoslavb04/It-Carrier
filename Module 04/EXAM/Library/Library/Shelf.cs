using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Shelf
    {
        private Book head;
        private Book tail;
        private int count;

        public Shelf()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }


        public void AddBook(string bookId)
        {
            Book newBook = new Book(bookId);

            if (head == null)
            {
                this.head = newBook;
                this.tail = newBook;
                this.head.Next = newBook;
                count++;
            }
            else if(count == 1)
            {
                this.head.Next = newBook;
                this.tail = newBook;
                count++;
            }
            else                                  
            {
                this.tail.Next = newBook;
                this.tail = newBook;
                count++;
            }
        }
        public void AddSpecialBook(string bookId)
        {
            Book specialBook = new Book(bookId);

            Book headBook = this.head;

            this.head = specialBook;
            this.head.Next = headBook;

            this.count++;
        }

        public Book CheckBookIsPresent(string bookId)
        {
            Book currentBook = this.head;
            Book prevBook = null;

            while (currentBook != null)
            {
                if (currentBook.BookId == bookId)
                {
                    return currentBook;
                }

                prevBook = currentBook;
                currentBook = currentBook.Next;
            }

            return null;
        }

        public bool ReleaseBook(string bookId)
        {
            Book currentBook = this.head;
            Book prevBook = null;

            while (currentBook != null)
            {
                if (currentBook.BookId == bookId)
                {
                    if (prevBook == null)
                    {
                        this.head = currentBook.Next;
                    }
                    else
                    {
                        prevBook.Next = currentBook.Next;

                    }

                    if (currentBook.Next == null)
                    {
                        this.tail = prevBook;
                    }

                    count--;
                    return true;
                }

                prevBook = currentBook;
                currentBook = currentBook.Next;
            }

            return false;
        }

        public bool ReleaseBook(int index)
        {
            if (index < 0)
            {
                return false;
            }
            
            int currentIndex = 0;
            Book currentBook = this.head;
            Book prevBook = null;

            while (currentBook != null)
            {
                if (currentIndex == index)
                {
                    count--;

                    if (prevBook == null)
                    {
                        this.head = currentBook.Next;
                    }
                    else
                    {
                        prevBook.Next = currentBook.Next;
                    }

                    if (currentBook.Next == null)
                    {
                        this.tail = prevBook;
                    }

                    return true;
                }

                prevBook = currentBook;
                currentBook = currentBook.Next;
                currentIndex++;
            }

            return false;
        }

        public StringBuilder ShelfInformation()
        {
            var sb = new StringBuilder();

            if (count == 0)
            {
                sb.AppendLine("<Shelf is empty!>");

                return sb;
            }

            Book currentBook = this.head;

            while (currentBook != null)
            {
                sb.AppendLine(currentBook.ToString());

                currentBook = currentBook.Next;
            }

            return sb;
        }
    }
}
