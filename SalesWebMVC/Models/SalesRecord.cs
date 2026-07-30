using SalesWebMVC.Models.Enum;

namespace SalesWebMVC.Models
{
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
