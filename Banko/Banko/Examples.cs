/*Random rnd = new Random();
HashSet<int> usedNumbers = new HashSet<int>();

Console.WriteLine("Bingo Plade");
for (int horizontalRow = 1; horizontalRow <= 3; horizontalRow++)
{
    Console.WriteLine("");

    HashSet<int> verticalRowsUsed = new HashSet<int>();

    for (int i = 0; i < 5; i++) // Generate 5 numbers in each horizontal row
    {
        int rowToUse;
        do
        {
            rowToUse = rnd.Next(1, 10); // Randomly select a vertical row
        } while (verticalRowsUsed.Contains(rowToUse));

        verticalRowsUsed.Add(rowToUse);

        int minValue = (rowToUse - 1) * 10 + 1; // Calculate the minimum value based on the selected vertical row
        int maxValue = rowToUse * 10;          // Calculate the maximum value based on the selected vertical row

        int randomNumber;
        do
        {
            randomNumber = rnd.Next(minValue, maxValue + 1);
        } while (usedNumbers.Contains(randomNumber));

        usedNumbers.Add(randomNumber);
        Console.Write(randomNumber + "\t");
    }
}
*/