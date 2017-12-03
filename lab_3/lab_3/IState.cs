using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    interface IState
    {
        void Create();      // створити
        void Consider();    // розглянути
        void Defer();       // відкласти
        void Reject();      // відхилити
        void Confirm();     // підтвердити        
        void Withdraw();    // відкликати        
    }
}
