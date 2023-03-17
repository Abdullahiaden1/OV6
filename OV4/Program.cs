namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] talArray = new double[10];


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Mata in tal {i + 1}: ");
                double tal = double.Parse(Console.ReadLine());
                talArray[i] = tal;
            }


            Array.Sort(talArray);


            Console.WriteLine("De sorterade talen är:");
            foreach (double tal in talArray)
            {
                Console.WriteLine(tal);
            }


            Console.WriteLine("Tryck på en tangent för att avsluta...");
            
        }
    }
}

