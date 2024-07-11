using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;

namespace Domain.Entities
{
    public class Product(int Id, string Name, Category Category, Money Price, DateTime? LaunchTime = null)
    {
        public int Id { get; set; } = Id;
        public string Name { get; set; } = Name;
        public Category Category { get; set; } = Category;
        public Money Price { get; set; } = Price;
        public DateTime? LaunchTime { get; set; } = LaunchTime;
    }
}
