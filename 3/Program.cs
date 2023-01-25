/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int arrlength=8;
int[] arr=new int[arrlength];
System.Console.WriteLine($"Введите {arrlength} эллементов массива");
for (int i=0;i<arrlength;i++){
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine("["+string.Join(", ",arr)+"]");