using AbstractMethodCreationalDesignPattern.Factories.Interfaces;
using AbstractMethodCreationalDesignPattern.Models;
using AbstractMethodCreationalDesignPattern.Products.Interfaces;

namespace AbstractMethodCreationalDesignPattern.Factories
{
    public class WorkstationProductFactory : IProductFactory
    {
        public IComputer CreateComputer() => new Workstation();
        public ISmartphone CreateSmartphone() => new iPhone();
    }
}
