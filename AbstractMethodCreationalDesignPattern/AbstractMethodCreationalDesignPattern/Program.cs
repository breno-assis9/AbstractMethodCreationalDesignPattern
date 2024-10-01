using AbstractMethodCreationalDesignPattern.Factories.Interfaces;
using AbstractMethodCreationalDesignPattern.Factories;

InventoryManager inventoryManager = new InventoryManager();

// Usando a fábrica de produtos de gaming
IProductFactory gamingFactory = new GamingProductFactory();
inventoryManager.AddComputer(gamingFactory.CreateComputer());
inventoryManager.AddSmartphone(gamingFactory.CreateSmartphone());

// Usando a fábrica de produtos de workstation
IProductFactory workstationFactory = new WorkstationProductFactory();
inventoryManager.AddComputer(workstationFactory.CreateComputer());
inventoryManager.AddSmartphone(workstationFactory.CreateSmartphone());

// Mostrando o inventário
inventoryManager.ShowInventory();