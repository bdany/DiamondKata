namespace DiamondKata
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new ArgumentException("Input must be an uppercase letter [A - Z].");
                }
                else
                {
                    var target = args[0].First();
                    if (args[0].Length > 0)
                    {
                        Console.WriteLine($"Generate the Diamond for: {target}");
                    }
                    Console.WriteLine(new Diamond(target));
                }
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
