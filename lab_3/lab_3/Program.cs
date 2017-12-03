using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var grant = new Grant();
           
          // grant.CreateGrant();
            grant.ConsiderGrant();
            grant.DeferGrant();
            grant.RejectGrant();
            grant.WithDrawGrant();
            Console.Read();
        }
    }
}
