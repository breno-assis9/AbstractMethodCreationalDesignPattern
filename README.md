### **ElectronicsStore**
Este projeto é um exemplo de implementação do padrão Abstract Factory em um aplicativo de console .NET Core 8. O sistema gerencia diferentes tipos de produtos eletrônicos, como computadores e smartphones, e organiza um inventário.

**Índice**
- Tecnologias Utilizadas
- Pré-requisitos
- Instalação
- Estrutura do Projeto
- Como Usar
- Estrutura do Código
- Contribuição
- Licença

**Tecnologias Utilizadas**
- .NET Core 8
- C#
  
**Pré-requisitos**
Certifique-se de ter o .NET SDK 8 instalado. Você pode verificar se ele está instalado com o seguinte comando:

```bash
dotnet --version
```

Se você não tiver o .NET SDK instalado, pode baixá-lo aqui.

**Instalação**
Clone o repositório:

```bash
git clone https://github.com/seu_usuario/ElectronicsStore.git
cd ElectronicsStore
```
Restaure as dependências (se necessário):

```bash
dotnet restore
```
Estrutura do Projeto
A estrutura do projeto é a seguinte:

Copiar código
ElectronicsStore/
│
├── Products/
│   ├── IComputer.cs
│   ├── ISmartphone.cs
│   ├── GamingPC.cs
│   ├── Workstation.cs
│   ├── AndroidPhone.cs
│   └── iPhone.cs
│
├── Factories/
│   ├── IProductFactory.cs
│   ├── GamingProductFactory.cs
│   └── WorkstationProductFactory.cs
│
├── InventoryManager.cs
└── Program.cs
Como Usar
Compile o projeto:

```bash
dotnet build
```
Execute o projeto:

```bash
dotnet run
Saída esperada: O programa exibirá um inventário de computadores e smartphones, como mostrado abaixo:
```


```yaml
Inventory of Computers:
Gaming PC: Intel i9, 32GB RAM, RTX 3090
Workstation: Intel Xeon, 64GB RAM, Quadro RTX 6000

Inventory of Smartphones:
Android Phone: Snapdragon 888, 12GB RAM
iPhone: A15 Bionic, 6GB RAM
```

**Estrutura do Código**
**1. Interfaces de Produtos**
As interfaces IComputer e ISmartphone definem o contrato para as classes que representam diferentes produtos.

IComputer: Interface para computadores.
ISmartphone: Interface para smartphones.

**2. Classes de Produtos**
As classes concretas implementam as interfaces e representam produtos específicos:

GamingPC e Workstation para computadores.
AndroidPhone e iPhone para smartphones.

**3. Fábricas**
As fábricas implementam a interface IProductFactory, que define os métodos para criar produtos.

GamingProductFactory: Cria um GamingPC e um AndroidPhone.
WorkstationProductFactory: Cria uma Workstation e um iPhone.

**4. Gerenciador de Estoque**
A classe InventoryManager gerencia as listas de produtos, permitindo adicionar e exibir o inventário.

**5. Cliente**
O Program.cs é o ponto de entrada do aplicativo, onde as fábricas são utilizadas para criar produtos e gerenciar o inventário.

**Contribuição**
Se você deseja contribuir para este projeto, fique à vontade para abrir issues ou pull requests. Sua contribuição é bem-vinda!

**Licença**
Este projeto está licenciado sob a MIT License.
