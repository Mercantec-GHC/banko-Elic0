using System;

class Program
{
    static void Main()
    {
        int[] card1Row1 = { 12, 22, 44, 64, 86 };
        int[] card1Row2 = { 23, 35, 53, 67, 87 };
        int[] card1Row3 = { 5, 39, 47, 55, 78 };

        int[] card2Row1 = { 14, 40, 50, 76, 86 };
        int[] card2Row2 = { 15, 33, 47, 68, 87 };
        int[] card2Row3 = { 7, 19, 29, 49, 58 };

        int[] card3Row1 = { 21, 31, 41, 60, 75 };
        int[] card3Row2 = { 14, 36, 54, 76, 87 };
        int[] card3Row3 = { 8, 27, 58, 67, 77 };

        int[][][] cards = new int[][][]
        {
            new int[][] { card1Row1, card1Row2, card1Row3 },
            new int[][] { card2Row1, card2Row2, card2Row3 },
            new int[][] { card3Row1, card3Row2, card3Row3 }
        };

        while (true)
        {
            Console.Clear();
            PrintCard(cards);

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
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number or 'exit'.");
                Thread.Sleep(10000);
            }
        }
    }
    static void PrintCard(int[][][] cards)
    {
        Console.WriteLine("Card ID: Charlie");
        for (int cardIndex = 0; cardIndex < cards.Length; cardIndex++)
        {
            Console.SetCursorPosition(0, cardIndex * 6);
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
        }
    }
}
