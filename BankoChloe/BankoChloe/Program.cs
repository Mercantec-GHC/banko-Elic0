using System;

class Program
{
    static void Main()
    {
        int[] card1Row1 = { 5, 41, 52, 73, 82 };
        int[] card1Row2 = { 33, 42, 55, 65, 76 };
        int[] card1Row3 = { 18, 25, 49, 68, 85 };
        string card1 = "Chloe";

        int[] card2Row1 = { 2, 20, 60, 70, 87 };
        int[] card2Row2 = { 17, 22, 34, 72, 88 };
        int[] card2Row3 = { 39, 49, 58, 62, 73 };
        string card2 = "Chloe";

        int[] card3Row1 = { 5, 22, 33, 40, 80 };
        int[] card3Row2 = { 16, 24, 36, 57, 66 };
        int[] card3Row3 = { 9, 27, 59, 74, 85 };
        string card3 = "Chloe";

        int[][][] cards = new int[][][]
        {
            new int[][] { card1Row1, card1Row2, card1Row3 },
            new int[][] { card2Row1, card2Row2, card2Row3 },
            new int[][] { card3Row1, card3Row2, card3Row3 }
        };

        while (true)
        {
            Console.Clear();
            PrintCard(cards, new string[] { card1, card2, card3 });

            Console.WriteLine("Enter the number rolled (or type 'exit' to quit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            int numberToMark;
            if (int.TryParse(input, out numberToMark))
            {
                bool marked = false;
                string cardNumber = "";
                for (int cardIndex = 0; cardIndex < cards.Length; cardIndex++)
                {
                    for (int row = 0; row < cards[cardIndex].Length; row++)
                    {
                        for (int col = 0; col < cards[cardIndex][row].Length; col++)
                        {
                            if (cards[cardIndex][row][col] == numberToMark)
                            {
                                cards[cardIndex][row][col] = -1;
                                marked = true;
                                cardNumber = (cardIndex + 1).ToString();
                            }
                        }
                    }
                }
                if (marked)
                {
                    Console.WriteLine($"{input} was found on card {cardNumber}.");
                }
                else
                {
                    Console.WriteLine("Number not found on your cards.");
                }
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number or 'exit'.");
                Thread.Sleep(1000);
            }
        }
    }

    static void PrintCard(int[][][] cards, string[] cardLabels)
    {
        int rowOffset = 0; // To add spacing between cards

        for (int cardIndex = 0; cardIndex < cards.Length; cardIndex++)
        {
            bool isCardMarked = true;
            bool[] isRowMarked = new bool[3];
            for (int row = 0; row < cards[cardIndex].Length; row++)
            {
                bool isRowFull = true;
                for (int col = 0; col < cards[cardIndex][row].Length; col++)
                {
                    if (cards[cardIndex][row][col] != -1)
                    {
                        isRowFull = false;
                        isCardMarked = false;
                        isRowMarked[row] = false;
                    }
                }
                if (isRowFull)
                {
                    isRowMarked[row] = true;
                }
            }

            Console.SetCursorPosition(0, rowOffset);
            Console.WriteLine($"Card ID: {cardLabels[cardIndex]}");
            Console.WriteLine($"Card {cardIndex + 1}:");

            for (int row = 0; row < cards[cardIndex].Length; row++)
            {
                for (int col = 0; col < cards[cardIndex][row].Length; col++)
                {
                    if (cards[cardIndex][row][col] == -1)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(cards[cardIndex][row][col] + " ");
                    }
                }
                Console.WriteLine();
            }
            if (isCardMarked)
            {
                Console.WriteLine($"Card {cardIndex + 1} is fully marked!");
            }
            else
            {
                for (int row = 0; row < isRowMarked.Length; row++)
                {
                    if (isRowMarked[row])
                    {
                        Console.Write($"Row {row + 1} on Card {cardIndex + 1} is fully marked! ");
                    }
                }
            }
            rowOffset += 8; // Adjust spacing between cards
        }
    }
}
