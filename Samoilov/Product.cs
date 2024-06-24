﻿namespace Samoilov
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description {  get; set; }

        public Product(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }
        public override string ToString()
        {
            return Id + "\n" + Name + "\n" + Price + "\n" + Description;
        }

    }
}
