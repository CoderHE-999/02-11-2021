using System;

namespace SellProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk[] milks = new Milk[0];
            
            while (true)
            {

                Console.WriteLine("========================================================");
                Console.WriteLine("Product melumatlarini daxil edin:\nDavam etmek ucun 'd' ya bitirmek ucun 'b' ya basin!");
                Console.WriteLine("========================================================");

                string operation;
                Console.Write("Emeliyyat secin (d/b):");
                operation = Console.ReadLine();

                if (operation == "d")
                {
                    
                    string name = getInputStr("Adini daxil edin: ", 3, 25);
                    double volume = getInputDouble("Hecmi daxil edin: ", 0);
                    double fatrate = getInputfatrate("Yaglilig faizini daxil edin: ", 0, 100);
                    double price = getInputDouble("Qiymeti daxil edin: ", 0);
                    Product products = new Product(name);
                    int count = products.Count;
                    double totalIncome = products.TotalIncome;


                    Milk newMilk = new Milk(name, price, count, totalIncome, volume, fatrate);
                    Array.Resize(ref milks, milks.Length + 1);
                    milks[milks.Length - 1] = newMilk;
                    
                    continue;



                }
                Product product1 = new Product(" ");

                if (operation == "b")
                {
                    string operation2;
                    Console.WriteLine("Alis etmek isteyirsinizmi?(y/n):");
                    operation2 = Console.ReadLine();
                    if (operation == "y")
                    {
                        product1.Sell();

                        Console.WriteLine("Productlarin siyahisi:");
                        foreach (var item in milks)
                        {
                            Console.WriteLine(item.ShowInfo());
                        }
                        
                    }
                    if (operation == "n")
                    {
                        Console.WriteLine("Productlarin siyahisi:");
                        foreach (var item in milks)
                        {
                            Console.WriteLine(item.ShowInfo());
                        }
                        
                    }

                    break;
                }

                else
                {
                    Console.WriteLine("Duzgun emeliyyat secin!");

                    
                }
            }
            //string name = getInputStr("Adini daxil edin:", 3, 25);

        }

        static string getInputStr(string input , int minValue , int maxValue)
        {

            string inputStr;

            do
            {
                Console.Write(input);
                inputStr = Console.ReadLine();
            } while (inputStr.Length < minValue && inputStr.Length > maxValue);

            return inputStr;
        }

        static int getInputInt(string input , int minValue)
        {

            string inputStr;
            int inputInt;

            do
            {
                Console.Write(input);
                inputStr = Console.ReadLine();

            } while (!int.TryParse(inputStr, out inputInt) || inputInt < minValue);

            inputInt = Convert.ToInt32(inputStr);

            return inputInt;
        }

        static double getInputDouble(string input , int minValue)
        {
            string inputStr;
            double inputDbl;

            do
            {
                Console.Write(input);
                inputStr = Console.ReadLine();

            } while (!double.TryParse(inputStr, out inputDbl) || inputDbl < 0);

            inputDbl = Convert.ToDouble(inputStr);

            return inputDbl;
        }

        static double getInputfatrate(string input , int minValue , int maxValue)
        {
            string inputStr;
            double inputDbl;

            do
            {
                Console.Write(input);
                inputStr = Console.ReadLine();

            } while (!double.TryParse(inputStr, out inputDbl) || inputDbl > 100 || inputDbl < 0);

            inputDbl = Convert.ToDouble(inputStr);

            return inputDbl;
        }
    }
}
