public class Program
{  
    public static void Main(string[] args) 
    {
        string repeat = "Y";
        bool resultofcompare = false;
        do
        {
            resultofcompare = false;
            Console.WriteLine("Insert number X:");
            string firstString = Console.ReadLine();
            int x = Convert.ToInt32(firstString);
            Console.WriteLine("Insert number Y:");
            string secondString = Console.ReadLine();
            int y = Convert.ToInt32(secondString);
            bool correctoperation = false;
            Console.WriteLine("Choose operating (+, -, *, /)");
            string operating = Console.ReadLine();

            do
            {
                if (operating == "+")
                {
                    int summ = x + y;
                    Console.WriteLine("Summ = " + summ);
                    correctoperation = true;
                }
                else if (operating == "-")
                {
                    int substruct = x - y;
                    Console.WriteLine("Substruct = " + substruct);
                    correctoperation = true;
                }
                else if (operating == "*")
                {
                    int add = x * y;
                    Console.WriteLine("Add = " + add);
                    correctoperation = true;
                }
                else if (operating == "/")
                {
                    double div = (double)x / (double)y;
                    Console.Write("Div = ");
                    Console.WriteLine("{0:F2}", div);
                    correctoperation = true;
                }
                else
                {
                    Console.WriteLine("You are make a mistake, please insert correct operation");
                    Console.WriteLine("Choose operating (+, -, *, /)");
                    operating = Console.ReadLine();
                }
            }
            while(correctoperation == false);
    
            Console.WriteLine("Do you want to repeat evaluation? If Yes - insert y, if No - insert n");
            repeat = Console.ReadLine();
            if((repeat == "Y")||(repeat == "y")) resultofcompare = true;
        }

        while (resultofcompare);
    }  
}