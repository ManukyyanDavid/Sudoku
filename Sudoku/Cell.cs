namespace Sudoku;

public class Cell
{
    public int Value { get; set; }
    public int Section { get; set; }
    public int x { get; set; } //horizontal
    public int y { get; set; } //vertical

    public Cell(int i, int j, int[,] arr)
    {
        this.x = i;
        this.y = j;
        this.Value = arr[i,j];
        Section = 1;
        switch (this.x) 
        {
            case 0:
            case 1:
            case 2:
                switch (this.y)
                {
                    case 0:
                    case 1:
                    case 2: this.Section = 1; break;
                    case 3:
                    case 4:
                    case 5: this.Section = 2; break;
                    case 6:
                    case 7:
                    case 8: this.Section = 3; break;
                }
                break;
            case 3:
            case 4:
            case 5:
                switch (this.y)
                {
                    case 0:
                    case 1:
                    case 2: this.Section = 4; break;
                    case 3:
                    case 4:
                    case 5: this.Section = 5; break;
                    case 6:
                    case 7:
                    case 8: this.Section = 6; break;
                }
                break;
            case 6:
            case 7:
            case 8:
                switch (this.y)
                {
                    case 0:
                    case 1:
                    case 2: this.Section = 7; break;
                    case 3:
                    case 4:
                    case 5: this.Section = 8; break;
                    case 6:
                    case 7:
                    case 8: this.Section = 9; break;
                };
                break;
        }
    }




    public bool Check_Vertical(int[,] arr, int checkingvalue, int column)
    {
        for (int row = 0; row < 9; row++)
        {
            if (arr[row, column] == checkingvalue)
            {
                return false;
            }
        }
        return true;
    }

    public bool Check_Horizontal(int[,] arr, int checkingvalue, int row)
    {
        for (int column = 0; column < 9; column++)
        {
            if (arr[ row, column] == checkingvalue)
            {
                return false;
            }
        }
        return true;

    }
    public bool Check_Section(int[,] arr,  int row, int column, int checkingvalue)
    {
        int row0 = 0;
        int row1 = 0;//maximum and minimum values for the array to check
        int column0 = 0;
        int column1 = 0;
        switch (Section)
        {
            case 1: row0 = 0;   row1 = 0+3;   column0 = 0;   column1 = 0+3;     break; 
            case 2: row0 = 0;   row1 = 0+3;   column0 = 3;   column1 = 3+3;     break;
            case 3: row0 = 0;   row1 = 0+3;   column0 = 6;   column1 = 6+3;     break;
            case 4: row0 = 3;   row1 = 3+3;   column0 = 0;   column1 = 0+3;     break;
            case 5: row0 = 3;   row1 = 3+3;   column0 = 3;   column1 = 3+3;     break;
            case 6: row0 = 3;   row1 = 3+3;   column0 = 6;   column1 = 6+3;     break;
            case 7: row0 = 6;   row1 = 6+3;   column0 = 0;   column1 = 0+3;     break;
            case 8: row0 = 6;   row1 = 6+3;   column0 = 3;   column1 = 3+3;     break;
            case 9: row0 = 6;   row1 = 6+3;   column0 = 6;   column1 = 6+3;     break;
        }

        for (int i = row0; i < row1; i++)
        {
            for (int j = column0; j < column1; j++)
            {
                if (arr[i,j] == checkingvalue)
                {
                    return false;
                }
            }
        }
        return true;
    }

}
