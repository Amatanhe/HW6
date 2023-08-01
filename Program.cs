//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];
int[] GetArray () ;
{
int [] array = new int [5];
for (int i = 0;i<5; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива" );
Array[i] = Convert.ToInt32(Console.ReadLine());
}
}
return array;
void PrintArray(int[] array) ;

int FindNeg (int[] array);
{
for (int i = 0;i<5; i++)
{
int sum = 0;
if(Array[i]>0)
{
sum = sum + 1;
i = i + 1;
}
}
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());
int y= (k1*(b2-b1) /(k1-k2)) +b1;
int x=(b2-b1) /(k1-k2);
int res= 0;
If (x == y);
{
res = x == y;
} ;
Console.WriteLine($" Точка пресечения 2-х координат: {res}");
Console.WriteLine(" Введите переменную b1: " 
);
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Введите переменную b2: " );
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2: " );
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1-b2) / (k1-k2);
double y = k1 * x + b1;

Console.WriteLine ($"Точка пересечения двух прямых: [{x},{y}]");
