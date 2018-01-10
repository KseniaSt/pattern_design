using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class CreateState : IState
    {
        private readonly Grant _grant;
        public CreateState(Grant grant)
        {
            _grant = grant;
        }
        public void Create()
        {
            Console.WriteLine("Грант подан");
            _grant.SetState(_grant.ConsiderState);
        }

        public void Consider()
        {
            Console.WriteLine("Грант  ще не подан");
        }
        public void Defer()
        {
            Console.WriteLine("Грант не подан");
        }
        public void Reject()
        {
            Console.WriteLine("Грант не подан"); 
        }
        public void Confirm()
        {
            Console.WriteLine("Грант не подан");
        }
        public void Withdraw()
        {
            Console.WriteLine("Грант не подан");
        }
    }
}
/*
        void Create();      // створити
        void Consider();    // розглянути
        void Defer();       // відкласти
        void Reject();      // відхилити
        void Confirm();     // підтвердити        
        void Withdraw();    // відкликати 
        */