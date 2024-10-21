using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student(1,"tejas",99,98,98);
            //student.Calculate();
            //Console.WriteLine(student.Print());

            //Bank bank = new Bank(5000);
            //bank.Deposit(2000);
            //Console.WriteLine(bank.Withdraw(3000));
            //Console.WriteLine(bank.GetBalance());

            //Product p = new Product("a1", "watch", 3000);
            //Console.WriteLine(p.Print());

            Book book = new Book(11,"GOT","Mr.X",5000);
            Console.WriteLine(book.Display());

        }
    }
}
