using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModuleHW.DataAccess;
using ModuleHW.DataAccess.Models;

namespace ModuleHW.StartApplication
{
    public class Starter
    {
        public void Run()
        {
            var configFile = "appsettings.json";
            var configFileInfo = new FileInfo(configFile);

            if (configFileInfo.Exists)
            {
                IConfiguration configuration = new ConfigurationBuilder().AddJsonFile(configFile).Build();
                var connectionString = configuration.GetConnectionString("SuperTestDB123");

                var serviceProvider = new ServiceCollection()
                    .AddDbContext<ApplicationContext>(optionsDb => optionsDb
                    .UseSqlServer(connectionString, optionsSql => optionsSql
                    .CommandTimeout(30))
                    .UseLazyLoadingProxies())
                    .AddOptions()
                    .BuildServiceProvider();

                var e = $"{string.Empty}";

                Console.WriteLine("\n!------- Ex - 1 - BGN -------!\n");

                using (var db = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    var employees = db.Employees.Select(employee => new
                    {
                        employee.Id,
                        employee.FirstName,
                        employee.LastName,
                        OfficeIdEmployee = employee.OfficeId.GetValueOrDefault(-1),
                        OfficeNameEmployee = employee.Office.Name ?? "[EMPTY]",
                        TitleIdEmployee = employee.TitleId.GetValueOrDefault(-1),
                        TitleNameEmployee = employee.Title.Name ?? "[EMPTY]",
                    });

                    foreach (var employee in employees)
                    {
                        Console.WriteLine(
                            $"{Environment.NewLine}" +
                            $"Id:{e,-18}{employee.Id}\n" +
                            $"Name:{e,-16}{employee.FirstName} {employee.LastName}\n" +
                            $"OfficeIdEmployee:{e,-4}{employee.OfficeIdEmployee}\n" +
                            $"OfficeNameEmployee:{e,-2}{employee.OfficeNameEmployee}\n" +
                            $"TitleIdEmployee:{e,-5}{employee.TitleIdEmployee}\n" +
                            $"TitleNameEmployee:{e,-3}{employee.TitleNameEmployee}\n");
                    }
                }

                Console.WriteLine("\n!------- Ex - 1 - END -------!\n");
                Console.WriteLine("\n!------- Ex - 2 - BGN -------!\n");

                using (var db = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    var diffs = db.Employees
                        .SelectMany(e => e.EmployeeProject, (e, ep) => new
                        {
                            e.Id,
                            e.FirstName,
                            e.LastName,
                            OfficeName = e.Office.Name,
                            TitleName = e.Title.Name,
                            e.HiredDate,
                            HiredDateToTodayDayDiff = EF.Functions.DateDiffDay(e.HiredDate, DateTime.Today),
                            ProjectName = ep.Project.Name,
                            ep.StartedDate,
                            StartedDateToTodayDayDiff = EF.Functions.DateDiffDay(ep.StartedDate, DateTime.Today),
                        });

                    foreach (var diff in diffs)
                    {
                        Console.WriteLine(
                            $"{Environment.NewLine}" +
                            $"Id: {diff.Id}\n" +
                            $"Name: {diff.FirstName} {diff.LastName}\n" +
                            $"Office: {diff.OfficeName}\n" +
                            $"Title: {diff.TitleName}\n" +
                            $"HiredDate: {diff.HiredDate}\n" +
                            $"HiredDateToTodayDayDiff: {diff.HiredDateToTodayDayDiff}\n" +
                            $"ProjectName: {diff.ProjectName}\n" +
                            $"StartedDate: {diff.StartedDate}\n" +
                            $"StartedDateToTodayDayDiff: {diff.StartedDateToTodayDayDiff}\n");
                    }
                }

                Console.WriteLine("\n!------- Ex - 2 - END -------!\n");
                Console.WriteLine("\n!------- Ex - 3 - BGN -------!\n");

                using (var db = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    using var transaction = db.Database.BeginTransaction();

                    try
                    {
                        var upd1 = db.Employees.Find(52);

                        if (upd1 != default)
                        {
                            upd1.FirstName = "Updated FN";
                            upd1.LastName = "Updated LN";
                            upd1.OfficeId = 4;
                            upd1.HiredDate = DateTime.Today.AddYears(-100);

                            db.Employees.Update(upd1);

                            db.SaveChanges();
                        }

                        var upd2 = db.Clients.Where(c => c.Company == "GG.inc").FirstOrDefault();

                        if (upd2 != default)
                        {
                            upd2.Company = "notGG.notINC";
                            upd2.Location = "Hazapetoffka";

                            db.Clients.Update(upd2);

                            db.SaveChanges();
                        }

                        IEnumerable<Employee> employees1 = db.Employees
                            .Where(e => e.FirstName.Contains("FName"))
                            .AsEnumerable()
                            .Select(e =>
                            {
                                e.FirstName = $"UpdatedFirstName{e.FirstName[(e.FirstName.Length - 4) ..e.FirstName.Length]}";
                                return e;
                            });

                        if (employees1.Any())
                        {
                            foreach (var employee in employees1)
                            {
                                db.Entry(employee).State = EntityState.Modified;
                            }

                            Console.WriteLine("\nFirstName of Employees changed to UpdatedFirstName...");
                        }

                        IEnumerable<Employee> employees2 = db.Employees
                            .Where(e => e.FirstName.Contains("UpdatedFirstName"))
                            .AsEnumerable()
                            .Select(e =>
                            {
                                e.FirstName = $"FName{e.FirstName[(e.FirstName.Length - 4) ..e.FirstName.Length]}";
                                return e;
                            });

                        if (employees2.Any())
                        {
                            foreach (var employee in employees2)
                            {
                                db.Entry(employee).State = EntityState.Modified;
                            }

                            Console.WriteLine("\nFirstName of Employees changed to FName...");
                        }

                        db.SaveChanges();
                        transaction.Commit();
                        Console.WriteLine("\nTransaction Ex.3 commited successfully!\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n\nTransaction Ex.3 Exception Error Message:");
                        Console.WriteLine(ex?.Message);

                        if (ex?.InnerException?.Message != null)
                        {
                            Console.WriteLine("\nTransaction Ex.3 InnerExeption Error Message:");
                            Console.WriteLine(ex?.InnerException?.Message);
                        }

                        transaction.Rollback();
                    }
                }

                Console.WriteLine("\n!------- Ex - 3 - END -------!\n");
                Console.WriteLine("\n!------- Ex - 4 - BGN -------!\n");

                using (var db = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    using var transaction = db.Database.BeginTransaction();

                    try
                    {
                        db.Clients.Add(new Client() { FirstName = "FN0", LastName = "LN0", Company = "GG.inc", Email = "mm@mm.mm", Location = "NH, U.S.", });

                        var employee = new Employee() { FirstName = "FN1", LastName = "LN1", HiredDate = DateTime.Today.AddDays(-50), TitleId = 1, OfficeId = 2, };
                        employee.EmployeeProject.Add(new EmployeeProject() { ProjectId = 3, Rate = 50000M, StartedDate = DateTime.Today.AddDays(-100) });
                        db.Employees.Add(employee);
                        db.SaveChanges();

                        var employee2 = new Employee() { FirstName = "FN2", LastName = "LN2", HiredDate = DateTime.Today.AddDays(-60), TitleId = 2, OfficeId = 3, };
                        db.Employees.Add(employee2);
                        db.SaveChanges();

                        var employeeProject = new EmployeeProject() { EmployeeId = employee2.Id, ProjectId = 5, Rate = 70000M, StartedDate = DateTime.Today.AddDays(-70) };
                        db.EmployeeProjects.Add(employeeProject);
                        db.SaveChanges();

                        transaction.Commit();
                        Console.WriteLine("\nTransaction Ex.4 commited successfully!\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n\nTransaction Ex.4 Exception Error Message:");
                        Console.WriteLine(ex?.Message);

                        if (ex?.InnerException?.Message != null)
                        {
                            Console.WriteLine("\nTransaction Ex.4 InnerExeption Error Message:");
                            Console.WriteLine(ex?.InnerException?.Message);
                        }

                        transaction.Rollback();
                    }
                }

                Console.WriteLine("\n!------- Ex - 4 - END -------!\n");
                Console.WriteLine("\n!------- Ex - 5 - BGN -------!\n");

                using (var db = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    using var transaction = db.Database.BeginTransaction();

                    try
                    {
                        var del1 = db.Employees.Where(e => e.FirstName == "FN1" && e.LastName == "LN1" && e.HiredDate == DateTime.Today.AddDays(-50) && e.TitleId == 1 && e.OfficeId == 2).FirstOrDefault();
                        var del2 = db.Employees.Where(e => e.FirstName == "FN2" && e.LastName == "LN2" && e.HiredDate == DateTime.Today.AddDays(-60) && e.TitleId == 2 && e.OfficeId == 3).FirstOrDefault();

                        if (del1 is Employee && del2 is Employee)
                        {
                            db.Employees.Remove(del1);
                            db.Employees.Remove(del2);
                            db.SaveChanges();
                            Console.WriteLine("\nEmployees del1 & del2 successfully removed!");
                        }

                        var del3 = db.Clients.Where(c => c.Company == "GG.inc" && c.Email == "mm@mm.mm" && c.Location == "NH, U.S.").FirstOrDefault();
                        var del4 = db.Clients.Where(c => c.Company == "notGG.notINC" && c.Email == "mm@mm.mm" && c.Location == "Hazapetoffka").FirstOrDefault();

                        if (del3 is Client && del4 is Client)
                        {
                            db.Clients.Remove(del3);
                            db.Clients.Remove(del4);
                            db.SaveChanges();
                            Console.WriteLine("\nClients del3 & del4 successfully removed!");
                        }

                        db.SaveChanges();
                        transaction.Commit();
                        Console.WriteLine("\nTransaction Ex.5 commited successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n\nTransaction Ex.5 Exception Error Message:");
                        Console.WriteLine(ex?.Message);

                        if (ex?.InnerException?.Message != null)
                        {
                            Console.WriteLine("\nTransaction Ex.5 InnerExeption Error Message:");
                            Console.WriteLine(ex?.InnerException?.Message);
                        }

                        transaction.Rollback();
                    }
                    finally
                    {
                        Console.WriteLine(string.Empty);
                    }
                }

                Console.WriteLine("\n!------- Ex - 5 - END -------!\n");
                Console.WriteLine("\n!------- Ex - 6 - BGN -------!\n");

                using (var db = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    db.Database.CloseConnection();
                    db.Database.OpenConnection();

                    var empTitles1 = from emp in db.Employees
                                     group emp by emp.Title.Name into emptitle
                                     where !EF.Functions.Like(emptitle.Key, "%A%")
                                     select new
                                     {
                                         Name = emptitle.Key,
                                         Count = emptitle.Count(),
                                     };

                    foreach (var empTitle in empTitles1)
                    {
                        Console.WriteLine(
                             $"{Environment.NewLine}" +
                             $"Employees with Title \"{empTitle.Name}\" - {empTitle.Count}");
                    }
                }

                Console.WriteLine("\n\n!------- Ex - 6 - END -------!\n");
            }
            else
            {
                Console.WriteLine($"ERROR! There is no config file \"{configFile}\" provided!");
                Environment.Exit(0);
            }
        }
    }
}
