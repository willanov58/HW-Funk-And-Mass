void Cubes(int N)
{
int Count=1;
   for (int i=0;i<N;i++)
{
    Console.WriteLine(Math.Pow(Count,3));
    Count++;
} 
}
Console.Clear();
Console.Write("Введите число N =>  ");
int N=Convert.ToInt32(Console.ReadLine());
Cubes(N);