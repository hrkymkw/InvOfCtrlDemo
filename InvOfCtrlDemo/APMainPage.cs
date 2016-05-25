using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvOfCtrlDemo
{
    interface IMainPage
    {
        void Header1();
        void Header2();
        void Body();

    }

    class APMainPage: IMainPage
    {
        private IClient _client;

        public APMainPage(IClient client)
        {
            _client = client;
        }

        public void Header1()
        {
            var name = _client.Name();
            Console.WriteLine($"Account Payable Site for {name}");
        }

        public void Header2()
        {
            var address = _client.Address();
            Console.WriteLine($"Address: {address}");
        }

        public void Body()
        {
            Console.WriteLine($"### Inbox ###");
            var header = _client.Header();
            Console.WriteLine($"{header}");
        }
    }
}
