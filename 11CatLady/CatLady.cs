using System;
using System.Collections.Generic;

namespace _11CatLady
{
    public class CatLady
    {
        public static void Main()
        {
            string[] inputCat = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Cat> cats = new List<Cat>();

            while (inputCat[0] != "End")
            {
                if (inputCat[0] == "Siamese" || inputCat[0] == "StreetExtraordinaire")
                {
                    Cat cat = new Cat(inputCat[0], inputCat[1], int.Parse(inputCat[2]));
                    cats.Add(cat);
                }
                else if (inputCat[0] == "Cymric")
                {
                    Cat cat = new Cat(inputCat[0], inputCat[1], double.Parse(inputCat[2]));
                    cats.Add(cat);
                }

                inputCat = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string catName = Console.ReadLine().Trim();

            foreach (var cat in cats)
            {
                if (cat.Name == catName)
                {
                    if (cat.Type == "Siamese" || cat.Type== "StreetExtraordinaire")
                    {
                        Console.WriteLine($"{cat.Type} {cat.Name} {cat.EarSizeOreardecibelsOfMeowsSize}");
                    }
                    else
                    {
                        Console.WriteLine($"{cat.Type} {cat.Name} {cat.FurLenght:F2}");
                    }
                    break;
                }
            }
        }
    }
}
