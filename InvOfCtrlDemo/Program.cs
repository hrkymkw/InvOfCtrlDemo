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
            //SimpleResolveDemo();
            DependencyResolveDemo();

            Console.WriteLine("\nDone!");
            Console.ReadLine();
        }

        private static void SimpleResolveDemo()
        {
            // setup up a new standard "container"
            var kernel = new Ninject.StandardKernel();

            kernel.Bind<ITestService>().To<TestService>();

            // calls for a server based on a registered type
            var service = kernel.Get<ITestService>();

            // work with your resolved service
            var names = service.GetMeSomeNames();
            foreach (var name in names)
            {
                Console.WriteLine($"My name is {name}");
            }
        }

        private static void DependencyResolveDemo()
        {
            // setup up a new standard "container"
            var kernel = new Ninject.StandardKernel();

            kernel.Bind<IEmployeeReportNameProvider>().To<SimpleEmployeeNameProvider>();
            kernel.Bind<IEmployeeReportService>().To<EmployeeReportService>();

            // calls for a server based on a registered type
            var service = kernel.Get<IEmployeeReportService>();

            // work with your resolved service
            service.ReportEmployees();
        }
    }
}
