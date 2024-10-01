using AbstractMethodCreationalDesignPattern.Products.Interfaces;

namespace AbstractMethodCreationalDesignPattern.Models
{
    public class GamingPC : IComputer
    {
        public string GetSpecifications() => "Gaming PC: Intel i9, 32GB RAM, RTX 3090";
    }
}
