using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //Assembly Scope

    // 1] Power of c++
    // 2] simplicity of java
    // 3] features of javascript
    // 4] elegance of VB


    // Build = compile and executeable code created
    internal class Program
    {
        static void Show()
        {
            Console.WriteLine("Show method");
        }
        static void Main(string[] args)
        {
            int count = 10;
            Console.WriteLine(count);

            bool status = false;
            Console.WriteLine(status);

            double amount = 120.22;
            Console.WriteLine(amount);

            String name = "Swapnil";
            Console.WriteLine(name);

            Console.WriteLine("Hello");

            Show();
            Console.ReadLine();


        }
       
    }

    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }


    }

    public class Account
    {
        private int id;  //Data memeber

        public int GetId()    //Getter
        {
            return id;
        }
        public void SetId(int id)  // Setter
        {
            this.id = id;
        }
        public double Balance { get; set; } // Autoproperty


        public void Deposit(double amount)    //Method
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            Balance = (Balance - amount);
        }

        public void Calculate(double rate)
        {
            Balance += Balance * rate;
        }
    }
}
