using System;
using System.Collections.Generic;
using System.Linq;
using DesignPattern.Entity.BehavioralPatterns.NullObjectPattern;

namespace DesignPattern.BLL.BehavioralPatterns.NullObjectPattern
{
    public class CustomerRepository
    {
        private readonly List<Customer> _customerList = new List<Customer>
        {
            new RealCustomer("Robert"),
            new RealCustomer("John"),
            new RealCustomer("Juile"),
            new RealCustomer("Lora")
        };

        public void PrintList()
        {
            foreach (var customer in _customerList) Console.WriteLine("\t" + customer);
        }

        public Customer GetById(int id)
        {
            return _customerList.FirstOrDefault(x => x.Id == id) ?? new NullCustomer();
        }
    }
}