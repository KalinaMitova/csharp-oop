using System;
using System.Collections.Generic;

//On the first line you will receive the number of rectangles – N and the number of intersection checks – M.On the next N lines, you will get the 
//rectangles with their ID, width, height and coordinates.On the last M lines, you will get pairs of IDs which represent rectangles.Print if each of
//the pairs intersect.
//You will always receive valid data. There is no need to check if a rectangle exists.

namespace _11_RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public string ID => this.id;

        public Rectangle()
            {
            }

        public Rectangle (string id, double width, double height, double x, double y)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public  void CheckIsRecIntersection(Rectangle rectangle)
        {

                bool isRecIntersiction = false;
                if ((rectangle.x <= (this.x + this.width)
                    && rectangle.x >= (this.x - rectangle.width))
                    && (rectangle.y <= (this.y + this.height)
                    && rectangle.y >= (this.y - rectangle.height)))
                {
                    isRecIntersiction = true;
                }

                Console.WriteLine(isRecIntersiction.ToString().ToLower());
            }
        }
   public class RectangleIntersection
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Rectangle> recs = new List<Rectangle>();
            for (int i = 0; i < int.Parse( input[0]); i++)
            {
                string[] recInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Rectangle rec = new Rectangle(recInput[0],
                    double.Parse(recInput[1]), double.Parse(recInput[2]),
                    double.Parse(recInput[3]), double.Parse(recInput[4]));

                recs.Add(rec);
            }

            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                string[] recInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                bool hasOneRec = false;

                Rectangle recFirst = new Rectangle();

                for (int j = 0; j < recs.Count; j++)
                {
                    
                    if (recs[j].ID == recInput[0] && !hasOneRec)
                    {
                        recFirst = recs[j];
                        hasOneRec = true;
                    }
                    if (recs[j].ID == recInput[1] && hasOneRec)
                    {
                       recFirst.CheckIsRecIntersection(recs[j]);
                        break; 
                    }

                }
            }
        }
    }
}
