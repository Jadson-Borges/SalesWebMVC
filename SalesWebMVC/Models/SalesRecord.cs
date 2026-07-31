using SalesWebMVC.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    [Display(Name = "Registro de Vendas")]
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Ammount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord() 
        {
        }

        public SalesRecord(DateTime date, decimal ammount, SaleStatus status, Seller seller)
        {
            Date = date;
            Ammount = ammount;
            Status = status;
            Seller = seller;
        }
    }
}
