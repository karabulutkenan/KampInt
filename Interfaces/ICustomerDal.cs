using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine(  "SQL ADDED");
        }

        public void Delete()
        {
            Console.WriteLine(  "SQL DELETED");
        }

        public void Update()
        {
            Console.WriteLine("SQL UPDATED");
        }
    }

    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("ORACLE ADDED");
        }

        public void Delete()
        {
            Console.WriteLine("ORACLE DELETED");
        }

        public void Update()
        {
            Console.WriteLine("ORACLE UPDATED");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
