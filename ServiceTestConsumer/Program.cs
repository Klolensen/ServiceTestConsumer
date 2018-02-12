using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceTestConsumer.TestService;

namespace ServiceTestConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new TestServiceClient())
            {
                Console.WriteLine(client.GetMyName());
            }
            Console.ReadKey();
        }
    }
}
