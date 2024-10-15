// სავარჯიშო 1: თანამშრომლების ხელფასები
// შენ გაქვს კომპანია და გინდა შექმნა პროგრამა, რომელიც თანამშრომლების სახელფასო
// მონაცემებისა და ნამუშევარი დროის მიხედვით დაინგარიშებს ჯამურ ანაზღაურებას.
// ● ნამუშევარ საათებს ვითვლით ყოველდღიურად.
// ● თანამშრომელს ანაზღაურებს ვაძლევთ საათების მიხედვით.
// ● თუ ნამაშრომელმა იმუშავა დღეში 8-საათზე მეტი მაშინ ვუხდით ზეგანაკვეთურ
// ანაზღაურებას. ზეგანაკვეთური ანაზღაურება ერიცხება მხოლოდ იმ საათებზე რომელი
// 8-სამუშაო საათის მიღმაა. მაგალითად თუ იმუშავა 10 საათი, ზეგანაკვეთური
// ანაზღაურება ერიცხება 2-საათზე.
// ● თანამშრომლებს ზეგანაკვეთურ ნამუშევარ საათებში ვუხდით ხელფასის 125%-ს
// გარდა ჯამური ხელფასისა პროგრამამ უნდა გამოიტანოს იმ თანამშრომლების სია რომლებმაც
// ზეგანაკვეთურად იმუშავეს და მათთვის მისაცემი ანაზღაურება

// public class Employee
// {

//     public string FirstName {get; set;}
//     public string LastName {get; set;}
//     public int ID {get; set;}
//     public decimal Salary {get; set;}
//     public double WorkedHours {get; set;}


//     public Employee (string firstName, string lastName, int id, decimal salary, int workedHours)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//         ID = id;
//         Salary = salary;
//         WorkedHours = workedHours;
//     }

// }

// internal class Program
// {


//     public static void Main()
//     {
//         List<Employee> employees = new List<Employee>();
//         string answer;
//         do 
//         {
//             Console.WriteLine("Input Employee First Name:");
//             string firstName = Console.ReadLine();

//             Console.WriteLine("Input Employee Last Name:");
//             string lastName = Console.ReadLine();

//             Console.WriteLine("Input Employee ID:");
//             int id = int.Parse(Console.ReadLine());

//             Console.WriteLine("Input Employee Salary:");
//             decimal salary = decimal.Parse(Console.ReadLine());

//             Console.WriteLine("Input Worked Hours:");
//             int workedHours = int.Parse(Console.ReadLine());

//             employees.Add(new Employee(firstName, lastName, id, salary, workedHours));

//             System.Console.WriteLine("Do u want to continue?");
//             answer = Console.ReadLine();
//         }
//         while (answer.ToLower() == "y" || answer.ToLower() == "yes");



//         const int NormalWorkingHours = 8;
//         const decimal OvertimePercent = 1.25m;
//         double Overtime;
//         decimal TotalSalary = 0m;

//         foreach (var Employee in employees)
//         {   

//             Overtime = NormalWorkingHours - Employee.WorkedHours;

//             if (Overtime < 0)
//             {

//                 Overtime = Math.Abs(Overtime);

//                 System.Console.WriteLine("This Employe Has Overtime:");

//                 Employee.Salary = Employee.Salary * OvertimePercent;
//                 Employee.WorkedHours = Employee.WorkedHours + Overtime;

//                 System.Console.WriteLine("First Name:" + Employee.FirstName + " " + "Last Name:" + Employee.LastName + " " + "ID:" + Employee.ID + " " + "Salary:" + Employee.Salary);


//             }
//             else
//             {
//                 System.Console.WriteLine("This Employe Has Not Overtime:");
//                 System.Console.WriteLine("First Name:" + Employee.FirstName + " " + "Last Name:" + Employee.LastName + " " + "ID:" + Employee.ID + " " + "Salary:" + Employee.Salary);
//             }

//             TotalSalary =+ Employee.Salary;
//         }
//         System.Console.WriteLine("Total salary: " + TotalSalary);
//     }
// }





// სავარჯიშო 2: პროდუქციის მარაგის მართვა
// შენი კომპანია ყიდის პროდუქტებს და გჭირდება პროგრამა, რომელიც მართავს პროდუქციის
// ჩამონათვალს. პროდუქტს აქვს დასახელება, ფასი და რაოდენობა.
// პროგრამამ უნდა დაიანგარიშოს თითოეული პროდუქტის ჯამური ღირებულება, და ასევე
// პროდუქტების საერთო ღირებულება.



// internal class Program
// {
//     public class Product
//     {
//         public string Name { get; set; }
//         public decimal Price { get; set; }
//         public int Quantity { get; set; }

//         public Product(string name, decimal price, int quantity)
//         {
//             Name = name;
//             Price = price;
//             Quantity = quantity;
//         }

//     }

//     public static void Main()
//     {
//         decimal TotalAmount = 0m;
//         decimal TotalProductAmount = 0;
//         List<Product> products = new List<Product>();

//         products.Add(new Product("Pen", 2, 10));
//         products.Add(new Product("Pencil", 3, 5));

//         foreach (Product product in products)
//         {
//             TotalProductAmount = product.Price*product.Quantity;
//             System.Console.WriteLine("Product Name: " + product.Name + " " + "Total Product Amount: " + TotalProductAmount);
//             TotalAmount += TotalProductAmount;
//         }
//         Console.WriteLine("Total Amount: " + TotalAmount);

//     }
// }



// სავარჯიშო 3: პროდუქციის გაყიდვების მართვა
// შენი კომპანია ყიდის პროდუქტებს. გვჭირდება პროგრამა რომელიც დაიანგარიშებს
// გაყიდვების სტატისტიკას.
// ● პროგრამა უნდა ითვლიდეს გაყიდვების ჯამურ ღირებულებას კვირის დღეების
// მიხედვით
// ● პროგრამა უნდა ითვლიდეს გაყიდვების საერთო მოცულობას კვირის ბოლოს.



// using System.Security.Cryptography.X509Certificates;

// internal class Program
// {
//     public class Product
//     {
//         public string Name { get; set; }
//         public decimal Price { get; set; }
//         public int Quantity { get; set; }
//         public DateTime SalesDate{ get; set; }

//         public Product(string name, decimal price, int quantity, DateTime salesDate)
//         {
//             Name = name;
//             Price = price;
//             Quantity = quantity;
//             SalesDate = salesDate;
//         }
        
//     }

//     public static void Main()
//     {
//         decimal TotalAmount = 0m;
//         decimal TotalProductAmount = 0;
        
//         List<Product> products = new List<Product>();
        
//         products.Add(new Product("Pen", 2, 10, new DateTime(2024, 10, 14)));
//         products.Add(new Product("Pineapple", 2, 1, new DateTime(2024, 10, 14)));
//         products.Add(new Product("Pencil", 3, 5, new DateTime(2024, 10, 15)));



//         decimal MondaySalesTotal = 0m;
//         decimal TusedaySalesTotal = 0m;
        
//         foreach (Product product in products)
//         {
//             TotalProductAmount = product.Price*product.Quantity;

//             if (product.SalesDate.DayOfWeek == DayOfWeek.Monday)
//             {   
//                 MondaySalesTotal += TotalProductAmount;

//             }
//             else if (product.SalesDate.DayOfWeek == DayOfWeek.Tuesday)
//             {
//                 TusedaySalesTotal += TotalProductAmount;
//             }

//         }
        
//         System.Console.WriteLine("Monday Sales:");
//         Console.WriteLine("Total Amount: " + MondaySalesTotal);
        
//         System.Console.WriteLine("Tuesday Sales:");
//         Console.WriteLine("Total Amount: " + TusedaySalesTotal);
//     }
// }