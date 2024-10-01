using AbstractMethodCreationalDesignPattern.Factories.Interfaces;
using AbstractMethodCreationalDesignPattern.Models;
using AbstractMethodCreationalDesignPattern.Products.Interfaces;

namespace AbstractMethodCreationalDesignPattern.Factories
{
    public class GamingProductFactory : IProductFactory
    {
        public IComputer CreateComputer() => new GamingPC();
        public ISmartphone CreateSmartphone() => new AndroidPhone();
    }
}
