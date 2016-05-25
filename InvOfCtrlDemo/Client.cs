using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvOfCtrlDemo
{
    interface IClient
    {
        string Name();

        string Address();

        string Header();
    }

    class Google: IClient
    {
        public string Name()
        {
            return "Google";
        }

        public string Address()
        {
            return "Mountain View, CA 94043";
        }

        public string Header()
        {
            return "Invoice #|Invoice Date|Amount";
        }
    }

    class Apple : IClient
    {
        public string Name()
        {
            return "Apple";
        }

        public string Address()
        {
            return "Cupertino, CA 95014";
        }

        public string Header()
        {
            return "Voucher #|Invoice Date|Total Amount";
        }
    }
}
