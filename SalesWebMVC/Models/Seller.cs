
namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal BaseSalary { get; set; }
        public Departament departament { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller ()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, decimal baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            this.departament = departament;
        }

        public void AddSales(SalesRecord record)
        {
            Sales.Add(record);
        }
        public void RemoveSales(SalesRecord record)
        {
            Sales.Remove(record);
        }
        public decimal TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(record => record.Date >= initial && record.Date <= final).Sum(record => record.Ammount);
        }

    } 
}
