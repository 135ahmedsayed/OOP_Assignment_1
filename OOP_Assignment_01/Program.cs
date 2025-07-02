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
            Console.ReadKey();
        }
    }
}
