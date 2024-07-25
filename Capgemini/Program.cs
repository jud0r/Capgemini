// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using Capgemini.Employee_Type_Salary;

var listEmployee = new List<IEmployee>();

var engineer = new Engineer { Salary = 1000 };
listEmployee.Add(engineer);

var salesman = new Salesman { Salary = 2500, Commission = 250 };
listEmployee.Add(salesman);

var maneger = new Maneger { Salary = 5000, Commission = 1000, Bonus = 1250 };
listEmployee.Add(maneger);

Console.WriteLine("INTERFACE");
foreach (var employee in listEmployee)
{
    Console.WriteLine($"{employee.Type}: {employee.GetPayAmount():C2}");
}

var listEmployeeInheritance = new List<EmployeeInheritance>();

var engineerInheritance = new EngineerInheritance(1000);
listEmployeeInheritance.Add(engineerInheritance);

var salesmanInheritance = new SalesmanInheritance(2500, 250);
listEmployeeInheritance.Add(salesmanInheritance);

var manegerInheritance = new ManegerInheritance(5000, 1000, 1250);
listEmployeeInheritance.Add(manegerInheritance);


Console.WriteLine();
Console.WriteLine("HERANÇA");
foreach (var employee in listEmployeeInheritance)
{
    Console.WriteLine($"{employee.Type}: {employee.GetPayAmount():C2}");
}

var type = maneger.GetType();
Console.WriteLine(type);
Console.ReadLine();



static string OrderText(string str)
{
    var indexes = new List<int>();
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ') indexes.Add(i);
    }
    var orderedStr = new string(str.Where(x => x != ' ').OrderBy(x => x).ToArray());

    for (int i = 0; i < indexes.Count; i++)
    {
        orderedStr = orderedStr.Insert(indexes[i], " ");
    }

    return orderedStr;
}


static string OrderText2(string str)
{
    var orderedStr = new string(str.Where(x => x != ' ').OrderBy(x => x).ToArray());
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            orderedStr = orderedStr.Insert(i, " ");
        }
    }
    return orderedStr;
}


static bool AreListsValid(Dictionary<string, string[]> lists)
{
    var generalList = new List<string>();
    foreach (var list in lists)
    {
        foreach (var item in list.Value)
        {
            if (generalList.Contains(item))
            {
                return false;
            }
        }
        generalList.AddRange(list.Value);
    }
    return true;
}

var success = new Dictionary<string, string[]>
{
    {"list1", new[] {"A", "A", "B"} },
    {"list2", new[] {"C", "C", "C"} },
    {"list3", new[] {"D", "D", "E"} },
    {"list4", new[] {"F"} }
};

var fail = new Dictionary<string, string[]>
{
    {"list1", new[] {"A", "A", "B"} },
    {"list2", new[] {"A", "C", "C"} }
};

//Console.WriteLine($"[Success case] Is correct: {AreListsValid(success) == true}");
//Console.WriteLine($"[Fail case] Is correct: {AreListsValid(fail) == false}");
//Console.ReadLine();