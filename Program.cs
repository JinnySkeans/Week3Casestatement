// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int var1, var2, var3, var4, var5, var6, average;
//Integer variables, 6 

Console.WriteLine("Input Grade 1:");
var1 = Convert.ToInt32(Console.ReadLine());
//writeline("ANYTHING HERE WILL DISPLAY")
//convert.toint32 convert input string in to an int
Console.WriteLine("Input Grade 2:");
var2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Grade 3:");
var3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Grade 4:");
var4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Grade 5:");
var5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Grade 6:");
var6 = Convert.ToInt32(Console.ReadLine());

average = (var1 + var2 + var3 + var4 + var5 + var6)/6;

switch(average)
    {
        case >=70:
                Console.WriteLine("1st");
                break;
        case >=60:
                Console.WriteLine("2:1");
                break;
        case >=50:
                Console.WriteLine("2:2");
                break;
        case >=40:
                Console.WriteLine("3rd");
                break;
        case >=30:
                Console.WriteLine("pass");
                break;
        case <30:
                Console.WriteLine("fail");
                break;
        default:
                Console.WriteLine("Enter a number");
                break;
    }


Console.ReadKey();
