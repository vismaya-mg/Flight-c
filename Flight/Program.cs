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
//double fare;
//Console.WriteLine("Enter the flight fare");
//fare = double.Parse(Console.ReadLine());
//int time;
//Console.WriteLine("Enter the time");
//time= int.Parse(Console.ReadLine());
//if(time>=600 && time<=900)
//{
//    fare = fare + (fare * .1);
//    Console.WriteLine("Your fare is" +fare);
//}
//else if (time >= 900 && time <= 1700)
//{
//    fare = fare + (fare * .2);
//    Console.WriteLine("Your fare is" + fare);
//}
//else if (time >= 1700 && time <= 2300)
//{
//    fare = fare + (fare * .07);
//    Console.WriteLine("Your fare is" + fare);
//}
//else if (time <= 2300 && time <= 600)
//{
//    fare = fare + (fare * .05);
//    Console.WriteLine("Your fare is" + fare);
//}
//else
//{

//        Console.WriteLine("Invalid time");

//}

//********QUESTION 3********


//var fare= new float[5];
//float temp = 0;
//Console.WriteLine("Enter the fare");
//for (int i = 0; i < fare.Length; i++)
//{
//    fare[i] = float.Parse(Console.ReadLine());
//}

//Console.WriteLine("Ascending order");
//for (int i = 0; i < fare.Length; i++)
//{
//    for (int j = i + 1; j < fare.Length; j++)
//    {
//        if (fare[i] < fare[j])
//        {
//            temp = fare[i];
//            fare[i] = fare[j];
//            fare[j] = temp;
//        }
//    }
//}
//for (int j = 0; j < fare.Length; j++)
//{
//    Console.WriteLine(fare[j]);
//}
//Console.WriteLine("Descending order");
//for (int i = 0; i < fare.Length; i++)
//{
//    for (int j = i + 1; j < fare.Length; j++)
//    {
//        if (fare[i] > fare[j])
//        {
//            temp = fare[i];
//            fare[i] = fare[j];
//            fare[j] = temp;
//        }
//    }
//}
//for (int j = 0; j < fare.Length; j++)
//{
//    Console.WriteLine(fare[j]);
//}

//float Sfare;
//Console.WriteLine("Enter the name to be searched");
//Sfare = float.Parse(Console.ReadLine());
//for (int i = 0; i < fare.Length; i++)
//{
//    if (Sfare == fare[i])
//    {
//        Console.WriteLine($"{Sfare} is present in this array");
//    }
//}

//float max = fare[0];
//float min = 0;
//for (int i = 1; i < fare.Length; i++)
//{
//    if(fare[i] > max)
//    {
//        max = fare[i];
//    }
//    else
//    {
//        min=fare[i];
//    }
//}
//Console.WriteLine("The maximum fare is " + max);
//Console.WriteLine("The minimum fare is " + min);

//Console.WriteLine("Duplicate fares");
//for (int i = 0; i < fare.Length-1; i++)
//{
//    for (int j = i+1; j < fare.Length; j++)
//    {
//        if (fare[i] == fare[j])
//        {
//            Console.WriteLine(fare[i]);
//            break;
//        }
//    }
//}
//********QUESTION 5 ********

var fare = new float[6];
Console.WriteLine("Enter the fare");
for (int i = 0; i < fare.Length; i++)
{
    fare[i] = float.Parse(Console.ReadLine());
}
var odd = new float[6];
var even = new float[6];
for (int i = 0; i < fare.Length; i++)
{
    if (fare[i] % 2 == 0)
    {
        even[i] = fare[i];

    }
    else
    {
        odd[i] = fare[i];
    }
}
Console.WriteLine("Odd values");
for (int i = 0; i < odd.Length; i++)
{
    if (odd[i] == 0)
    {
        continue;
    }
    else
    {
        Console.WriteLine(odd[i]);
    }
}
Console.WriteLine("even values");
for (int i = 0; i < even.Length; i++)
{
    if (even[i] == 0)
    {
        continue;
    }
    else
    {
        Console.WriteLine(even[i]);
    }
}

DateOnly dob;
Console.WriteLine("Enter the date of birth");
dob=DateOnly.Parse(Console.ReadLine());
var today = DateTime.Today;
var age=today.Year-dob.Year;
Console.WriteLine("Age:" +age);
var days = age * 365;
Console.WriteLine("Days:" + days);
var hr = days * 24;
Console.WriteLine("Hours:" + hr);
var week = days / 7;
Console.WriteLine("Weeks:" + week);
var month=days / 20;
Console.WriteLine("Months:" + month);

var year = dob.Year;
if ((year % 4 == 0 && year % 100 == 0) || (year % 400 == 0))
{
    Console.WriteLine($"The year {year} is leap year");
}
else
{
    Console.WriteLine($"The year {year} is not a leap year");

}
