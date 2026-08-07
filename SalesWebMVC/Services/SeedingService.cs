using SalesWebMVC.Models;
using SalesWebMVC.Models.Enum;

namespace SalesWebMVC.Service
{
    //dependencia do SalesWebMVCContext
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

            Departament d1 = new Departament("Computadores");
            Departament d2 = new Departament("Eletronicos");
            Departament d3 = new Departament("Moda");
            Departament d4 = new Departament("Livros");

            Seller s1 = new Seller("Jonas Guimarães", "jonas@gmail.com", new DateTime(1998, 4, 21), 1250.00m, d1);
            Seller s2 = new Seller("Maria Silva", "maria.silva@gmail.com", new DateTime(1995, 8, 12), 1800.00m, d2);
            Seller s3 = new Seller("Carlos Oliveira", "carlos.oliveira@gmail.com", new DateTime(1992, 11, 5), 2500.00m, d1);
            Seller s4 = new Seller("Fernanda Souza", "fernanda.souza@gmail.com", new DateTime(1999, 2, 18), 2200.00m, d3);
            Seller s5 = new Seller("Lucas Pereira", "lucas.pereira@gmail.com", new DateTime(1997, 6, 30), 1950.00m, d2);
            Seller s6 = new Seller("Juliana Costa", "juliana.costa@gmail.com", new DateTime(1994, 9, 25), 2750.00m, d1);
            Seller s7 = new Seller("Ricardo Almeida", "ricardo.almeida@gmail.com", new DateTime(1993, 3, 14), 2100.00m, d3);
            Seller s8 = new Seller("Patrícia Martins", "patricia.martins@gmail.com", new DateTime(1996, 7, 9), 1850.00m, d2);
            Seller s9 = new Seller("Gustavo Lima", "gustavo.lima@gmail.com", new DateTime(1991, 12, 1), 3200.00m, d1);
            Seller s10 = new Seller("Camila Rodrigues", "camila.rodrigues@gmail.com", new DateTime(1998, 5, 27), 2400.00m, d3);
            Seller s11 = new Seller("Bruno Ferreira", "bruno.ferreira@gmail.com", new DateTime(1990, 10, 15), 3100.00m, d2);
            Seller s12 = new Seller("Aline Gomes", "aline.gomes@gmail.com", new DateTime(1997, 1, 8), 2050.00m, d1);
            Seller s13 = new Seller("Eduardo Barbosa", "eduardo.barbosa@gmail.com", new DateTime(1994, 4, 19), 2600.00m, d3);
            Seller s14 = new Seller("Larissa Ribeiro", "larissa.ribeiro@gmail.com", new DateTime(1999, 8, 3), 1900.00m, d2);
            Seller s15 = new Seller("Thiago Carvalho", "thiago.carvalho@gmail.com", new DateTime(1992, 11, 22), 2950.00m, d1);
            Seller s16 = new Seller("Renata Dias", "renata.dias@gmail.com", new DateTime(1995, 2, 11), 2250.00m, d3);
            Seller s17 = new Seller("Felipe Araújo", "felipe.araujo@gmail.com", new DateTime(1996, 6, 17), 2350.00m, d2);
            Seller s18 = new Seller("Vanessa Rocha", "vanessa.rocha@gmail.com", new DateTime(1993, 9, 29), 2800.00m, d1);
            Seller s19 = new Seller("Marcelo Teixeira", "marcelo.teixeira@gmail.com", new DateTime(1991, 7, 13), 3300.00m, d3);
            Seller s20 = new Seller("Priscila Nunes", "priscila.nunes@gmail.com", new DateTime(1998, 12, 6), 2150.00m, d2);
            Seller s21 = new Seller("André Moreira", "andre.moreira@gmail.com", new DateTime(1990, 5, 20), 3450.00m, d1);
            Seller s22 = new Seller("Bianca Melo", "bianca.melo@gmail.com", new DateTime(1997, 10, 31), 2000.00m, d3);
            Seller s23 = new Seller("Leandro Santos", "leandro.santos@gmail.com", new DateTime(1994, 1, 24), 2700.00m, d2);
            Seller s24 = new Seller("Natália Fernandes", "natalia.fernandes@gmail.com", new DateTime(1996, 3, 5), 2450.00m, d1);
            Seller s25 = new Seller("Rafael Castro", "rafael.castro@gmail.com", new DateTime(1992, 8, 16), 3000.00m, d3);
            Seller s26 = new Seller("Daniela Moraes", "daniela.moraes@gmail.com", new DateTime(1995, 11, 28), 2300.00m, d2);


            SalesRecord sr1 = new SalesRecord(new DateTime(2018, 9, 25), 11000.00m, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(new DateTime(2018, 7, 14), 7000.00m, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(new DateTime(2018, 10, 5), 4000.00m, SaleStatus.Canceled, s3);
            SalesRecord sr4 = new SalesRecord(new DateTime(2018, 8, 30), 8000.00m, SaleStatus.Pedding, s4);
            SalesRecord sr5 = new SalesRecord(new DateTime(2018, 6, 18), 3000.00m, SaleStatus.Billed, s5);
            SalesRecord sr6 = new SalesRecord(new DateTime(2018, 11, 2), 15000.00m, SaleStatus.Billed, s6);
            SalesRecord sr7 = new SalesRecord(new DateTime(2018, 12, 10), 9500.00m, SaleStatus.Pedding, s1);
            SalesRecord sr8 = new SalesRecord(new DateTime(2018, 5, 21), 6200.00m, SaleStatus.Canceled, s2);
            SalesRecord sr9 = new SalesRecord(new DateTime(2018, 4, 13), 5200.00m, SaleStatus.Billed, s4);
            SalesRecord sr10 = new SalesRecord(new DateTime(2018, 3, 7), 13000.00m, SaleStatus.Billed, s5);
            SalesRecord sr11 = new SalesRecord(new DateTime(2018, 1, 15), 4500.00m, SaleStatus.Billed, s3);
            SalesRecord sr12 = new SalesRecord(new DateTime(2018, 2, 20), 9800.00m, SaleStatus.Pedding, s6);
            SalesRecord sr13 = new SalesRecord(new DateTime(2018, 3, 28), 7200.00m, SaleStatus.Billed, s2);
            SalesRecord sr14 = new SalesRecord(new DateTime(2018, 4, 9), 5300.00m, SaleStatus.Canceled, s1);
            SalesRecord sr15 = new SalesRecord(new DateTime(2018, 5, 17), 8600.00m, SaleStatus.Billed, s5);
            SalesRecord sr16 = new SalesRecord(new DateTime(2018, 6, 5), 3900.00m, SaleStatus.Pedding, s4);
            SalesRecord sr17 = new SalesRecord(new DateTime(2018, 7, 23), 10400.00m, SaleStatus.Billed, s6);
            SalesRecord sr18 = new SalesRecord(new DateTime(2018, 8, 11), 6100.00m, SaleStatus.Canceled, s3);
            SalesRecord sr19 = new SalesRecord(new DateTime(2018, 9, 2), 12700.00m, SaleStatus.Billed, s2);
            SalesRecord sr20 = new SalesRecord(new DateTime(2018, 10, 19), 3400.00m, SaleStatus.Pedding, s1);
            SalesRecord sr21 = new SalesRecord(new DateTime(2018, 11, 27), 9100.00m, SaleStatus.Billed, s4);
            SalesRecord sr22 = new SalesRecord(new DateTime(2018, 12, 14), 7600.00m, SaleStatus.Billed, s5);
            SalesRecord sr23 = new SalesRecord(new DateTime(2019, 1, 8), 11800.00m, SaleStatus.Pedding, s6);
            SalesRecord sr24 = new SalesRecord(new DateTime(2019, 2, 13), 6800.00m, SaleStatus.Canceled, s2);
            SalesRecord sr25 = new SalesRecord(new DateTime(2019, 3, 4), 8300.00m, SaleStatus.Billed, s3);
            SalesRecord sr26 = new SalesRecord(new DateTime(2019, 4, 22), 5900.00m, SaleStatus.Pedding, s1);
            SalesRecord sr27 = new SalesRecord(new DateTime(2019, 5, 16), 13200.00m, SaleStatus.Billed, s5);
            SalesRecord sr28 = new SalesRecord(new DateTime(2019, 6, 7), 4700.00m, SaleStatus.Canceled, s4);
            SalesRecord sr29 = new SalesRecord(new DateTime(2019, 7, 29), 10100.00m, SaleStatus.Billed, s6);
            SalesRecord sr30 = new SalesRecord(new DateTime(2019, 8, 18), 8800.00m, SaleStatus.Pedding, s2);

            _context.Departament.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10,s11, s12, s13, s14, s15, s16, s17, s18, s19, s20,s21, s22, s23, s24, s25, s26);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11, sr12, sr13, sr14,
                sr15, sr16, sr17, sr18, sr19, sr20, sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30);

            _context.SaveChanges();
        }
    }
}
