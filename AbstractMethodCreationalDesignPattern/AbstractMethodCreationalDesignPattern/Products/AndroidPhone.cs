using AbstractMethodCreationalDesignPattern.Products.Interfaces;

namespace AbstractMethodCreationalDesignPattern.Models
{
    public class AndroidPhone : ISmartphone
    {
        public string GetSpecifications() => "Android Phone: Snapdragon 888, 12GB RAM";
    }
}
