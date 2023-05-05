abstract class Product
{
    private int productId;
    private string productName;
    private double productPrice;

    public Product(int id, string name, double price)
    {
        this.productId = id;
        this.productName = name;
        this.productPrice = price;
    }

    public int ProductId
    {
        get { return productId; }
    }

    public string ProductName
    {
        get { return productName; }
    }

    public double ProductPrice
    {
        get { return productPrice; }
    }

    public abstract double ComputeTax();
}

class Book : Product
{
    public Book(int id, string name, double price) : base(id, name, price) { }

    public override double ComputeTax()
    {
        return ProductPrice * 0.05;
    }
}

class Phone : Product
{
    public Phone(int id, string name, double price) : base(id, name, price) { }

    public override double ComputeTax()
    {
        return ProductPrice * 0.1;
    }
}

class TestProduct
{
    static void Main()
    {
        Product[] products = new Product[5];

        products[0] = new Book(1, "The Alchemist", 20.99);
        products[1] = new Book(2, "To Kill a Mockingbird", 15.50);
        products[2] = new Book(3, "1984", 18.75);
        products[3] = new Phone(4, "iPhone 12", 999.99);
        products[4] = new Phone(5, "Samsung Galaxy S21", 899.99);

        double totalBookTax = 0;
        double totalPhoneTax = 0;

        foreach (Product p in products)
        {
            if (p is Book)
            {
                totalBookTax += p.ComputeTax();
            }
            else if (p is Phone)
            {
                totalPhoneTax += p.ComputeTax();
            }
        }

        Console.WriteLine("Total tax for books: " + totalBookTax);
        Console.WriteLine("Total tax for phones: " + totalPhoneTax);
        Console.ReadKey();
    }
}
