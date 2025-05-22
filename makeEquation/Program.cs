
for (int i = 0 ; i <= 40 ; i++)
{
    string eq = generateEq(i);
    Console.WriteLine($"{eq} = {i} \n");
}

string generateEq(double number)
{
    while (true)
    {
        Random r1 = new();
        int n1 = r1.Next(1, 100);
        int n2 = r1.Next(1, 100);
        int n3 = r1.Next(1, 100);
        int n4 = r1.Next(1, 100);
        if (( n1 * n2 ) - ( n4 + n3 ) == number)
        {
            return $"({n1} x {n2}) - ({n4} + {n3})";
        }
    }
}