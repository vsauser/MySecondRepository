public class Program
{  
    public static void Main(string[] args) 
    {
        string repeat = "Y";
        do
        {
            Console.WriteLine("Insert number X?????????:");
            string FirstString = Console.ReadLine();
            int X = Convert.ToInt32(FirstString);
            Console.WriteLine("Insert number Y?????????:");
            string SecondString = Console.ReadLine();
            int Y = Convert.ToInt32(SecondString);
            Console.WriteLine("Choose operating (+, -, *, /)");
            string Operating = Console.ReadLine();
            if (Operating == "+")
            {
                int Summ = X + Y;
                Console.WriteLine("Summ = " + Summ);
            }
            else if (Operating == "-")
            {
                int Substruct = X - Y;
                Console.WriteLine("Substruct = " + Substruct);
            }
            else if (Operating == "*")
            {
                        int Add = X * Y;
                        Console.WriteLine("Add = " + Add);
            }
            else if (Operating == "/")
            {
                double Div = (double)X / (double)Y;
                Console.WriteLine("{0:F4}", Div);
            }

            Console.WriteLine("Do you want to repeat evaluation?");

        }
        while (Console.ReadLine() == "Y");
    }  
}