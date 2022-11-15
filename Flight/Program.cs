//**********QUESTION NO:1***********
//var name = new String[5];
//string Name = string.Empty;
//Console.WriteLine("Enter the name");
//for (int i = 0; i < name.Length; i++)
//{
//    name[i] = Console.ReadLine();
//}
//Console.WriteLine("Names");
//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}

//Console.WriteLine("Ascending order");
//for (int i = 0; i < 10; i++)
//{
//    for (int j = i + 1; j < 5; j++)
//    {
//        if (name[i][0] > name[j][0])
//        {
//            Name = name[i];
//            name[i] = name[j];
//            name[j] = Name;

//        }
//    }

//}
//for (int j = 0; j < 10; j++)
//{
//    Console.WriteLine(name[j]);
//}
//Console.WriteLine("Descending order");
//for (int i = 0; i < 5; i++)
//{
//    for (int j = i + 1; j < 5; j++)
//    {
//        if (name[i][0] < name[j][0])
//        {
//            Name = name[i];
//            name[i] = name[j];
//            name[j] = Name;

//        }
//    }

//}
//for (int j = 0; j < 5; j++)
//{
//    Console.WriteLine(name[j]);
//}
//string Sname;
//Console.WriteLine("Enter the name to be searched");
//Sname = Console.ReadLine();
//for (int i = 0; i < name.Length; i++)
//{
//    if (Sname == name[i])
//    {
//        Console.WriteLine($"{Sname} is present in this array");
//    }

//}
//Console.WriteLine("The Length of each elements");
//foreach (var item in name)
//{
//    Console.WriteLine($"The length of{item} is " + item.Length);
//}
//Console.WriteLine("The First and Last name\n");
//foreach (var item in name)
//{
//    for (int i = 0; i < item.Length; i++)
//    {
//        if (item[i] == ' ')
//        {
//            Console.WriteLine($"The first name :{item} \n");
//            for (int j = 0; j < i; j++)
//            {
//                Console.Write(item[j]);
//            }
//            Console.WriteLine($"   The second name:{item}\n");
//            for (int j = i + 1; j < item.Length; j++)
//            {
//                Console.Write(item[j]);
//            }
//        }

//    }
//    Console.WriteLine("");
//}
//Console.WriteLine("Duplicate entries");
//for (int i = 0; i < name.Length; i++)
//{
//    for (int j = i + 1; j < name.Length; j++)
//    {
//        if (name[i] == name[j])
//        {
//            Console.WriteLine(name[i]);
//        }
//    }
//}



//***************QUESTION 2************
double fare;
Console.WriteLine("Enter the flight fare");
fare = double.Parse(Console.ReadLine());
int time;
Console.WriteLine("Enter the time");
time= int.Parse(Console.ReadLine());
if(time>=600 && time<=900)
{
    fare = fare + (fare * .1);
    Console.WriteLine("Your fare is" +fare);
}
else if (time >= 900 && time <= 1700)
{
    fare = fare + (fare * .2);
    Console.WriteLine("Your fare is" + fare);
}
else if (time >= 1700 && time <= 2300)
{
    fare = fare + (fare * .07);
    Console.WriteLine("Your fare is" + fare);
}
else if (time <= 2300 && time <= 600)
{
    fare = fare + (fare * .05);
    Console.WriteLine("Your fare is" + fare);
}
else
{

        Console.WriteLine("Invalid time");
    
}

