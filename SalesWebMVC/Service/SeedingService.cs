using SalesWebMVC.Models;
using SalesWebMVC.Models.Enum;

namespace SalesWebMVC.Service
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departament.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DBDatabase já possui informação então não a população do banco
            }

            Departament d1 = new Departament(1, "Computadores");
            Departament d2 = new Departament(2, "Eletronicos");
            Departament d3 = new Departament(3, "Moda");
            Departament d4 = new Departament(4, "Livros");

            Seller s1 = new Seller(1, "Jonas Guimarães", "jonas@gmail.com", new DateTime(1998, 4, 21), 1250.00m, d1);
            Seller s2 = new Seller(2, "Maria Silva", "maria.silva@gmail.com", new DateTime(1995, 8, 12), 1800.00m, d2);
            Seller s3 = new Seller(3, "Carlos Oliveira", "carlos.oliveira@gmail.com", new DateTime(1992, 11, 5), 2500.00m, d1);
            Seller s4 = new Seller(4, "Fernanda Souza", "fernanda.souza@gmail.com", new DateTime(1999, 2, 18), 2200.00m, d3);
            Seller s5 = new Seller(5, "Lucas Pereira", "lucas.pereira@gmail.com", new DateTime(1997, 6, 30), 1950.00m, d2);
            Seller s6 = new Seller(6, "Juliana Costa", "juliana.costa@gmail.com", new DateTime(1994, 9, 25), 2750.00m, d1);

            
            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 9, 25), 11000.00m, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 7, 14), 7000.00m, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2018, 10, 5), 4000.00m, SaleStatus.Canceled, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2018, 8, 30), 8000.00m, SaleStatus.Pedding, s4);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2018, 6, 18), 3000.00m, SaleStatus.Billed, s5);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2018, 11, 2), 15000.00m, SaleStatus.Billed, s6);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2018, 12, 10), 9500.00m, SaleStatus.Pedding, s1);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2018, 5, 21), 6200.00m, SaleStatus.Canceled, s2);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2018, 4, 13), 5200.00m, SaleStatus.Billed, s4);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2018, 3, 7), 13000.00m, SaleStatus.Billed, s5);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2018, 1, 15), 4500.00m, SaleStatus.Billed, s3);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2018, 2, 20), 9800.00m, SaleStatus.Pedding, s6);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2018, 3, 28), 7200.00m, SaleStatus.Billed, s2);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2018, 4, 9), 5300.00m, SaleStatus.Canceled, s1);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2018, 5, 17), 8600.00m, SaleStatus.Billed, s5);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2018, 6, 5), 3900.00m, SaleStatus.Pedding, s4);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2018, 7, 23), 10400.00m, SaleStatus.Billed, s6);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2018, 8, 11), 6100.00m, SaleStatus.Canceled, s3);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(2018, 9, 2), 12700.00m, SaleStatus.Billed, s2);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(2018, 10, 19), 3400.00m, SaleStatus.Pedding, s1);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(2018, 11, 27), 9100.00m, SaleStatus.Billed, s4);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(2018, 12, 14), 7600.00m, SaleStatus.Billed, s5);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(2019, 1, 8), 11800.00m, SaleStatus.Pedding, s6);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(2019, 2, 13), 6800.00m, SaleStatus.Canceled, s2);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(2019, 3, 4), 8300.00m, SaleStatus.Billed, s3);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(2019, 4, 22), 5900.00m, SaleStatus.Pedding, s1);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(2019, 5, 16), 13200.00m, SaleStatus.Billed, s5);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(2019, 6, 7), 4700.00m, SaleStatus.Canceled, s4);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(2019, 7, 29), 10100.00m, SaleStatus.Billed, s6);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(2019, 8, 18), 8800.00m, SaleStatus.Pedding, s2);

            _context.Departament.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11, sr12, sr13, sr14,
                sr15, sr16, sr17, sr18, sr19, sr20, sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30);

            _context.SaveChanges();
        }
    }
}
