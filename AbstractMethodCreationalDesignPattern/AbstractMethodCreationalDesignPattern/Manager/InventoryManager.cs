// InventoryManager.cs
using AbstractMethodCreationalDesignPattern.Products.Interfaces;
using System.Collections.Generic;

public class InventoryManager
{
    private readonly List<IComputer> _computers = new();
    private readonly List<ISmartphone> _smartphones = new();

    public void AddComputer(IComputer computer) => _computers.Add(computer);
    public void AddSmartphone(ISmartphone smartphone) => _smartphones.Add(smartphone);

    public void ShowInventory()
    {
        System.Console.WriteLine("Inventory of Computers:");
        foreach (var computer in _computers)
        {
            System.Console.WriteLine(computer.GetSpecifications());
        }

        System.Console.WriteLine("\nInventory of Smartphones:");
        foreach (var smartphone in _smartphones)
        {
            System.Console.WriteLine(smartphone.GetSpecifications());
        }
    }
}
