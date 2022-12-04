using _2December_Lab;
using System.Diagnostics.Contracts;

bool check = true;
while (check)
{
    Console.WriteLine("1:Create new departament");
    Console.WriteLine("2:Show Departments");
    Console.WriteLine("3:Update Departments");
    int num = int.Parse(Console.ReadLine());

    switch (num)
    {
        case 1:
            CreateDepartment();
            break;
        case 2:
            ShowDepartment();
            break;
        case 3:
            UpdateDepartment();
            break;


    }


}





static void CreateDepartment()
{
    try
    {
        Console.WriteLine("Department adi daxil edin");
        string name = Console.ReadLine();
        if (name == string.Empty)
        {
            Console.WriteLine("Department adi bos ola bilmez");
            return;
        }
        Console.WriteLine("Department capacity daxil edin");
        int capacity = int.Parse(Console.ReadLine());
        Department department = new Department(name, capacity);
        Department.departments.Add(department);
        foreach (var item in Department.departments)
        {
            Console.WriteLine("*"+item.Name);
        }




    }
    catch (Exception)
    {
        Console.WriteLine("Capacity bosdur");
    }
    
}

static void ShowDepartment()
{
    foreach (var item in Department.departments)
    {
        Console.WriteLine(item.Name + " - " + item.Capacity);
    }
}

static void UpdateDepartment()
{
    ShowDepartment();
    bool isExists = false;
    Console.WriteLine("Deyismek istediyiniz adi secin");
    string oldName = Console.ReadLine();
    Console.WriteLine("Yeni adi daxil edin");
    string newName = Console.ReadLine();

    foreach (var item in Department.departments)
    {
        if (item.Name == oldName)
        {
            isExists = true;
            item.Name = newName;
        }
    }
    if (!isExists)
    {
        Console.WriteLine("Bele department yoxdur");
    }


}
