
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public decimal BaseSalary { get; set; }
        public int DepartamentId { get; set; }
        public Departament Departament { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller ()
        {

        }

        public Seller(string name, string email, DateTime birthDate, decimal baseSalary, Departament departament)
        {            
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
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
