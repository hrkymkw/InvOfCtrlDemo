using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvOfCtrlDemo
{
    interface IEmployeeReportService
    {
        void ReportEmployees();
    }

    class EmployeeReportService : IEmployeeReportService
    {
        private IEmployeeReportNameProvider _nameProvider;

        public EmployeeReportService(IEmployeeReportNameProvider nameProvider)
        {
            _nameProvider = nameProvider;
        }

        public void ReportEmployees()
        {
            Console.WriteLine($"The current time is: {DateTime.Now}");

            var names = _nameProvider.GetEmployeeName();
            foreach (var name in names)
            {
                Console.WriteLine($"The employee's name is {name}");
            }
        }
    }
}
