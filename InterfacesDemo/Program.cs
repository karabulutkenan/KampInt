using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[2]
            {
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers) 
            {
                worker.Work();
            }
        }
    }
    interface IWorker
    {
        void Work();
       
    }
    interface IEater
    {
        void Eat();
        
    }
    interface IGetSalary
    {
        void GetSalary();
    }

    class Worker : IWorker, IGetSalary, IEater
    {
        public void Eat()
        {
           
        }

        public void GetSalary()
        {
            
        }

        public void Work()
        {
            Console.WriteLine("Worker Çalıştı");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Çalıştı");
        }
    }
}
