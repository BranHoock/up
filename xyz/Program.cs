// Дан массив, содержащий 10 элементов. Вычислить произведение элементов, стоящих после первого отрицательного элемента. Вывести исходный массив и результат вычислений
Random rnd = new Random();
double [] mas = new double[10];
double s = 1;
bool isNotFound= false;
for (int i = 0; i < 10; i++)
{
    mas[i] = rnd.Next(-10,100);
    Console.WriteLine("{0},", mas[i]);
    if (isNotFound){s = s * mas[i];}
    isNotFound|= mas[i] < 0;
}
Console.WriteLine("s={0},", s);