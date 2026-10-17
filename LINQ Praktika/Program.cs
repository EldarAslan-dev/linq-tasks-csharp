// List of numbers
using LINQ_Praktika;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30 };
// List of strings
var cities = new List<string> { "New York", "London", "Tokyo", "Paris", "Berlin", "Sydney", "Toronto", "Mumbai", "Barcelona"};
// List of employees
var employees = new List<Employee>
{
new Employee { Id = 1, Name = "John Smith", Department = "IT", Salary = 75000, Age = 28 },
new Employee { Id = 2, Name = "Sarah Johnson", Department = "HR", Salary = 65000, Age = 32 },
new Employee { Id = 3, Name = "Mike Wilson", Department = "IT", Salary = 85000, Age = 35 },
new Employee { Id = 4, Name = "Emily Davis", Department = "Finance", Salary = 70000, Age = 29 },
new Employee { Id = 5, Name = "David Brown", Department = "IT", Salary = 95000, Age = 40 },
new Employee { Id = 6, Name = "Lisa Garcia", Department = "Marketing", Salary = 60000, Age = 26 },
new Employee { Id = 7, Name = "Robert Taylor", Department = "Finance", Salary = 80000, Age = 38 },
new Employee { Id = 8, Name = "Jennifer Lee", Department = "HR", Salary = 55000, Age = 24 }
};


var orders = new List<Order>
{
new Order { Id = 1, CustomerName = "Alice", Amount = 150.50m, OrderDate = new DateTime(2024, 1, 15) },
new Order { Id = 2, CustomerName = "Bob", Amount = 89.99m, OrderDate = new DateTime(2024, 2, 10) },
new Order { Id = 3, CustomerName = "Alice", Amount = 200.00m, OrderDate = new DateTime(2024, 1, 25) },
new Order { Id = 4, CustomerName = "Charlie", Amount = 75.25m, OrderDate = new DateTime(2024, 3, 5) },
new Order { Id = 5, CustomerName = "Bob", Amount = 120.75m, OrderDate = new DateTime(2024, 2, 20) },
new Order { Id = 6, CustomerName = "Diana", Amount = 300.00m, OrderDate = new DateTime(2024, 1, 30) }
};


//1.Cüt ədədlərin filtrlənməsi: numbers(ədədlər) siyahısından bütün cüt ədədləri əldə edin.


//var evenNumbers = numbers.Where(n => n % 2 == 0);
//foreach (var number in evenNumbers)
//{
//    Console.WriteLine(number);
//}



//2.Müəyyən hərflə başlayan şəhərlər: "L" və ya "T" hərfi ilə başlayan bütün şəhərləri tapın.

//var filteredCities = cities.Where(city => city.StartsWith("L") || city.StartsWith("T"));
//foreach (var city in filteredCities)
//{
//    Console.WriteLine(city);
//}


//3.Yüksək maaşlı işçilər: Maaşı 70 000 dollardan çox olan bütün işçiləri əldə edin.


//var highSalaryEmployees = employees.Where(emp => emp.Salary > 70000);
//foreach (var employee in highSalaryEmployees)
//{
//    Console.WriteLine($"{employee.Name}: {employee.Salary}");
//}


//4.Gənc işçilər: Yaşı 30-dan az olan işçiləri tapın.



//var youngEmployees = employees.Where(emp => emp.Age < 30);
//foreach (var employee in youngEmployees)
//{
//    Console.WriteLine($"{employee.Name}: {employee.Age}");
//}


//5.Ədədlərin kvadratı: numbers (ədədlər) siyahısındakı hər bir ədədin
//kvadratını ehtiva edən yeni bir siyahı yaradın.


//var squaredNumbers = numbers.Select(n => n * n);
//foreach (var number in squaredNumbers)
//{
//    Console.WriteLine(number);
//}


//6.Şəhər adlarının uzunluğu: Şəhər adlarını hərflərinin
//sayı ilə birlikdə əks etdirən siyahı əldə edin.


//var cityLengths = cities.Select(city => new { City = city, Length = city.Length });
//foreach (var city in cityLengths)
//{
//    Console.WriteLine($"{city.City}: {city.Length}");  // bosluqlari da hesablayirdi !!
//}


//var cityLengths = cities.Select(city => new
//{
//    City = city,
//    Length = city.Replace(" ", "").Length // burda bosluqlar hesablanmir !!
//});

//foreach (var city in cityLengths)
//{
//    Console.WriteLine($"{city.City}: {city.Length}");
//}



//7.Yalnız işçilərin adları: Bütün işçilərin yalnız adlarını çıxarın.

//var employeeNames = employees.Select(emp => emp.Name);
//foreach (var name in employeeNames)
//{
//    Console.WriteLine(name);
//}


//8. İşçi haqqında xülasə: Ad (Name), Şöbə (Department) və
//maaşlarının ortalama maaşdan yüksək olub-olmadığını göstərən hesablanmış sahəni
//(field) özündə birləşdirən anonim obyektlər yaradın.


//var averageSalary = employees.Average(emp => emp.Salary);
//var data= employees.Select(emp => new
//{
//    emp.Name,
//    emp.Department,
//    IsAboveAverageSalary = emp.Salary > averageSalary
//});
//foreach (var summary in data)
//{
//    Console.WriteLine($"{summary.Name} - {summary.Department} - Above Average Salary: {summary.IsAboveAverageSalary}");
//}




//9. Şəhərlərin əlifba sırası ilə çeşidlənməsi: cities (şəhərlər) siyahısını əlifba sırası ilə düzün.

//var sortedCities = cities.OrderBy(city => city);
//foreach (var city in sortedCities)
//{
//    Console.WriteLine(city);
//}


//10. İşçilərin maaşa görə çeşidlənməsi: İşçiləri maaşlarına görə azalan sıra ilə (çoxdan aza) düzün.

//var sortedEmployees = employees.OrderByDescending(emp => emp.Salary);
//foreach (var employee in sortedEmployees)
//{
//    Console.WriteLine($"{employee.Name}: {employee.Salary}");
//}


//11.Çoxsəviyyəli çeşidləmə:
//İşçiləri əvvəlcə şöbəyə (department) görə, sonra isə hər şöbə daxilində yaşa görə düzün.

//var sortedEmployees = employees
//    .OrderBy(emp => emp.Department)
//    .ThenBy(emp => emp.Age);
//foreach (var employee in sortedEmployees)
//{
//    Console.WriteLine($"{employee.Name} - {employee.Department} - {employee.Age}");
//}



//12. Ədədlərin əks sırayla çeşidlənməsi: Ədədləri azalan sıra ilə (böyükdən kiçiyə) düzün.

//var sortedNumbers = numbers.OrderByDescending(n => n);
//foreach (var number in sortedNumbers)
//{
//    Console.WriteLine(number);
//}


//13.İşçilərin şöbəyə görə qruplaşdırılması: Bütün işçiləri şöbələrinə(department)
//görə qruplaşdırın və hər qrupdakı işçi sayını göstərin.


//var groupedEmployees = employees.GroupBy(emp => emp.Department)
//    .Select(group => new
//    {
//        Department = group.Key,
//        EmployeeCount = group.Count()
//    });
//foreach (var group in groupedEmployees)
//{
//    Console.WriteLine($"{group.Department}: {group.EmployeeCount}");
//    foreach (var employee in employees.Where(emp => emp.Department == group.Department))
//    {
//        Console.WriteLine($" - {employee.Name}");
//    }
//}


//14. Sifarişlərin müştəriyə görə qruplaşdırılması: Sifarişləri müştəri adına
//görə qruplaşdırın və hər müştəri üçün ümumi məbləği hesablayın.


//var groupedOrders = orders.GroupBy(order => order.CustomerName)
//    .Select(group => new
//    {
//        CustomerName = group.Key,
//        TotalAmount = group.Sum(order => order.Amount)
//    });
//foreach (var group in groupedOrders)
//{
//    Console.WriteLine($"{group.CustomerName}: {group.TotalAmount}");
//    foreach (var order in orders.Where(order => order.CustomerName == group.CustomerName))
//    {
//        Console.WriteLine($" - Order ID: {order.Id}, Amount: {order.Amount}");
//    }
//}

//15. Ədədlərin cüt/tək olmasına görə qruplaşdırılması: Ədədləri cüt və tək kateqoriyalarına ayırın.

//var groupedNumbers = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd")
//    .Select(group => new
//    {
//        Category = group.Key,
//        Numbers = group.ToList()
//    });
//foreach (var group in groupedNumbers)
//{
//    Console.WriteLine($"{group.Category}: {string.Join(", ", group.Numbers)}");
//}

//16.İşçiləri departamentlərinə görə qruplaşdırın və hər departament üçün adini, isci sayini ve ortalama maasini goster.
    //sonra neticeni orta maasa gore azalan sirayla duzun.yalniz en azi 2 isci olan departamentler neticeye daxil olsun.


//var groupedDepartments = employees.GroupBy(emp => emp.Department)
//    .Where(group => group.Count() >= 2) 
//    .Select(group => new
//    {
//        Department = group.Key,
//        EmployeeCount = group.Count(),
//        AverageSalary = group.Average(emp => emp.Salary),
//        EmployeeNames = group.Select(emp => emp.Name).ToList()
//    })
//    .OrderByDescending(group => group.AverageSalary);
//foreach (var group in groupedDepartments)
//{
//    Console.WriteLine($"Department: {group.Department}, Employee Count: {group.EmployeeCount}, Average Salary: {group.AverageSalary}");
//    Console.WriteLine($"Employees: {string.Join(", ", group.EmployeeNames)}");
//}