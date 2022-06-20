// Triangle
Console.Clear();
int row = 5;
int[,] triangle = new int[row, row];
const int cellWidth = 3;
void FillTriangle ()
{
    for (int i =0; i < row; i++)
    {
        triangle [i,0] = 1;
        triangle [i,i] = 1;
    }
    for (int i =2; i<row; i++)
    {
        for (int j = 1; j<= i; j++)
        {
            triangle [i,j] =
            triangle[i-1, j-1] + triangle [i-1, j];
        }
    }
}
void PrintTriangle()
{
    for (int i = 0; i<row; i++)
    {
        for (int j =0; j<row; j++)
        {
            if (triangle[i,j]!= 0)
            Console.Write ($"{triangle[i,j],cellWidht}");
        }
        Console.WriteLine();        
    }
}
void Magic() ...
{
 int col = cellWidth row;
 for int 
Console.ReadLine();
FillTriangle();
PrintTriangle ();
Console.ReadLine();
Magic ();
