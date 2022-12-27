int n;
Console.WriteLine("Введіть кількість елементів");
n = int.Parse(Console.ReadLine());
double[] array = new double[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Ведіть елемент №{i + 1}");
    array[i] = double.Parse(Console.ReadLine());
}



double neg_sum = 0, max_element,   absolute_max = array[0];
int positeve_idx_sum = 0;
int max_element_idx, non_decimal=0 ;
max_element = array.Max();
max_element_idx = Array.IndexOf(array, max_element);
for (int i = 0; i < n; i++)
{
    if (array[i] <0)
    {neg_sum += array[i];}
    else if (array[i] >0)
    {
        positeve_idx_sum += i+1;
    }
    if (Math.Abs(array[i]) >absolute_max)
    {
        absolute_max = Math.Abs(array[i]);
    }
    if (array[i]%1 == 0)
    {
        non_decimal++;
    }
}


Console.WriteLine($"Індекс найбільшого елементу {max_element_idx + 1}");
Console.WriteLine($"Найбільший елемент {max_element}");
Console.WriteLine($"Максимальний за модулем елемент масиву {absolute_max}");
Console.WriteLine($"Сума індексів додатних елементів {positeve_idx_sum}");
Console.WriteLine($"Сума від’ємних елементів масиву {neg_sum}");
Console.WriteLine($"Кількість цілих чисел у масиві {non_decimal}");
