using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruc_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[10, 30];
            int[] coor = { 0, 0 };
            string uInput = "";
            int distance = 0;
            int temp = 0;
            int coorValue = 5;

            while (true)
            {
                // reset array content
                for (int x = 0; x < nums.GetLength(0); x++)
                {
                    for (int y = 0; y < nums.GetLength(1); y++)
                    {
                        nums[x, y] = 0;
                    }
                }

                //modifying content of coordinates
                for (int x = 0; x < nums.GetLength(0); x++)
                {
                    for (int y = 0; y < nums.GetLength(1); y++)
                    {
                        distance = 0;
                        temp = x - coor[0];
                        if (temp < 0)
                            temp *= -1;
                        distance += temp;
                        temp = y - coor[1];
                        if (temp < 0)
                            temp *= -1;
                        distance += temp;

                        distance = coorValue - distance;

                        if (distance < 0)
                            distance = 0;

                        nums[x, y] = distance;
                    }
                }
                
                // place coordinate
                nums[coor[0], coor[1]] = coorValue;
                
                // display
                Console.Clear();
                for (int x = 0; x < nums.GetLength(0); x++)
                {
                    for (int y = 0; y < nums.GetLength(1); y++)
                    {
                        switch (nums[x, y])
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                break;
                        }
                        Console.Write(nums[x, y]);
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }

                // user input
                Console.Write("\nW,A,S or D: ");
                uInput = Console.ReadLine().ToUpper();
                switch(uInput[0])
                {
                    case 'W':
                        coor[0]--;
                        if (coor[0] < 0)
                            coor[0] = nums.GetLength(0) - 1;
                        break;
                    case 'A':
                        coor[1]--;
                        if (coor[1] < 0)
                            coor[1] = nums.GetLength(1) - 1;
                        break;
                    case 'S':
                        coor[0]++;
                        if (coor[0] >= nums.GetLength(0))
                            coor[0] = 0;
                        break;
                    case 'D':
                        coor[1]++;
                        if (coor[1] >= nums.GetLength(1))
                            coor[1] = 0;
                        break;
                }
            }
        }
    }
}
