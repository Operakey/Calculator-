// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double a, b, c;
char s;

a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите знак действия : ");
s = Convert.ToChar(Console.ReadLine());
Console.Write("Введите Второе число: ");
b = Convert.ToInt32(Console.ReadLine());
if (s == '+')
{
    c = b + a;
    Console.WriteLine(c);
   
    Console.ReadKey();
}
else if (s == '-')
{
    c = b - a;
    Console.WriteLine( c);
  
    Console.ReadKey();
}
else if (s == '*')
{
    c = b * a;
    Console.WriteLine( c);

    Console.ReadKey();
}
else if (s == '/')
{
    if (a == 0)
    {
        Console.WriteLine("Ошибка");
      
        Console.ReadKey();
    }
    else
    {
        c = a / b;
        Console.WriteLine(c);
       
        Console.ReadKey();
    }


}
else
{
    Console.WriteLine("Ошибка. Вы ввели неверный знак.");
    Console.WriteLine("Для выхода нажмите любую клавишу...");
    Console.ReadKey();


}