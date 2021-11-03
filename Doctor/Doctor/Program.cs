using System;

namespace Doctor
{
    class Program
    {
        static void Main(string[] args)
        {

            Doctor[] newDoctor = new Doctor[0];

            while (true)
            {
                Console.WriteLine("========================================================");
                Console.WriteLine("Doctor melumatlarini daxil edin:\nDavam etmek ucun 'd' ya bitirmek ucun 'b' ya basin!");
                Console.WriteLine("========================================================");

                string operation;
                Console.Write("Emeliyyat secin (d/b):");
                operation = Console.ReadLine();

                if (operation == "d")
                {
                    int no = getInputNo(newDoctor , 0);
                    string name = getInputStr("Doctorun adini daxil edin: ", 3, 20);
                    string surname = getInputStr("Doctorun soyadini daxil edin: ", 4, 20);
                    string gender = getInputGender();
                    string speciality = getInputStr("Doctorun ixtisasini daxil edin: ", 5, 20);
                    int experience = getInputInt("Doctorun tecrubesini daxil edin: ", 0);
                    Doctor doctor = new Doctor( no,  name,  surname,  gender,  speciality,  experience);
                    Array.Resize(ref newDoctor, newDoctor.Length + 1);
                    newDoctor[newDoctor.Length - 1] = doctor;
                    continue;

                   
                }

                if (operation == "b")
                {
                    Console.WriteLine("Doctorlarin siyahisi:");
                    foreach (var item in newDoctor)
                    {
                        Console.WriteLine(item.ShowInfo());
                    }
                    break;
                }

                else
                {
                    Console.WriteLine("duzgun secim daxil edin!");
                }
            }
            
            
        }

        static string getInputStr(string input , int minValue , int maxValue , bool check = false)
        {
            string inputStr;
            do
            {

                Console.Write(input);
                inputStr = Console.ReadLine();
                foreach (var item in inputStr)
                {
                    if (Char.IsDigit(item) == true)
                    {
                        check = true;
                        
                    }
                    else
                    {
                        check = false;
                    }
                }

            } while ((inputStr.Length < minValue || inputStr.Length > maxValue) || (check == true)); ;

            return inputStr;
        }

        static int getInputInt(string input, int minValue)
        {
            string inputStr;
            int inputInt;
            do
            {
                Console.WriteLine(input);
                inputStr = Console.ReadLine();
                
            } while (!int.TryParse(inputStr, out inputInt) || (inputInt < minValue));

            inputInt = Convert.ToInt32(inputStr);

            return inputInt;
        }

        static int getInputNo(Doctor[] array, int minvalue)
        {
            string inputStr;
            int inputInt;
            bool boolNo = true;

            do
            {
                Console.Write("Doctorun No- nu daxil edin: ");
                inputStr = Console.ReadLine();
                inputInt = Convert.ToInt32(inputStr);

                foreach (var item in array)
                {
                    if (item.No == inputInt)
                    {
                        Console.WriteLine("Daxil etdiyiniz nomreli doctor artiq movcuddur!");
                        boolNo = false;

                    }
                    else
                        boolNo = true;
                }
            } while ((!int.TryParse(inputStr , out inputInt)) || (boolNo == false || inputInt <= minvalue));

            

            return inputInt;



        }

        static string getInputGender()
        {
            string choose;

            while (true){
                Console.Write("1.Kisi\n2.Qadin\n(1/2)");
                choose = Console.ReadLine();

                if (choose == "1")
                {
                    return "Kisi";

                }

                if (choose == "2")
                {
                    return "Qadin";
                }

                else
                {
                    return "Duzgun secim edin!";
                }
            }
        }


    }
}
