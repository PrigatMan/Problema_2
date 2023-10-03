class Program
{
    static void Main()
    {
        Console.Write("Introduceti deimpartitul: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Introduceti impartitorul: ");
        int y = int.Parse(Console.ReadLine());

        if (y != 0)
        {
            int result = x / y;
            int rest = x % y;

            Console.WriteLine($"Rezultatul impartirii este: {result}");
            if (rest > 0)
            {
                Console.WriteLine($"Impartirea a avut rest: {rest}");
            }
        }
        else
        {
            Console.WriteLine("Nu se poate efectua impartirea cu 0.");
        }
    }
}