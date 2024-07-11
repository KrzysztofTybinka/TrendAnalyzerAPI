using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;

namespace Domain.Entities
{
    public class Order(int Id, string Name, string Description,
        List<Cost> TotalCost, Money TotalPrice, bool Paid, 
        Product Product, Buyer Buyer)
    {
        public int Id { get; set; } = Id;
        public string Name { get; set; } = Name;
        public string Description { get; set; } = Description;

        //Paid by a seller, shipping costs etc.
        public List<Cost> TotalCost { get; set; } = TotalCost;

        //Paid by a buyer
        public Money TotalPrice { get; set; } = TotalPrice;
        public bool Paid { get; set; } = Paid;
        public Product Product { get; set; } = Product;
        public Buyer Buyer { get; set; } = Buyer;
    }
}
