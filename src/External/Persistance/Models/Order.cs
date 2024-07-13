using Domain.Entities;
using Domain.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double TotalPrice { get; set; }
        public bool Paid { get; set; }
        public Product Product { get; set; }
        public Buyer Buyer { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
