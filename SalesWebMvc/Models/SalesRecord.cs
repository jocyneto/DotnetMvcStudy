using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime DateSale { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime dateSale, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            DateSale = dateSale;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
