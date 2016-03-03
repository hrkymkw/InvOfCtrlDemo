using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvOfCtrlDemo
{
    interface ITestService
    {
        string[] GetMeSomeNames();
    }

    class TestService : ITestService
    {
        public string[] GetMeSomeNames()
        {
            return new[] { "Chris", "Hiro", "James", "Purvin", "Stan", "Steve" };
        }
    }
}
