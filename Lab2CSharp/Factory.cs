using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    public class Factory : IComparable
    {
        private string _name;
        private int _amountOfDepartments;
        private int _amountOfMasters;
        private int _amountOfWorkers;
        private decimal _masterSalary;
        private decimal _workerSalary;
        private decimal _masterMoneyGivingPerMonth;
        private decimal _workerSalaryMoneyGivingPerMonth;

        public Factory(string name, int amountOfDepartments, int amountOfMasters, decimal masterMoneyGivingPerMonth, decimal workerMoneyGivingPerMonth, decimal masterSalary, decimal workerSalary)
        {
            _name = name;
            _amountOfDepartments = amountOfDepartments;
            _amountOfMasters = amountOfMasters;
            _amountOfWorkers = amountOfMasters * 10;
            _masterMoneyGivingPerMonth = masterMoneyGivingPerMonth;
            _workerSalaryMoneyGivingPerMonth = workerMoneyGivingPerMonth;
            _masterSalary = masterSalary;
            _workerSalary = workerSalary;
        }
        public Factory(Factory factory) // Copying constructor
        {
            _name =factory.Name;
            _amountOfDepartments = factory.AmountOfDepartments;
            _amountOfMasters = factory.AmountOfMasters;
            _amountOfWorkers = factory.AmountOfWorkers;
            _masterMoneyGivingPerMonth = factory.MasterMoneyGiving;
            _workerSalaryMoneyGivingPerMonth = factory.MasterMoneyGiving;
        }
        public string Name { get => _name;  }
        public int AmountOfDepartments { get => _amountOfDepartments; }
        public int AmountOfMasters { get => _amountOfMasters; }
        public int AmountOfWorkers { get => _amountOfWorkers; }
        public decimal MasterMoneyGiving { get => _masterMoneyGivingPerMonth; }
        public decimal WorkerMoneyGiving { get => _workerSalaryMoneyGivingPerMonth; }
        public decimal MasterSalary { get => _masterSalary; set => _masterSalary = value; }
        public decimal WorkerSalary { get => _workerSalary; set => _workerSalary = value; }

        private void CheckIfAmountIsCorrect(int amountMustBeLarger, int amoutMustBeLower)
        {
            if(amountMustBeLarger < amoutMustBeLower)
            {
                throw new ArgumentException("Amount was wrong");
            }
        }
        public void FireWorker(int amount)
        {
            CheckIfAmountIsCorrect(_amountOfWorkers, amount);
            _amountOfWorkers -= amount;
        }
        public void FireMaster(int amount)
        {
            CheckIfAmountIsCorrect(_amountOfMasters, amount);
            _amountOfMasters -= amount;
        }
        public void HireWorker(int amount)
        {
            _amountOfWorkers += amount;
        }
        public void HireMaster(int amount)
        {
            _amountOfMasters += amount;
        }
        public static Factory operator +(Factory firstFactory, Factory secondFactory)
        {
            Factory fac = new Factory(firstFactory.Name,
                firstFactory.AmountOfDepartments + secondFactory.AmountOfDepartments,
                firstFactory.AmountOfMasters + secondFactory.AmountOfMasters,
                firstFactory.MasterMoneyGiving, firstFactory.WorkerMoneyGiving, firstFactory.WorkerSalary, firstFactory.MasterSalary);
            return fac;
        }
        public int CompareTo(object? obj) // Will be comparing by total amount of workers
        {
           Factory factory = (Factory)obj;
            int thisFactoryCurrentAmountOfWorkers = this._amountOfWorkers + this._amountOfMasters;
            int inputFactoryCurrentAmountOfWorkers = factory.AmountOfWorkers + factory.AmountOfMasters;
            if(thisFactoryCurrentAmountOfWorkers > inputFactoryCurrentAmountOfWorkers)
            {
                return 1;
            }
            if(thisFactoryCurrentAmountOfWorkers < inputFactoryCurrentAmountOfWorkers)
            {
                return -1;
            }
            return 0;
        }
        public override string ToString()
        {
            return this._name;
        }
        public string GetFullInfo()
        {
            string res = $"Name {_name}, Amount of workers {_amountOfWorkers}, Amount of masters {_amountOfMasters}, Workers salary {_workerSalary}, Master Salary {_masterSalary}\n" +
                $"Master giving money per month {_masterMoneyGivingPerMonth}, Worker giving moner per month {_workerSalaryMoneyGivingPerMonth}";
            return res;
        }
    }
}
