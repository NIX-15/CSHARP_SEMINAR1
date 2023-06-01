Console.Write("Input Your Number: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < -999 || (num > -100 && num < 100) || num > 999)
{
    Console.Write("Input Your Number Again: ");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(num);