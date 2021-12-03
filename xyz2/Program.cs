// Написать метод, который вычисляет значения x = a2 и y = √a.Напечатать таблицу значений от –10 до 10 с шагом 1
Console.WriteLine("Hello, World!");
int []mas = new int[20];
for (int i = 0; i < 20; i++)

{
    mas[i] = i - 10;

double x= Math.Pow(mas[i],2);
Console.WriteLine("x={0},", x);
double y= Math.Sqrt(mas[i]);
Console.WriteLine("y={0},", y);

}
