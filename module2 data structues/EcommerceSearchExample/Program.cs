using System;

class Product
{
    public int Id;
    public string Name;

    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class Program
{
    static int LinearSearch(Product[] products, string key)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].Name.ToLower() == key.ToLower())
            {
                return i;
            }
        }

        return -1;
    }

    static void Main(string[] args)
    {
        Product[] products =
        {
            new Product(101,"Laptop"),
            new Product(102,"Mouse"),
            new Product(103,"Keyboard"),
            new Product(104,"Monitor"),
            new Product(105,"Printer")
        };

        Console.Write("Enter Product Name: ");
        string search = Console.ReadLine();

        int index = LinearSearch(products, search);

        if(index!=-1)
        {
            Console.WriteLine("Product Found");
            Console.WriteLine("ID : " + products[index].Id);
            Console.WriteLine("Name : " + products[index].Name);
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }
}
