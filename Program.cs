Console.WriteLine("Hello, World!");
int[,] masd = new int[5, 5];
for(int i = 0;i < 5; i++)
{
    for(int j = 0;j<5;j++)
    {
        if(i+j == 4)
        masd[i, j] = i + 1;
        Console.Write(masd[i, j].ToString() +' ');
    }
    Console.WriteLine();
}    