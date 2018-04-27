using System;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World_new!");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("done");

            Console.WriteLine("Hi" + " " + name);

            bool canVote = true;
            char grade = 'A';
            int maxInt = 1000;
            decimal maxDec = 1000;
            float maxFloat = 2335;
            double maxDouble = 2050920;

            Console.WriteLine("Max Int = " + maxDec);
            var anotherName = "Tom";

            Console.WriteLine("another name is a {0}", anotherName.GetTypeCode());

            Console.WriteLine("5 + 3" + "is equal" + (5+3));

            double pi = 3.14;
            int intPi = (int)pi;
            // math acos, cos, sin, tan, atan, csc
            // math.abs math.ceiling math.floor math.max. math.min
            // math.Pow (power), math.round, math.sqrt()

            Random rand = new Random();
            Console.WriteLine("Random number is here" + rand.Next(1,10));

            int age = 17;

            if ((age >= 5) && (age <=7)){
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 17)){
                Console.WriteLine("Go to highschool");
            }
            else
            {
                Console.WriteLine("Go home");
            }
            Console.WriteLine("! true" + (!true));

            bool CanDrive = age >= 16 ? true : false;
            // if it is true, we assign true to can drive, if false, we assign false to it
            Console.WriteLine(CanDrive);



            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                    break;
                case 2:
                    Console.WriteLine("type");
                    break;
                case 17:
                    Console.WriteLine("totall 17");
                    break;
                default:
                    break;
            }



            int i = 0;

            while (i<10)
            {
                if (i ==7)
                {
                    i++;
                    continue;
                }
                if (i==9)
                {
                    Console.WriteLine("This is at 9");
                }

                
                if (i % 2 == 0)
                {
                    Console.WriteLine(i%2);
                }

                i++;
            }
        }
    }
}


