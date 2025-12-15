// Problem Statement

// You are working as a Software Engineer at HCL Company. Your client has requested the design of a Smart Online Shopping Discount System for an e-commerce platform. In this system, different customers receive different types of discounts based on their customer category.

// The system must apply discount strategies using delegates in C#. Each product and customer should be represented using appropriate entities. Customers are classified as either occasional or regular, and the discount applied depends on this classification.

// Discount Rules:

// Occasional customers receive a Festival Discount of 17%

// Regular customers receive a Premium Discount of 28%

// Entities to be implemented:

// Product

// Product Id

// Product Name

// Product Price

// Customer

// Customer Id

// Customer Name

// Customer Type (occasional or regular)

// Shopping

// Applies the appropriate discount using a delegate based on customer type

// The system should calculate and display the final price of the product after applying the correct discount strategy.


using System;

delegate double Discount(double price);

class Product
{
    public int ProductId;
    public string ProductName;
    public double ProductPrice;
}

class Customer
{
    public int CustomerId;
    public string CustomerName;
    public string CustomerType;
}

class Shopping
{
    public static double FestivalDiscount(double price)
    {
        return price - (price * 0.17);
    }

    public static double PremiumDiscount(double price)
    {
        return price - (price * 0.28);
    }

    static void Main()
    {
        Product product = new Product { ProductId = 1, ProductName = "Laptop", ProductPrice = 50000 };
        Customer customer = new Customer { CustomerId = 101, CustomerName = "Arun", CustomerType = "regular" };

        Discount discount;

        if (customer.CustomerType == "occasional")
            discount = FestivalDiscount;
        else
            discount = PremiumDiscount;

        double finalPrice = discount(product.ProductPrice);

        Console.WriteLine(product.ProductName);
        Console.WriteLine(customer.CustomerName);
        Console.WriteLine(finalPrice);
    }
}
