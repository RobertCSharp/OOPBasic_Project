namespace Curs69OOP.BookProject
{
    public class Book
    {
        private string title;
        private string author;
        private int totalPageNumber;
        private int currentPageNumber;
        private bool isOpen;

        public Book(string title, string author, int totalPageNumber, int currentPageNumber, bool isOpen)
        {
            this.title = title;
            this.author = author;
            this.totalPageNumber = totalPageNumber;
            this.currentPageNumber = currentPageNumber;
            this.isOpen = isOpen;
        }

        public override string ToString()
        {
            return $"title: {title} author: {author} totalPageNumber: {totalPageNumber} currentPageNumber: {currentPageNumber} isOpen: {isOpen}";
        }

        public void Open()
        {
            if (isOpen)
            {
                Console.WriteLine($"the book is already open at page {currentPageNumber}");
            }
            else
            {
                Console.WriteLine($"the book is open at page {currentPageNumber}");
                isOpen = true;
            }
        }

        public void Close()
        {
            if (!isOpen)
            {
                Console.WriteLine("the book is already closed");
            }
            else
            {
                Console.WriteLine("the book is closed");
                isOpen = false;
            }
        }

        public void SkipPagesForward(int numberOfPages)
        {
            if (!isOpen)
            {
                Console.WriteLine("Sorry the book is closed. You must open the book first.");
            }
            else
            {
                if (currentPageNumber + numberOfPages > totalPageNumber)
                {
                    Console.WriteLine("Sorry too many pages.");
                }
                else
                {
                    currentPageNumber += numberOfPages;
                }
            }
        }

        public void ShowCurrentPage()
        {
            Console.WriteLine($"The current page is {currentPageNumber}");
        }

        public void SkipPagesBack(int numberOfPages)
        {
            if (!isOpen)
            {
                Console.WriteLine("Sorry you can't skip the pages back if it's closed");
            }
            else
            {
                if (currentPageNumber - numberOfPages < 0)
                {
                    Console.WriteLine("Sorry too many pages.");
                }
                else
                {
                    currentPageNumber -= numberOfPages;
                    Console.WriteLine($"You skiped {numberOfPages} pages back");
                }
            }
        }
    }
}