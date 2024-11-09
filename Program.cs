using SuperMarketEF2._0.Data;
using SuperMarketEF2._0.Models;

namespace SuperMarketEF2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SuperMarketContext context = new SuperMarketContext();

            Category oilCategory = new Category()
            {
                Name = "Oil",
                Description = "Oil Category"
            };

            context.Categories.Add(oilCategory);

            Category grainsCategory = new Category()
            {
                Name = "Grains",
                Description = "Grains Category"
            };

            context.Categories.Add(grainsCategory);

            context.SaveChanges();


            Product Aceitedeoliva = new Product()
            {
                Name = "Aceite de oliva",
                Price = 2000,
                Stock = 4,
                CategoryId = 2
            };
            context.Products.Add(Aceitedeoliva);

            Product AceiteVegetal = new Product()
            {
                Name = "Aceite Vegetal",
                Price = 1500,
                Stock = 4,
                CategoryId = 2
            };
            context.Products.Add(AceiteVegetal);

            Product Arroz = new Product()
            {
                Name = "Arroz",
                Price = 1000,
                Stock = 5,
                CategoryId = 1
            };
            context.Products.Add(Arroz);

            Product Lentejas = new Product()
            {
                Name = "Lentejas",
                Price = 1500,
                Stock = 9,
                CategoryId = 1
            };
            context.Products.Add(Lentejas);
            context.SaveChanges();

            Customer Nico = new Customer()
            {
                Document = 'c',
                Name = "Nico",
                LastName = "Sanchez",
                Address = "Carrera x # xxxxx",
                Birthday = DateTime.Now,
                Number = '3',
                Email = "enicoasdadhasd@gmail.com"
            };
            context.Customers.Add(Nico);
            context.SaveChanges();

            Paymode Efectivo = new Paymode()
            {
                Name = "Efectivo",
                Observation = "efectivo modo y metodo de pago"
            };
            context.Add(Efectivo);
            context.SaveChanges();

            Invoice Factura = new Invoice()
            {
                Number = 1,
                CustomerId = 1,
                Date = DateTime.Now,
                PaymodeId = 1
            };
            context.Add(Factura);
            context.SaveChanges();

            Detail Detalle = new Detail()
            {
                InvoiceId = 1,
                ProductId = 1,
                Quiantity = 1,
                Price = 2000
            };
            context.Add(Detalle);
            context.SaveChanges();
        }
    }
}
