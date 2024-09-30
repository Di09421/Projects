using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface Bank
    {
        int Accno
        {
            get;
            set;
        }
        int Bal
        {
            get;
            set;
        }

        void deposit(int a);
        void withd(int a);
        void ShowBal();
    }
}

