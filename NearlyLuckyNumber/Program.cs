var input = Console.ReadLine();
var count = input.Count(c => c == '4' || c == '7');
if (count == 4 || count == 7)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
} 
