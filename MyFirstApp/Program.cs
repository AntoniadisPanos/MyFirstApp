using System;

namespace MyFirstApp
{
    class Program
    {

        static void Line_vert(int x)

        {
            for (int i = 0; i < x; i++)
            {

            
            
                Console.WriteLine("*");
            }
        }
        static void Line_horz(int x)

        {
            string answer = "";
            for (int i = 0; i < x; i++)
            {
                answer += " *";
            }
            Console.WriteLine(answer);

        }




        static void Main(string[] args)
        {
            Line_vert(20);
            Line_horz(20);
            

            //Console.Write("First Name: ");
            //string First = Console.ReadLine();
            //Console.Write("Last Name: ");
            //string Last = Console.ReadLine();
            //string FullName = First +  " " + Last;
            //Console.WriteLine("FullName: " + FullName);
            //Console.ReadKey();
           
            
            // testing github












        }
    }
}
