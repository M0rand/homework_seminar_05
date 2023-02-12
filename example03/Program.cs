// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void DifferenceNumbers(int[] array)
{
    int numbermax = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > numbermax)
        {
            numbermax = array[i];
        }
    }

    int numbermin = numbermax;   
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < numbermin)
        {
            numbermin = array[i];
        }
    }
    System.Console.WriteLine(numbermax - numbermin);
}
        
int[] array = FillArray(5, 1, 99);
PrintArray(array);
DifferenceNumbers(array);     