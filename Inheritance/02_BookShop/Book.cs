using System;
//title, author and price
//•	If the author’s second name is starting with a digit– exception’s message is: "Author not valid!"
//•	If the title’s length is less than 3 symbols – exception’s message is: "Title not valid!"
//•	If the price is zero or it is negative – exception’s message is: "Price not valid!"

namespace _02_BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private double price;

        public string Title
        {
            get
            {
                return this.title;
            }

            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"{nameof(this.Title)} not valid!");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            protected set
            {
                string[] namesOfAutor = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (namesOfAutor.Length >=2)
                {
                    string secondName = namesOfAutor[1];
                    char firtsSymbolOfSecondName = secondName[0];
                    if (char.IsDigit(firtsSymbolOfSecondName))
                    {
                        throw new ArgumentException($"{nameof(this.Author)} not valid!");
                    }
                }

                this.author = value;
            }
        }

        public virtual double Price
        {
            get
            {
                return this.price;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Price)} not valid!");
                }

                this.price = value;
            }
        }

        public Book(string autor, string title, double price )
        {
            this.Author = autor;
            this.Title = title;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}{Environment.NewLine}Title: {this.Title}{Environment.NewLine}Author: {this.Author}{Environment.NewLine}Price: {this.Price:F1}{Environment.NewLine}";

        }
    }
}
