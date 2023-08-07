using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        // FIRST INPUT, AMOUNT OF TITANS AND SIZE OF THE WALLS

        string[] nx = new string[2];
        nx = Console.ReadLine().Split(' ');

        int amountOfTitans = int.Parse(nx[0]);
        int sizeOfWalls = int.Parse(nx[1]);

        // SECOND INPUT, TITANS SIZE
        string secondInput = Console.ReadLine();
        int secondInputLengh = secondInput.Length;
        char[] titansSize = new char[secondInputLengh];
        titansSize = secondInput.ToCharArray();

        // THIRD INPUT, SIZE OF CHARS

        string[] sizeOfCharacters = new string[3];
        sizeOfCharacters = Console.ReadLine().Split(' ');

        int P = int.Parse(sizeOfCharacters[0]);
        int M = int.Parse(sizeOfCharacters[1]);
        int G = int.Parse(sizeOfCharacters[2]);

        // RESOLUTION

        int[] titansSizeTranslate = new int[titansSize.Length];
        for (int i = 0; i < titansSize.Length; i++)
        {
            if (titansSize[i] == 'P')
            {
                titansSizeTranslate[i] = P;
            }
            else if (titansSize[i] == 'M')
            {
                titansSizeTranslate[i] = M;
            }
            else if (titansSize[i] == 'G')
            {
                titansSizeTranslate[i] = G;
            }
        }

        int[] currentWalls = new int[amountOfTitans];
        currentWalls[0] = sizeOfWalls;
        int wallCount = 1;

        for (int i = 0; i < amountOfTitans; i++)
        {
            int count = wallCount;

            for (int j = 0; j < count; j++)
            {
                if (currentWalls[j] >= titansSizeTranslate[i])
                {
                    currentWalls[j] -= titansSizeTranslate[i];
                    break;
                }
                else if (j == count - 1)
                {
                    currentWalls[wallCount] = sizeOfWalls;

                    if (currentWalls[wallCount] >= titansSizeTranslate[i])
                    {
                        currentWalls[wallCount] -= titansSizeTranslate[i];
                        wallCount++;
                    }
                }
            }
        }

        Console.WriteLine(wallCount);
    }
}
