int num = Convert.ToInt32(Console.ReadLine());
Console.Clear();
for(int a = 0; a < 10; a++)
{
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num == num2)
    {
        Console.WriteLine("Borsy");
        break;
    }
    else if (num <= num2)
    {
        Console.WriteLine("Bozorgeh");
    }
    else if (num >= num2)
    {
        Console.WriteLine("kochik");
    }
    
}
Console.WriteLine("OK");
