using AbstractMethodCreationalDesignPattern.Products.Interfaces;

namespace AbstractMethodCreationalDesignPattern.Models
{
    public class iPhone : ISmartphone
    {
        public string GetSpecifications() => "iPhone: A15 Bionic, 6GB RAM";
    }
}
