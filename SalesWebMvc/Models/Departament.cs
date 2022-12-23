using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; }

        public Departament()
        {

        }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSeller(Seller s)
        {
            Sellers.Add(s);
        }

        public double TotalSalesSeller(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.totalSales(initial, final));
        }

    }
}
