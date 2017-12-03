using System;
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
            Console.WriteLine("Грант відкладен");
        }
        public void Reject()
        {
            Console.WriteLine("Грант відхилен");
        }
        public void Confirm()
        {
            Console.WriteLine("Грант підтверджен");
        }
        public void Withdraw()
        {
            Console.WriteLine("Грант відкликан");
        }
    }
}
