string reverse(string Number)
{
char[] mas= new char[5]; 
int count = 4;
 for (int i =0; i<5;i++)
 {
    mas[i]=Number[count];
    count--;
 }
 string NewNumber = "";
 for (int i=0;i<5;i++)
 {
    NewNumber+=mas[i];
 }
return NewNumber;
}
Console.Clear();
Console.WriteLine("Введите пятизначное число => ");
string N =Console.ReadLine();
int check = Convert.ToInt32(N);
if (check<10000){Console.WriteLine($"Число {N} не является пятизначным");}
System.Console.WriteLine($"{N} => {reverse(N)}");
if (reverse(N)==N){Console.WriteLine("Число является палиндромом");}
else {Console.WriteLine("Число не является палиндромом");}