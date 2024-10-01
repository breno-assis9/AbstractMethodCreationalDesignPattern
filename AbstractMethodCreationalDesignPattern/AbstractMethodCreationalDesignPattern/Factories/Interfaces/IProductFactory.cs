using AbstractMethodCreationalDesignPattern.Products.Interfaces;

namespace AbstractMethodCreationalDesignPattern.Factories.Interfaces
{
    public interface IProductFactory
    {
        IComputer CreateComputer();
        ISmartphone CreateSmartphone();
    }
}
