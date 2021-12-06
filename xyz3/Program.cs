// Дан массив, содержащий 14 элементов. Вычислить сумму элементов, стоящих до первого отрицательного элемента. Вывести исходный массив и результат вычислений
Random rnd = new Random();
double [] mas = new double[14];
double s = 0;
bool isNotFound= true;
for (int i = 0; i < 14; i++)
{
    mas[i] = rnd.Next(-10,100);
    Console.WriteLine("{0},", mas[i]);
    isNotFound&= mas[i] > 0;
    if (isNotFound){s = s + mas[i];}
    
}
Console.WriteLine("s={0},", s);
