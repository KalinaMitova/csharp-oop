using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//You want to build your family tree, so you went to ask your grandmother, sadly your grandmother keeps remembering information 
//about your predecessors in pieces, so it falls to you to group the information and build the family tree.
//On the first line of the input you will receive either a name or a birthdate in the format “<FirstName> <LastName>” or 
//“day/month/year” – your task is to find the person’s information in the family tree.On the next lines until the command “End” 
//is received you will receive information about your predecessors that you will use to build the family tree.
//The information will be in one of the following formats: 
//•	“FirstName LastName - FirstName LastName”
//•	“FirstName LastName - day/month/year”
//•	“day/month/year - FirstName LastName”
//•	“day/month/year - day/month/year”
//•	“FirstName LastName day/month/year”
//The first 4 formats reveal a family tie – the person on the left is parent to the person on the right (as you can see the 
//format does not need to contain names, for example the 4th format means the person born on the left date is parent to the person
//born on the right date). The last format ties different information together – i.e.the person with that name was born on that 
//date.Names and birthdates are unique – there won’t be 2 people with the same name or birthdate, there will always be enough 
//entries to construct the family tree (all people’s names and birthdates are known and they have atleast one connection to another
//person in the tree). 
//After the command “End” is received you should print all information about the person whose name or birthdate you received on 
//the first line – his name, birthday, parents and children(check the examples for the format). The people in the parents and 
//childrens lists should be ordered by their first appearance in the input(regardless if they appeared as a birthdate or a name, 
//for example in the first input Stamat is before Penka because he first appeared in the second line, while she appears in the
//third.).

namespace _10FamilyTree
{
    class FamilyTree
    {
        static void Main(string[] args)
        { 
            Dictionary <string, Person> personByName = new Dictionary<string, Person>();
            Dictionary<DateTime, Person> personByDate = new Dictionary<DateTime, Person>();

            string[] nameOrDateOfBirthOfWantedPerson = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "End")
            {
                //input “FirstName LastName day/month/year”
                if (input.Length == 3 && !input.Contains("-"))
                {
                    AddPersonsByNameAndDateOfBirth(personByName, personByDate, input);
                }

                //input “day/month/year - day/month/year”
                else if (input.Length == 3 && input.Contains("-"))
                {
                    AddPersonsFromInputDateOfBirthParentDateOfBirthChild(personByDate, input);
                }

                //input “day/month/year - FirstName LastName”
                else if (input.Length == 4 && input[0].Contains("/"))
                {
                    AddPersonsFromInputDateOfBirthParentNameChild(personByName, personByDate, input);
                }

                //input “FirstName LastName - day/month/year”
                else if (input.Length == 4 && input[3].Contains("/"))
                {
                    AddPersonsFromInputNameParentDateOfBirthChild(personByName, personByDate, input);
                }

                //input “FirstName LastName - FirstName LastName”
                else if (input.Length == 5)
                {
                    AddPersonsFromInputNameParentNameChild(personByName, input);
                }

                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (nameOrDateOfBirthOfWantedPerson.Length == 2)
            {
                string name = $"{nameOrDateOfBirthOfWantedPerson[0]} {nameOrDateOfBirthOfWantedPerson[1]}";

                foreach (var par in personByName[name].Parents)
                {
                    if (string.IsNullOrEmpty(par.Name))
                    {
                        par.Name = personByDate[par.DateOfBirth].Name;
                    }
                    else if (par.DateOfBirth == DateTime.MinValue)
                    {
                        par.DateOfBirth = personByName[par.Name].DateOfBirth;
                    }
                }

                foreach (var kid in personByName[name].Children)
                {
                    if (string.IsNullOrEmpty(kid.Name))
                    {
                        kid.Name = personByDate[kid.DateOfBirth].Name;
                    }
                    else if (kid.DateOfBirth == DateTime.MinValue)
                    {
                        kid.DateOfBirth = personByName[kid.Name].DateOfBirth;
                    }
                }

                Console.WriteLine(personByName[name]);
            }
            else
            {
                DateTime dateOfBirth = DateTime.ParseExact(nameOrDateOfBirthOfWantedPerson[0], "d/M/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None);
                

                foreach (var par in personByDate[dateOfBirth].Parents)
                {
                    if ( string.IsNullOrEmpty(par.Name))
                    {
                        par.Name = personByDate[par.DateOfBirth].Name;
                    }
                    else if (par.DateOfBirth == DateTime.MinValue)
                    {
                        par.DateOfBirth = personByName[par.Name].DateOfBirth;
                    }
                }

                foreach (var kid in personByDate[dateOfBirth].Children)
                {
                    if (string.IsNullOrEmpty(kid.Name))
                    {
                        kid.Name = personByDate[kid.DateOfBirth].Name;
                    }
                    else if (kid.DateOfBirth == DateTime.MinValue)
                    {
                        kid.DateOfBirth = personByName[kid.Name].DateOfBirth;
                    }
                }

                Console.WriteLine(personByDate[dateOfBirth]);

            }
        }

        public static void AddPersonsFromInputNameParentNameChild(Dictionary<string, Person> personByName, string[] input)
        {
            string parentName = $"{input[0]} {input[1]}";
            string childName = $"{input[3]} {input[4]}";

            if (!personByName.ContainsKey(parentName))
            {
                personByName.Add(parentName, new Person(parentName));
            }
            personByName[parentName].AddChild(new Child(childName));

            if (!personByName.ContainsKey(childName))
            {
                personByName.Add(childName, new Person(childName));
            }
            personByName[childName].AddParent(new Parent(parentName));
        }

        public static void AddPersonsFromInputNameParentDateOfBirthChild(Dictionary<string, Person> personByName,
                                                                         Dictionary<DateTime, Person> personByDate,
                                                                         string[] input)
        {
            string name = $"{input[0]} {input[1]}";
            DateTime dateOfBirthChild = DateTime.ParseExact(input[3], "d/M/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None);
            if (!personByName.ContainsKey(name))
            {
                personByName.Add(name, new Person(name));
            }
            personByName[name].AddChild(new Child(dateOfBirthChild));

            if (!personByDate.ContainsKey(dateOfBirthChild))
            {
                personByDate.Add(dateOfBirthChild, new Person(dateOfBirthChild));
            }
            personByDate[dateOfBirthChild].AddParent(new Parent(name));
        }

        public static void AddPersonsFromInputDateOfBirthParentNameChild(Dictionary<string, Person> personByName,
                                                                        Dictionary<DateTime, Person> personByDate,
                                                                        string[] input)
        {
            DateTime dateOfBirthParent = DateTime.ParseExact(input[0], "d/M/yyyy",
                                   CultureInfo.InvariantCulture,
                                   DateTimeStyles.None);
            string name = $"{input[2]} {input[3]}";

            if (!personByDate.ContainsKey(dateOfBirthParent))
            {
                personByDate.Add(dateOfBirthParent, new Person(dateOfBirthParent));
            }
            personByDate[dateOfBirthParent].AddChild(new Child(name));

            if (!personByName.ContainsKey(name))
            {
                personByName.Add(name, new Person(name));
            }
            personByName[name].AddParent(new Parent(dateOfBirthParent));
        }

        public static void AddPersonsFromInputDateOfBirthParentDateOfBirthChild(Dictionary<DateTime, Person> personByDate, string[] input)
        {
            DateTime dateOfBirthParent = DateTime.ParseExact(input[0], "d/M/yyyy",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None);

            DateTime dateOfBirthChild = DateTime.ParseExact(input[2], "d/M/yyyy",
                   CultureInfo.InvariantCulture,
                   DateTimeStyles.None);

            if (!personByDate.ContainsKey(dateOfBirthParent))
            {
                personByDate.Add(dateOfBirthParent, new Person(dateOfBirthParent));
            }

            personByDate[dateOfBirthParent].Children.Add(new Child(dateOfBirthChild));


            if (!personByDate.ContainsKey(dateOfBirthChild))
            {
                personByDate.Add(dateOfBirthChild, new Person(dateOfBirthChild));
            }

            personByDate[dateOfBirthChild].Parents.Add(new Parent(dateOfBirthParent));
        }

        public static void AddPersonsByNameAndDateOfBirth(Dictionary<string, Person> personByName, 
                                                          Dictionary<DateTime, Person> personByDate, 
                                                          string[] input)
        {
            string name = input[0] + " " + input[1];
            DateTime dateOfBirth = DateTime.ParseExact(input[2], "d/M/yyyy",
                   CultureInfo.InvariantCulture,
                   DateTimeStyles.None);

            if (!personByName.ContainsKey(name) && !personByDate.ContainsKey(dateOfBirth))
            {
                personByName.Add(name, new Person(name, dateOfBirth));
                personByDate.Add(dateOfBirth, new Person(name, dateOfBirth));
            }

           else  if (personByName.ContainsKey(name) && !personByDate.ContainsKey(dateOfBirth))
            {
                personByName[name].DateOfBirth = dateOfBirth;
                personByDate.Add(dateOfBirth, new Person(name, dateOfBirth));
            }

            else if (personByDate.ContainsKey(dateOfBirth) && !personByName.ContainsKey(name))
            {
                personByDate[dateOfBirth].Name = name;
                personByName.Add(name, new Person(name, dateOfBirth));
            }

            if (personByName.ContainsKey(name) && personByDate.ContainsKey(dateOfBirth))
            {
                personByName[name].DateOfBirth = dateOfBirth;
                personByDate[dateOfBirth].Name =  name;

                foreach (var ch in personByDate[dateOfBirth].Children)
                {
                    personByName[name].AddChild(ch);
                }

                foreach (var par in personByDate[dateOfBirth].Parents)
                {
                    personByName[name].AddParent(par);
                }

                personByDate[dateOfBirth] = personByName[name];
            }
        }

    }
}
