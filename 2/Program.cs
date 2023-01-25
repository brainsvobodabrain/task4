/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
System.Console.Write("Введите число: ");
string chislo=Console.ReadLine();
int summ=0;

for (int i=0; i<chislo.Length;i++){ 
    summ=Convert.ToInt32(chislo[i].ToString())+summ;
}
System.Console.WriteLine($"Сумма всех цифр числа {chislo} = {summ}");