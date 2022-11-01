_ = int.TryParse(Console.ReadLine(), out int noOfTestCases) ? noOfTestCases : 0;
List<int[]> inputs = new();
if (inputs == null) throw new ArgumentNullException(nameof(inputs));
for (var i = 0; i < noOfTestCases; i++)
{
    _ = int.TryParse(Console.ReadLine(), out int lengthOfSequence) ? lengthOfSequence : 0;
    var inp = Console.ReadLine()?.Split(' ').Select(c => int.Parse(c)).ToArray();
    if (inp != null) inputs.Add(inp);
}
foreach (var input in inputs)
{
    Console.WriteLine(Program.FavSequence(input));
}




public partial class Program
{
    public static  string FavSequence(int[] input)
    {
        int count = 0;
        int p1 = 0;
        int p2 = input.Length -1 ;
        bool right = false;
        List<int> arr = new List<int>();
        while (true)
        {
            if (right)
            {
                arr.Add(input[p2]);
                p2--;
                right = false;
            }
            else
            {
                arr.Add(input[p1]);
                p1++;
                right = true;
            }
            count++;
            if (count == input.Length) break;
        }
        return string.Join(' ', arr.ToArray());
    }
}