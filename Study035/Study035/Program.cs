using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello;

namespace Hello
{
    public class Say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕하세요!");
        }
    }
}
namespace Study035
{
    class Program
    {
        static void Main(string[] args)
        {
            Say sa = new Say();
            sa.SayHello();
        }
    }
}
