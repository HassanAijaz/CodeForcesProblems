var input = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
int n = input[0];
int m = input[1];
int a = input[2];

long len = n / a;
long bre = m / a;
if (n % a != 0)
{
    len++;
}

if (m % a != 0)
{
    bre++;
}

Console.WriteLine(len * bre);