﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class ConsiderState : IState
    {
        private readonly Grant _grant;
        public ConsiderState(Grant grant)
        {
            _grant = grant;
        }

        public void Create()
        {
            Console.WriteLine("Грант вже подан");
        }

        public void Consider()
        {
            Console.WriteLine("Грант розглядається");
        }
        public void Defer()
        {
            _grant.SetState(_grant.DeferState);
            _grant.DeferGrant();
           // Console.WriteLine("Грант відкладенhh");
        }
        public void Reject()
        {
            Console.WriteLine("Грант ще не розглянут");
        }
        public void Confirm()
        {
            Console.WriteLine("Грант ще не розглянут ");
        }
        public void Withdraw()
        {
            Console.WriteLine("Грант відкликан");
        }
    }
}
