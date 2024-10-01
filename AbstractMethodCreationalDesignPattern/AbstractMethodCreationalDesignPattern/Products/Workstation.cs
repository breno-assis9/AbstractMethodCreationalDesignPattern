using AbstractMethodCreationalDesignPattern.Products.Interfaces;

namespace AbstractMethodCreationalDesignPattern.Models
{
    public class Workstation : IComputer
    {
        public string GetSpecifications() => "Workstation: Intel Xeon, 64GB RAM, Quadro RTX 6000";
    }
}
