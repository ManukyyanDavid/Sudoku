using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku;

public class Sudoku
{
    public int[,] Array { get; set; }

    public Sudoku()
    {
        int[,] arr ={  {0, 0, 2, 4, 0, 0, 0, 0, 0 },
                       {5, 0, 0, 1, 0, 0, 7, 0, 0 },
                       {0, 6, 0, 0, 8, 3, 0, 0, 0 },
                       {9, 0, 0, 0, 0, 8, 0, 4, 2 },
                       {0, 0, 7, 0, 0, 0, 5, 0, 8 },
                       {6, 0, 3, 2, 0, 0, 0, 0, 0 },
                       {0, 4, 9, 7, 0, 2, 0, 5, 0 },
                       {8, 0, 0, 0, 5, 0, 9, 0, 6 },
                       {0, 0, 0, 8, 0, 0, 0, 7, 3 }
        };
        this.Array = arr;

    }
    public int [,] Go_Through_Cells(int[,] arr)
    {
        int z = 0;     // how many possible numbers can be in the cell.
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Cell cell = new Cell(i, j, arr);
                for (int k = 1; k <= 9; k++)
                {
                    if(cell.Check_Vertical(arr,k,j) == true   &&
                       cell.Check_Horizontal(arr,k,i) == true &&
                       cell.Check_Section(arr,i,j,k) == true  &&
                       arr[i,j] == 0)
                    {
                        z++;                   
                    }
                }
                if (z==1)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        if (cell.Check_Vertical(arr, k, j) == true &&
                           cell.Check_Horizontal(arr, k, i) == true &&
                           cell.Check_Section(arr, i, j, k) == true &&
                           arr[i, j] == 0)
                        {
                            arr[i, j] = k;
                            this.Array = arr;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Clear();
                            this.Print(this.Array);
                            Thread.Sleep(100);
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                    }
                }
                z = 0;
            }
        }
        return arr;
    }
    public int Number_of_0s(int[,] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i,j]==0)
                {
                 count++;
                }
            }
        }
        return count;
    }
    public void Print(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine();
            }
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i,j] ==0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(arr[i, j] + " ");
                Console.ForegroundColor = ConsoleColor.White;

                if (j % 3 == 2)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

//Level eassy

//public Sudoku()
//{
//    int[,] arr ={  {0, 6, 0, 0, 8, 0, 4, 2, 0 },
//                       {0, 1, 5, 0, 6, 0, 3, 7, 8 },
//                       {0, 0, 0, 4, 0, 0, 0, 6, 0 },
//                       {1, 0, 0, 6, 0, 4, 8, 3, 0 },
//                       {3, 0, 6, 0, 1, 0, 7, 0, 5 },
//                       {0, 8, 0, 3, 5, 0, 0, 0, 0 },
//                       {8, 3, 0, 9, 4, 0, 0, 0, 0 },
//                       {0, 7, 2, 1, 3, 0, 9, 0, 0 },
//                       {0, 0, 9, 0, 2, 0, 6, 1, 0 }
//        };
//    this.Array = arr;

//}

//Level imposible
//public Sudoku()
//{
//    int[,] arr ={  {0, 0, 2, 0, 8, 0, 0, 0, 0 },
//                       {0, 0, 3, 0, 0, 0, 0, 0, 6 },
//                       {4, 0, 0, 1, 2, 0, 0, 8, 0 },
//                       {0, 3, 0, 2, 0, 0, 0, 0, 1 },
//                       {0, 6, 0, 8, 0, 1, 0, 3, 0 },
//                       {1, 0, 0, 0, 0, 9, 0, 4, 0 },
//                       {0, 9, 0, 0, 4, 2, 0, 0, 5 },
//                       {6, 0, 0, 0, 0, 0, 3, 0, 0 },
//                       {0, 0, 0, 0, 9, 0, 8, 0, 0 }
//        };
//    this.Array = arr;

//}
