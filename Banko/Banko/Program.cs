Random rnd = new Random();
int totalNumbers = 0;

for (int horizontalRow = 1; horizontalRow <= 3; horizontalRow++)
{
    Console.WriteLine($"Horizontal Row {horizontalRow}");

    for (int row = 1; row <= 3; row++)
    {
        int heightOfCard = rnd.Next(1, 4); // Generate a random number between 1 and 3
        totalNumbers += heightOfCard;

        int minValue = row * 10 - 9; // Calculate the minimum value based on the row
        int maxValue = row * 10;      // Calculate the maximum value based on the row

        for (int i = 0; i < heightOfCard; i++)
        {
            int randomNumber = rnd.Next(minValue, maxValue);
            Console.WriteLine(randomNumber);
        }
    }

    // Ensure each horizontal row has exactly 5 numbers
    while (totalNumbers < 5)
    {
        int rowToAdjust = rnd.Next(1, 10); // Randomly select a vertical row to add an extra number
        int minValue = rowToAdjust * 10 - 9;
        int maxValue = rowToAdjust * 10;
        int randomNumber = rnd.Next(minValue, maxValue);
        Console.WriteLine(randomNumber);
        totalNumbers++;
    }
    totalNumbers = 0;
}
