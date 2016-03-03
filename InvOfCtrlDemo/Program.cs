using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace InvOfCtrlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup up a new standard "container"
            var kernel = new Ninject.StandardKernel();

            kernel.Bind<ITestService>().To<TestService>();

            // calls for a server based on a registered type
            var service = kernel.Get<ITestService>();

            // work with your resolved service
            var names = service.GetMeSomeNames();
            foreach(var name in names)
            {
                Console.WriteLine($"My name is {name}");
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
