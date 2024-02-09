namespace ageMonths;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, por gentileza, digite seu nome: ");
            string name = Console.ReadLine();
        Console.WriteLine("Agora, digite sua idade:");
            int age = Convert.ToInt32(Console.ReadLine());

            int months = age * 12;

        Console.WriteLine($"{name}, você viveu por {months} meses.");

    }
}
