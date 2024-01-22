namespace Sudoku;

public class Program
{
    static void Main(string[] args)
    {
        Sudoku sudoku = new Sudoku();

        Console.WriteLine("Number of 0s " + sudoku.Number_of_0s(sudoku.Array));
        sudoku.Print(sudoku.Array);

        while (sudoku.Number_of_0s(sudoku.Array) != 0)
        {
            sudoku.Array = sudoku.Go_Through_Cells(sudoku.Array);
        }
        Console.Clear();
        Console.WriteLine("Final sudoku");
        sudoku.Print(sudoku.Array);


        Console.ReadKey();
    }

}