﻿using System;
//You are working in a library. And you are pissed of writing descriptions for books by hand, so you wanted to use the computer to make them faster. So the task is 
//simple. Your program should have two classes – one for the ordinary books – Book, and another for the special ones – GoldenEditionBook. So let’s get started! 
//We need two classes:
//•	Book - represents a book that holds title, author and price.A book should offer information about itself in the format shown in the output below.
//•	GoldenEditionBook - represents a special book holds the same properties as any Book, but its price is always 30% higher

namespace _02_BookShop
{
  public  class BookShop
    {
      public  static void Main()
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
