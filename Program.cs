// See https://aka.ms/new-console-template for more information
int age;
string fname;
int b_year;
Console.WriteLine("what is your firstname?");
fname=Console.ReadLine();
Console.WriteLine("Hello "+fname);
Console.WriteLine("How old are you?");
//age=int.Parse(Console.ReadLine());
//int.TryParse(Console.ReadLine(), out age);
try
{
    age=int.Parse(Console.ReadLine()); 
    b_year=2022-age;
    Console.WriteLine("So you have born in "+b_year);
}
catch (System.Exception)
{
    
    Console.WriteLine("You should give numbers");
}


