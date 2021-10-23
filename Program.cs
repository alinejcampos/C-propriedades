namespace Propriedade
{
    class Program
    {
        static void Main(string[] args)
        {
            dancarina dancarina1 = new dancarina();
            dancarina1.Dancarina = "Ashley Everett ";
            Console.WriteLine("Dançarina: " + dancarina1.Dancarina);

            cantora cantora1 = new cantora();
            cantora1.Cant = "Beyonce ";
            Console.WriteLine("Cantora: " + cantora1.Cant);

            atriz atriz1 = new atriz();
            atriz1.Actriz = "Ursula Corbero";
            Console.WriteLine("Atriz: " + atriz1.Actriz);



        }

    }
}
