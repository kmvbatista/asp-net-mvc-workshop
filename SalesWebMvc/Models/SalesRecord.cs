using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public Seller Seller { get; set; }
        public SaleStatus Status { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, Seller seller, SaleStatus status, DateTime date, double amount)
        {
            Id = id;
            Seller = seller;
            Status = status;
            Date = date;
            Amount = amount;
        }
    }
}
