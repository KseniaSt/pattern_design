using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class DeferState : IState
    {
        private readonly Grant _grant;
        public DeferState(Grant grant)
        {
            _grant = grant;
        }

        public void Create()
        {
            Console.WriteLine("Грант вже подан");
        }

        public void Consider()
        {
            Console.WriteLine("Грант вже розглядається");
        }
        public void Defer()
        {
            Console.WriteLine("Грант відкладений");
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
