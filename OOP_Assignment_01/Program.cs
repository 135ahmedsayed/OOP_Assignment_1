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
            Console.ReadKey();
        }
    }
}
