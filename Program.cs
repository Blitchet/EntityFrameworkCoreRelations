using System;
using System.Collections.Generic;

namespace EntityFrameworkCoreRelations
{
    class Program
    {        
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            //Add new content...
        }        
    }

    class Address
    {
        public int Id { get; set; } //PK
        public string Street { get; set; }
        public int ShopId { get; set; } //FK
    }

    class Shop
    {
        public int Id { get; set; } //PK
        public string Name { get; set; }
        public Address Address { get; set; } //Navigation Property
        public int OwnerId { get; set; } //FK
    }

    class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Shop> Shops { get; set; } //List Shops
    }    

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class ShopProduct
    {
        public int ShopId { get; set; } //FK 
        public int ProductId { get; set; } //FK
        public int Amount { get; set; }
        public Shop Shop { get; set; } //Navigation Property
        public Product Product { get; set; } //Navigation Property
    }
}
