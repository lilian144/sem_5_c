// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int CalculateDifference(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        int currentElement = arr[i];
        if(currentElement > max) max = currentElement;
        if(currentElement < min) min = currentElement;
    }
    return max - min;
}

int[] array = {14, 7, 22, 50, 78};
Console.WriteLine(string.Join(" ", array));
int result = CalculateDifference(array);
Console.WriteLine(string.Join(" ", result));