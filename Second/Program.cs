double distance(double x1,double y1,double z1,double x2,double y2,double z2)
{
    double temp =Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((x2-x1),2);
    return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
}
Console.Clear();
Console.Write("Введите число x1 =>  ");
double x1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y1 =>  ");
double y1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число z1 =>  ");
double z1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число x2 =>  ");
double x2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y2 =>  ");
double y2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число z2 => ");
double z2=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(distance(x1,y1,z1,x2,y2,z2));
