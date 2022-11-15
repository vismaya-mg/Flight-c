
var name = new String[5];
string Name = string.Empty;
Console.WriteLine("Enter the name");
for (int i = 0; i < name.Length; i++)
{
    name[i] = Console.ReadLine();
}
Console.WriteLine("Names");
for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}

Console.WriteLine("Ascending order");
for (int i = 0; i < 10; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (name[i][0] > name[j][0])
        {
            Name = name[i];
            name[i] = name[j];
            name[j] = Name;

        }
    }

}
for (int j = 0; j < 10; j++)
{
    Console.WriteLine(name[j]);
}
Console.WriteLine("Descending order");
for (int i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (name[i][0] < name[j][0])
        {
            Name = name[i];
            name[i] = name[j];
            name[j] = Name;

        }
    }

}
for (int j = 0; j < 5; j++)
{
    Console.WriteLine(name[j]);
}
string Sname;
Console.WriteLine("Enter the name to be searched");
Sname = Console.ReadLine();
for (int i = 0; i < name.Length; i++)
{
    if (Sname == name[i])
    {
        Console.WriteLine($"{Sname} is present in this array");
    }

}
Console.WriteLine("The Length of each elements");
foreach (var item in name)
{
    Console.WriteLine($"The length of{item} is " + item.Length);
}
Console.WriteLine("The First and Last name\n");
foreach (var item in name)
{
    for (int i = 0; i < item.Length; i++)
    {
        if (item[i] == ' ')
        {
            Console.WriteLine($"The first name :{item} \n");
            for (int j = 0; j < i; j++)
            {
                Console.Write(item[j]);
            }
            Console.WriteLine($"   The second name:{item}\n");
            for (int j = i + 1; j < item.Length; j++)
            {
                Console.Write(item[j]);
            }
        }

    }
    Console.WriteLine("");
}
Console.WriteLine("Duplicate entries");
for (int i = 0; i < name.Length; i++)
{
    for (int j = i + 1; j < name.Length; j++)
    {
        if (name[i] == name[j])
        {
            Console.WriteLine(name[i]);
        }
    }
}