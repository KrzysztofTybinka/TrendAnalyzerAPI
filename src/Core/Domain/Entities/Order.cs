using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;

namespace Domain.Entities
{
    public class Order()
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Paid by a seller, shipping costs etc.
        public List<Cost> TotalCost { get; set; }

        //Paid by a buyer
        public Money TotalPrice { get; set; }
        public bool Paid { get; set; }
        public Product Product { get; set; }
        public Buyer Buyer { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
