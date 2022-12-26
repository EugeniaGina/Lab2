using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    public static class ExtensionFactory
    {
        public static decimal MoneyCanGet(this Factory factory, decimal totalSumInput)
        {
            
            decimal totalSalary =  factory.MasterSalary * factory.AmountOfMasters + factory.WorkerSalary * factory.AmountOfWorkers;
            decimal totalMoneyGiving = factory.MasterMoneyGiving * factory.AmountOfMasters + factory.WorkerMoneyGiving * factory.AmountOfWorkers;
            decimal totalRevenue = 0;
            for (; totalSalary <= totalSumInput; totalSumInput-= totalSalary) 
            {
                totalRevenue += totalMoneyGiving;
            }
            return totalRevenue + totalSumInput;
        }
    }
}
