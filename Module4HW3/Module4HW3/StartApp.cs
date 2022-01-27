using Microsoft.EntityFrameworkCore;
using Module4HW3.Entities;

namespace Module4HW3
{
    public class StartApp
    {
        private ApplicationDbContext _context;
        public StartApp(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task FirstTask()
        {
            await using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var data = from office in _context.Offices
                               join emplyee in _context.Employees on office.OfficeId equals emplyee.OfficeId into smth
                               from employee in smth.DefaultIfEmpty()
                               select new
                               {
                                   HiredDate = employee.HiredDate,
                                   TitleId = employee.TitleId,
                                   Location = office.Location,
                               };
                    var result = from someData in data
                                 join title in _context.Titles on someData.TitleId equals title.TitleId
                                 select new
                                 {
                                     CompanyName = title.Name,
                                     Location = someData.Location,
                                     HiredDate = someData.HiredDate
                                 };
                    foreach (var i in result)
                    {
                        Console.WriteLine($"{i.CompanyName} {i.Location} {i.HiredDate}");
                    }

                    Console.WriteLine("Left join is done");
                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    await transaction.RollbackAsync();
                }
            }
        }

        public async Task SecondTask()
        {
            await using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var data = await _context.Employees
                    .Select(e => e.HiredDate)
                    .ToListAsync();
                    foreach (var i in data)
                    {
                        Console.WriteLine(DateTime.UtcNow.Subtract(i));
                    }

                    Console.WriteLine("Second Task is done");
                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    await transaction.RollbackAsync();
                }
            }
        }

        public async Task ThirdTask()
        {
            await using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var firstData = await _context.Projects
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        .FirstOrDefaultAsync(item => item.Name.Contains('a'));
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                    var secondData = _context.Offices
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        .FirstOrDefault(item => item.Title.StartsWith('b'));
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                    if (firstData != null && secondData != null)
                    {
                        firstData.Name = "AMOGUS";
                        secondData.Title = "ABCHIXBA";
                        _context.Projects.Update(firstData);
                        _context.Offices.Update(secondData);
                    }

                    Console.WriteLine("Task 3 is done");

                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    await transaction.RollbackAsync();
                }
            }
        }

        public async Task FourthTask()
        {
            await using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    await _context.AddAsync(new Employee()
                    {
                        FirstName = "Andrew",
                        LastName = "Kara",
                        HiredDate = new DateTime(2015, 7, 20),
                        Title = new Title() { Name = "title" },
                        Office = new Office() { Location = "Kyiv", Title = "qwe" }
                    });

                    Console.WriteLine("Task 4 is done");

                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    await transaction.RollbackAsync();
                }
            }
        }

        public async Task FifthTask()
        {
            await using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var entityOnDelete = await _context.Employees
                        .FirstOrDefaultAsync(item => item.LastName == "Kara");

                    if (entityOnDelete != null)
                    {
                        _context.Remove(entityOnDelete);
                    }

                    Console.WriteLine("Task 5 is done");

                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    await transaction.RollbackAsync();
                }
            }
        }

        public async Task SixthQuery()
        {
            await using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var entity = _context.Employees
                        .GroupBy(item => item.Title)
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        .Select(item => !item.Key.Name.Contains("q"));
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                    Console.WriteLine("Task 6 is done");

                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    await transaction.RollbackAsync();
                }
            }
        }
    }
}
