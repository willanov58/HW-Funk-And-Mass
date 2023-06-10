int reverse(int Number)
{
int temp=0;
int[] mas= new int[5]; 
int count = 4;
 for (int i =0; i<5;i++)
 {
    temp=Number%10;
    mas[i]=temp;
    Number=Number/10;
 }
 int NewNumber = mas[0];
 for (int i=1;i<5;i++)
 {
    NewNumber=NewNumber*10+mas[i];
 }
return NewNumber;
}
Console.Clear();
Console.WriteLine("Введите пятизначное число => ");
int N =Convert.ToInt32(Console.ReadLine());
if (N<10000){Console.WriteLine($"Число {N} не является пятизначным");}
System.Console.WriteLine($"{N} => {reverse(N)}");
if (reverse(N)==N){Console.WriteLine("Число является палиндромом");}
else {Console.WriteLine("Число не является палиндромом");}