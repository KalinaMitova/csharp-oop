using System;

//You are young programmer and your Boss is giving you a task to create a tool which is drawing figures on the console. He knows you are not so
//good at OOP tasks so he told you to create only single class - CorDraw. Its task is to draw rectangular figures on the screen.
//CorDraw’s constructor should take as parameter a Square instance or a Rectangle instance, extract its characteristics and draw the figure.Like
//we said your Boss is a good guy and he has some more info for you:
//One of your classes should be a class named Square that should have only one method – Draw() which uses the length of the square’s sides and 
//draws them on the console.For horizontal lines, use dashes ("-") and spaces(" "). For vertical lines – pipes("|"). If the size of the figure is 
//6, dashes should also be 6. 
//Hint
//Search in internet for abstract classes and try implementing one.This will help you to reduce input parameter in the CorDraw’s constructor
//to a single one.

namespace _13_DrawingTool
{
    public class Rectangle
    {

        public static void Draw (int width, int height=0)
        {
            if (height == 0)
            {
                height = width;
            }
            Console.WriteLine("|{0}|", new string ('-', width));

            for (int i = 0; i < height-2; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', width));
            }
            Console.WriteLine("|{0}|", new string('-', width));

        }
    }
    public class DrawingTool
    {
        public static void Main()
        {
            string figure = Console.ReadLine().Trim();
            int width = 0;
            int height = 0;

            switch (figure)
            {
                case "Square": width = int.Parse(Console.ReadLine().Trim()); break;
                case "Rectangle":
                    {
                        width = int.Parse(Console.ReadLine().Trim());
                    }    height =int.Parse(Console.ReadLine().Trim());
                    break;
            }

            Rectangle.Draw(width, height);
        }
    }
}
