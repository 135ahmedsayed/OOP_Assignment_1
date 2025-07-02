using System.Drawing;

namespace OOP_Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            string[] value = Enum.GetNames(typeof(WeekDays));
            Console.WriteLine("Days of the Week : ");
            foreach (string s in value)
                Console.WriteLine(s);
            #endregion

            #region Q2
            Console.WriteLine("\n");
            Person[] person = new Person[3];
            person[0] = new Person("Ahmed", 25);
            person[1] = new Person("Sayed", 20);
            person[2] = new Person("Mohamed", 15);
            Console.WriteLine("Person Details : ");
            foreach (Person p in person)
            {
                Console.WriteLine($"Name: {p.name}, Age: {p.age}");
            }
            Console.WriteLine("\n");
            #endregion

            #region Q3
            Console.Write("Seasons : ");
            bool r = Enum.TryParse(Console.ReadLine(), true, out Seas_on S);
            if (r)
            {
                Console.Write("month range for that season : ");
                switch (S)
                {
                    case Seas_on.Spring:
                        Console.WriteLine("March , April , May ");
                        break;
                    case Seas_on.Summer:
                        Console.WriteLine("june , july , august ");
                        break;
                    case Seas_on.Autumn:
                        Console.WriteLine("September , October , November ");
                        break;
                    case Seas_on.Winter:
                        Console.WriteLine("December , junuary , February");
                        break;
                }
            }
            else
                Console.WriteLine("Invalid season name. Please enter: Spring, Summer, Autumn, or Winter.");

            #endregion

            #region Q4
            Console.WriteLine("\n");
            Console.Write("Enter a color : ");
            string colorInput = Console.ReadLine()!;
            bool C = Enum.TryParse(colorInput, true, out Color color);
            if (C)
            {
                Console.WriteLine($"the {color} is a primary color ");
            }
            else
            {
                Console.WriteLine($"the {colorInput} isn't a primary color ");
            }
            Console.WriteLine("\n");
            #endregion

            #region Q5
            Point[] points = new Point[2];
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"Enter the Point{i + 1} -> ");
                Console.Write($"Enter x{i + 1}: ");
                points[i].x = int.Parse(Console.ReadLine()!);
                Console.Write($"Enter y{i + 1}: ");
                points[i].y = int.Parse(Console.ReadLine()!);
            }
            double distance = Math.Sqrt(Math.Pow(points[1].x - points[0].x, 2) + Math.Pow(points[1].y - points[0].y, 2));
            Console.WriteLine($"The distance between the two points is: {distance}");
            #endregion

            #region Q6
            Console.WriteLine("\n");
            Persons[] persons = new Persons[3];
            Persons[] Oldest = new Persons[1];
            Oldest[0] = new Persons("Unknown", 0); // Initialize with a default value
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Enter the Person{i + 1} -> ");
                Console.Write("Enter name: ");
                string name = Console.ReadLine()!;
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine()!);
                persons[i] = new Persons(name, age);
            }
            for (int i = 0; i < persons.Length; i++) // 5,4,7
            {
                if (persons[i].age > Oldest[0].age)
                {
                    Oldest[0] = persons[i];
                }
            }
            Console.WriteLine("the name and age of the oldest person : ");
            Console.WriteLine($"Name: {Oldest[0].name}, Age: {Oldest[0].age}");

            #endregion
            Console.ReadKey();
        }
    }
}
