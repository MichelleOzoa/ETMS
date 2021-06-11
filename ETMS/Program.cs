using System;

namespace ETMS
{
    class Program
    {
        //Dito pinapakita kung ilan ang bibili ng product na available
       //At 

        static void Main(string[] args)
        {


            Console.WriteLine("********************************************");
            Console.WriteLine("Welcome to Available Product Employee Training System");
            Console.WriteLine("********************************************");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("fujin shoes");
            Console.WriteLine("ifrinch shoes");
            Console.WriteLine("lujinping shoes");
            Console.WriteLine("Press 1 If your oder is fujin shoes. Press 2 If your order is ifrinch shoes. Press 3 If your order is lujinping shoes");

            Console.Write("Enter your order number of available shoes: ");
            string Ordernumber = Console.ReadLine();
            Console.WriteLine(Ordernumber);


            //Next is signing up.


            Console.Write("Enter your Full Name: ");
            string OrderNAme = Console.ReadLine();
            Console.WriteLine(OrderNAme);

            Console.Write("Enter your Age: ");
            string Age = Console.ReadLine();
            Console.WriteLine(Age);

            Console.Write("Enter your complete Address: ");
            string OwnerAddress = Console.ReadLine();
            Console.WriteLine(OwnerAddress);


            Console.Write("Enter your Phone Number: ");
            string CellNumber = Console.ReadLine();
            Console.WriteLine(CellNumber);

            Console.Write("Enter your Email: ");
            string Email = Console.ReadLine();
            Console.WriteLine(Email);


            //pano magdagdag ng order of shoes.


            Console.Write("Enter add item if you want to add you order of shoes: ");
            string productitem = Console.ReadLine();
            Console.WriteLine("addorder " + productitem);

            Console.Write("Press any number key for your add order of available shoes: ");
            string numbersoforder = Console.ReadLine();
            Console.WriteLine(numbersoforder);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Your order is in process:.........");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("********************************************");
            Console.WriteLine("THANK YOU FOR CHOOSING US!");
            Console.WriteLine("********************************************");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
