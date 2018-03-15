using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//Create a class ImmutableList. It should consist of a collection of integers and a function to return them.You should not be able to modify the collection
//(e.g.every time you try to get the current collection, you should get a new collection of the same elements or return a copy of the current collection, and never 
//the collection itself).
namespace _07_ImmutableList
{
    public class ImmutableList
    {
        public List<int> list;

        public ImmutableList(List<int> list)
        {
            this.list = new List<int>();
            this.list = list;
        }

        public ImmutableList List()
        {
            return new ImmutableList(this.list);
        }

    }
    public class List
    {
        public static void Main()
        {
            Type immutableList = typeof(ImmutableList);
            FieldInfo[] fields = immutableList.GetFields();
            if (fields.Length < 1)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(fields.Length);
            }

            MethodInfo[] methods = immutableList.GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
            if (!containsMethod)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(methods[0].ReturnType.Name);
            }

        }
    }
}
