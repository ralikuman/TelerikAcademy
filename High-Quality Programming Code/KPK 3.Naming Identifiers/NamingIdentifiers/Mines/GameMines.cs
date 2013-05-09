namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GameMines
    {
        public const int MAX_SCORE = 35;
        public const int MAX_BOMB_COUNT = 15;
        public const int ROWS_OF_PLAYFIELD = 5;
        public const int COLUMNS_OF_PLAYFIELD = 10;
        public const int MAX_TOP_CHAMPIONS = 5;

        public static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] playfield = CreatePlayfield();
            char[,] bombsField = BetBombs();
            int playerCurrentScore = 0;
            bool isHitBomb = false;
            List<PlayerScore> topScoreChampions = new List<PlayerScore>(6);
            int row = 0;
            int column = 0;
            bool isNewGame = true;
            bool isWinner = false;

            // Implement game functionality
            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let`s play Mineweeper!" + "\n" +
                                       "Try your luck and find fields without bombs!" + "\n" +
                                       "Menu of Mineweeper" + "\n" +
                                       "'top' - show score" + "\n" +
                                       "'restart' - start new game" + "\n" +
                                       "'exit' - close the game" + "\n");

                    DrowPlayfield(playfield);
                    isNewGame = false;
                }

                Console.Write("Input row and column: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= playfield.GetLength(0) && column <= playfield.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Ranking(topScoreChampions);
                        break;
                    case "restart":
                        playfield = CreatePlayfield();
                        bombsField = BetBombs();
                        DrowPlayfield(playfield);
                        isHitBomb = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    case "turn":
                        if (bombsField[row, column] != '*')
                        {
                            if (bombsField[row, column] == '-')
                            {
                                EnterPlayerMoving(playfield, bombsField, row, column);
                                playerCurrentScore++;
                            }

                            if (MAX_SCORE == playerCurrentScore)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                DrowPlayfield(playfield);
                            }
                        }
                        else
                        {
                            isHitBomb = true;
                        }

                        break;
                    default:
                        {
                            Console.WriteLine("\nError! You input wrong command! \n");
                            break;
                        }
                }

                if (isHitBomb)
                {
                    DrowPlayfield(bombsField);
                    Console.Write("\nOpps! You hit bomb and you died with {0} points. " + "Input your player name: ", playerCurrentScore);
                    string playerName = Console.ReadLine();
                    PlayerScore result = new PlayerScore(playerName, playerCurrentScore);
                    if (topScoreChampions.Count < MAX_TOP_CHAMPIONS)
                    {
                        topScoreChampions.Add(result);
                    }
                    else
                    {
                        for (int i = 0; i < topScoreChampions.Count; i++)
                        {
                            if (topScoreChampions[i].CollectedPoints < result.CollectedPoints)
                            {
                                topScoreChampions.Insert(i, result);
                                topScoreChampions.RemoveAt(topScoreChampions.Count - 1);
                                break;
                            }
                        }
                    }

                    topScoreChampions.Sort((PlayerScore r1, PlayerScore r2) => r2.Name.CompareTo(r1.Name));
                    topScoreChampions.Sort((PlayerScore r1, PlayerScore r2) => r2.CollectedPoints.CompareTo(r1.CollectedPoints));
                    Ranking(topScoreChampions);

                    playfield = CreatePlayfield();
                    bombsField = BetBombs();
                    playerCurrentScore = 0;
                    isHitBomb = false;
                    isNewGame = true;
                }

                if (isWinner)
                {
                    Console.WriteLine("\nCongrats! You find all 35 boxes without a drop of blood!");
                    DrowPlayfield(bombsField);
                    Console.WriteLine("Please input your player name: ");
                    string playerName = Console.ReadLine();
                    PlayerScore result = new PlayerScore(playerName, playerCurrentScore);
                    topScoreChampions.Add(result);
                    Ranking(topScoreChampions);
                    playfield = CreatePlayfield();
                    bombsField = BetBombs();
                    playerCurrentScore = 0;
                    isWinner = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Thank you for playing Mineweeper!");
            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void Ranking(List<PlayerScore> score)
        {
            Console.WriteLine("\nScore:");
            if (score.Count > 0)
            {
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, score[i].Name, score[i].CollectedPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty score!\n");
            }
        }

        private static void EnterPlayerMoving(char[,] playfield, char[,] bombsfield, int row, int column)
        {
            char surroundingBombCount = GetSurroundingBombCount(bombsfield, row, column);
            bombsfield[row, column] = surroundingBombCount;
            playfield[row, column] = surroundingBombCount;
        }

        private static void DrowPlayfield(char[,] playfield)
        {
            int rowsCount = playfield.GetLength(0);
            int columsCount = playfield.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int currentRow = 0; currentRow < rowsCount; currentRow++)
            {
                Console.Write("{0} | ", currentRow);

                for (int currentColumn = 0; currentColumn < columsCount; currentColumn++)
                {
                    Console.Write(string.Format("{0} ", playfield[currentRow, currentColumn]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayfield()
        {
            char[,] playfield = new char[ROWS_OF_PLAYFIELD, COLUMNS_OF_PLAYFIELD];

            for (int i = 0; i < ROWS_OF_PLAYFIELD; i++)
            {
                for (int j = 0; j < COLUMNS_OF_PLAYFIELD; j++)
                {
                    playfield[i, j] = '?';
                }
            }

            return playfield;
        }

        private static char[,] BetBombs()
        {
            char[,] playfield = new char[ROWS_OF_PLAYFIELD, COLUMNS_OF_PLAYFIELD];

            for (int currentRow = 0; currentRow < ROWS_OF_PLAYFIELD; currentRow++)
            {
                for (int currentColumn = 0; currentColumn < COLUMNS_OF_PLAYFIELD; currentColumn++)
                {
                    playfield[currentRow, currentColumn] = '-';
                }
            }

            List<int> locationOfBombs = new List<int>();
            while (locationOfBombs.Count < MAX_BOMB_COUNT)
            {
                Random random = new Random();
                int randomLocation = random.Next(50);
                if (!locationOfBombs.Contains(randomLocation))
                {
                    locationOfBombs.Add(randomLocation);
                }
            }

            foreach (int locateBomb in locationOfBombs)
            {
                int column = locateBomb / COLUMNS_OF_PLAYFIELD;
                int row = locateBomb % COLUMNS_OF_PLAYFIELD;
                if (row == 0 && locateBomb != 0)
                {
                    column--;
                    row = COLUMNS_OF_PLAYFIELD;
                }
                else
                {
                    row++;
                }

                playfield[column, row - 1] = '*';
            }

            return playfield;
        }

        private static char GetSurroundingBombCount(char[,] bombsfiled, int currentRow, int currentColumn)
        {
            int bombCount = 0;
            int rowsCount = bombsfiled.GetLength(0);
            int columnsCount = bombsfiled.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (bombsfiled[currentRow - 1, currentColumn] == '*')
                {
                    bombCount++;
                }
            }

            if (currentRow + 1 < rowsCount)
            {
                if (bombsfiled[currentRow + 1, currentColumn] == '*')
                {
                    bombCount++;
                }
            }

            if (currentColumn - 1 >= 0)
            {
                if (bombsfiled[currentRow, currentColumn - 1] == '*')
                {
                    bombCount++;
                }
            }

            if (currentColumn + 1 < columnsCount)
            {
                if (bombsfiled[currentRow, currentColumn + 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn - 1 >= 0))
            {
                if (bombsfiled[currentRow - 1, currentColumn - 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn + 1 < columnsCount))
            {
                if (bombsfiled[currentRow - 1, currentColumn + 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((currentRow + 1 < rowsCount) && (currentColumn - 1 >= 0))
            {
                if (bombsfiled[currentRow + 1, currentColumn - 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((currentRow + 1 < rowsCount) && (currentColumn + 1 < columnsCount))
            {
                if (bombsfiled[currentRow + 1, currentColumn + 1] == '*')
                {
                    bombCount++;
                }
            }

            return char.Parse(bombCount.ToString());
        }
    }
}
