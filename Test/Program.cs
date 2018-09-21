using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext appDb = new AppDbContext())
            {
                for (int i = 0; i < 5; i++)
                {
                    var user = new User() { Email = $"email-{i}@m.com", Name = $"Name - {i}", Phone = ((i + 1) * 756321).ToString() };
                    appDb.Users.Add(user);
                    var car = new Car() { Category = $"category-{i}", Model = $"model-{i}", Price = (i + 1) * 1535 };
                    appDb.Cars.Add(car);
                    var order = new Order() { Adress = "asdasd", Car = car, City = "city", Country = "country", Date = DateTime.Now, Quantity = i + 1, User = user };
                    appDb.Orders.Add(order);
                    var mInfo = new ManagerInfo() { IsCompleted = i % 2 == 0 ? true : false, Order = order };
                    appDb.ManagerInfos.Add(mInfo);
                }
                Console.WriteLine(appDb.SaveChanges());
            }

            using (AppDbContext appDb = new AppDbContext())
            {
                var list = appDb.ManagerInfos.Include(x => x.Order).ThenInclude(x=>x.User).Include(x=>x.Order.Car).ToListAsync().Result;
                foreach (var item in list)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"{item.Id} / {item.IsCompleted}  /  {item.Order.Quantity}| {item.Order.User.Name}  / {item.Order.Car.Model}");
                }


                var user = appDb.Users.Where(x => x.Id == 2).Include(x => x.Orders).FirstOrDefault();
                foreach (var item in user.Orders)
                {
                    Console.WriteLine(item.Adress+"/"+item.Car.Model);
                }
               
            }
            Console.WriteLine("Hello World!");
        }
    }
    public class BAppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = EFGetStarted.AspNetCore.NewDb; Trusted_Connection = True; ConnectRetryCount = 0");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
