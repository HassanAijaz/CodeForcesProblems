int noOfInputs = int.Parse(Console.ReadLine());
int[] input = Console.ReadLine().Split(" ").Select(c => int.Parse(c)).ToArray();

int pointer1 = 0;
int pointer2 = input.Length - 1;
int noOfTurn = input.Length;
int serejaSum = 0;
int dimaSum = 0;
bool isPlayerOneTurn = true;
bool isPlayerTwoTurn = false;
while (noOfTurn != 0)
{
    int value1 = input[pointer1];
    int value2 = input[pointer2];
    noOfTurn--;
    if (isPlayerOneTurn)
    {
        if (value1 >= value2)
        {
            serejaSum += value1;
            pointer1++;
            isPlayerOneTurn = false;
            isPlayerTwoTurn = true;
            continue;
        }
        if (value2 >= value1)
        {
            serejaSum += value2;
            pointer2--;
            isPlayerOneTurn = false;
            isPlayerTwoTurn = true;
            continue;
        }
    }
    if (isPlayerTwoTurn)
    {
        if (value1 >= value2)
        {
            dimaSum += value1;
            pointer1++;
            isPlayerOneTurn = true;
            isPlayerTwoTurn = false;
            continue;
        }
        if (value2 >= value1)
        {
            dimaSum += value2;
            pointer2--;
            isPlayerOneTurn = true;
            isPlayerTwoTurn = false;
            continue;
        }
    }
}
Console.WriteLine($"{serejaSum} {dimaSum}");