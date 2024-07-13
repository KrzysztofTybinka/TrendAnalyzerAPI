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
    public class Product()
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public Category Category { get; set; }
        public Money Price { get; set; } 
        public DateTime? LaunchTime { get; set; } 
    }
}
