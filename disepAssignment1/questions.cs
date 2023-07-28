using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disepAssignment1
{
    public class questions
    {

        public void questionOneMethod()
        {
            ////====== Question 1 start ====== //
            int num_1 = 144;
            int num_2 = 36;
            int num_3 = 10000;
            int num_4 = 2500;
            int num_5 = 40000;

            Console.WriteLine(Math.Sqrt(num_1));
            Console.WriteLine(" Press Enter for the second value ");
            string answer_1 = Console.ReadLine();



            Console.WriteLine(Math.Sqrt(num_2));
            Console.WriteLine(" Press Enter for the third value ");
            string answer_2 = Console.ReadLine();


            Console.WriteLine(Math.Sqrt(num_3));
            Console.WriteLine(" Press Enter for the fourth value ");
            string answer_3 = Console.ReadLine();


            Console.WriteLine(Math.Sqrt(num_4));
            Console.WriteLine(" Press Enter for the last value ");
            string answer_4 = Console.ReadLine();


            Console.WriteLine(Math.Sqrt(num_5));
            string answer_5 = Console.ReadLine();

            //    //====== Question 1 End ====== //
        }

        public void questionTwoMethod()
        {
            Double A = 3;
            Double B = 4;
            Double C = 10;
            Double D = 100;
            Double E = 12;

            Console.WriteLine((Math.Pow(A, 2)));
            Console.WriteLine(" Press Enter for the second value ");
            string A_1 = Console.ReadLine();

            Console.WriteLine((Math.Pow(B, 3)));
            Console.WriteLine(" Press Enter for the third value ");
            string B_1 = Console.ReadLine();

            Console.WriteLine((Math.Pow(C, 2)));
            Console.WriteLine(" Press Enter for the fourth value ");
            string C_1 = Console.ReadLine();

            Console.WriteLine((Math.Pow(D, 5)));
            Console.WriteLine(" Press Enter for the last value ");
            string D_1 = Console.ReadLine();

            Console.WriteLine((Math.Pow(E, 4)));
            string E_1 = Console.ReadLine();



            //====== Question 2 End ====== //
        }

        public void questionthreeMethod()
        {
            Console.WriteLine((20*20)/100);
            Console.WriteLine(78+50-(300/2));
            Console.WriteLine(45*20-(400+34));
            Console.WriteLine((100/2)*(23+34));
            Console.WriteLine((200*3)*(300+23));

            Console.ReadLine();
        }

        public void questionfourMethod()
        {
            Console.WriteLine("Enter Your Name\n ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Your Age\n ");
            string age = Console.ReadLine();
            Console.WriteLine("\nEnter Your Email Address\n ");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("\nEnter Your Home Address\n ");
            string homeAddress = Console.ReadLine();
        }

        public void questionfiveMethod()
        {
            string Name = " My Name is Toju Oyemade. ";
            String Age = "I am 40 years old ";
            String Discipline = "my discipline is Computer Science.";
            Console.WriteLine(Name +  Age + "and " + Discipline);
            Console.ReadLine();

        }



        static void Main(string[] args)
        {

            questions answers = new questions();
            //answers.questionOneMethod();
             //answers.questionTwoMethod();
            //answers.questionthreeMethod();
            //answers.questionfourMethod();
            //answers.questionfiveMethod();

            

        }


    }
}
