using Company.DAL.Database;
using Company.DAL.Entity;

//Employees employee = new Employees() { name = "Essa Ahmed" , phone = "01096001609" , email = "essaahmeed00@gmail.com"};
DepartMent departMent = new DepartMent() { Name = "Cairo" , address = "" };
ApplicationDbContext context = new ApplicationDbContext();
context.Add(departMent);
context.SaveChanges();
