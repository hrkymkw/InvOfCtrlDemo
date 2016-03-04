using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvOfCtrlDemo
{
    interface IEmployeeReportNameProvider
    {
        string[] GetEmployeeName();
    }

    class SimpleEmployeeNameProvider : IEmployeeReportNameProvider
    {
        public string[] GetEmployeeName()
        {
            return new[] { "Chris", "Hiro", "James", "Purvin", "Stan", "Steve" };
        }
    }
}
