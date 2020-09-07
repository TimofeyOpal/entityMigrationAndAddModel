
using System;
using System.Collections.Generic;
using System.Text;

namespace _11111111111entity
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Price { get; set; }
        // навигационное свойство
        public Company Manufacturer { get; set; }
    }
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
