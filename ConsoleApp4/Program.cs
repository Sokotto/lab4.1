Console.Write("Введите количество элементов в массиве: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.Write("Ошибка. Введите положительное целое число: ");
}
double[] array = new double[n];
Console.WriteLine("Введите элементы массива (вещественные числа):");
for (int i = 0; i < n; i++)
{
    while (true)
    {
        Console.Write($"Элемент {i + 1}: ");
        if (double.TryParse(Console.ReadLine(), out array[i]))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка. Введите вещественное число.");
        }
    }
}
Console.Write("Введите вещественное число S: ");
double S;

while (!double.TryParse(Console.ReadLine(), out S))
{
    Console.Write("Ошибка. Введите вещественное число: ");
}
double maxDistance = double.MinValue;
double farthestElement = 0;
int farthestIndex = -1;

for (int i = 0; i < n; i++)
{
    double distance = Math.Abs(array[i] - S);
    if (distance > maxDistance)
    {
        maxDistance = distance;
        farthestElement = array[i];
        farthestIndex = i;
    }
}
Console.WriteLine($"Элемент, наиболее удаленный от S: {farthestElement} (индекс: {farthestIndex})");