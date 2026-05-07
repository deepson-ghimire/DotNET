using System;

namespace FirstConsoleApp
{
    struct Product
    {
        public int Id;
        public string Name;
        public string Category;
        public float Price;
        public int StockQuantity;
        public string SupplierEmail;
        public float Rating;
        public float DiscountPercentage;

        public Product(int id, string name, string category, float price,
                       int stockQuantity, string supplierEmail,
                       float rating, float discountPercentage)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQuantity;
            SupplierEmail = supplierEmail;
            Rating = rating;
            DiscountPercentage = discountPercentage;
        }

        public string FullProductInfo()
        {
            return $"Product Name: {Name}, Category: {Category}, Price: {Price}";
        }

        public float PriceAfterDiscount()
        {
            float discountAmount = (DiscountPercentage / 100) * Price;
            return Price - discountAmount;
        }

        public string RatingStatus()
        { 
            if (Rating >= 4.5f)
                return "Excellent";
            else if (Rating >= 3.0f)
                return "Good";
            else if (Rating >= 1.0f)
                return "Average";
            else
                return "Poor";
        }

        public static void InputFromUser()
        {
            int id;
            float price, rating, discount;
            int stock;
            string name, category, email;

            Console.Write("Enter Id: ");
            if (!int.TryParse(Console.ReadLine(), out id) || id < 0)
                id = 0;

            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
                name = char.ToUpper(name[0]) + name.Substring(1);
            else
                name = "Unknown";

            Console.Write("Enter Category: ");
            category = Console.ReadLine();
            if (!string.IsNullOrEmpty(category))
                category = char.ToUpper(category[0]) + category.Substring(1);
            else
                category = "General";

            Console.Write("Enter Price: ");
            if (!float.TryParse(Console.ReadLine(), out price))
                price = 0;

            Console.Write("Enter Stock Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out stock))
                stock = 0;

            Console.Write("Enter Supplier Email: ");
            email = Console.ReadLine();

            Console.Write("Enter Rating (1-5): ");
            if (!float.TryParse(Console.ReadLine(), out rating) || rating < 1 || rating > 5)
                rating = 1;

            Console.Write("Enter Discount Percentage: ");
            if (!float.TryParse(Console.ReadLine(), out discount))
                discount = 0;

            Product p = new Product(id, name, category, price, stock, email, rating, discount);

            Console.WriteLine("\nPRODUCT DETAILS");
            Console.WriteLine(p.FullProductInfo());
            Console.WriteLine("Price After Discount: " + p.PriceAfterDiscount());
            Console.WriteLine("Rating Status: " + p.RatingStatus());
        }
    }
}