Console.WriteLine("Hello, World!");
//#1
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
//#2
double[,] masdd = new double[3, 4];
Random random= new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        masdd[i, j] = Math.Round(random.NextDouble() * 100 - 50, 2);
        Console.Write(masdd[i, j].ToString() + ' ');
    }
    Console.WriteLine();
}
