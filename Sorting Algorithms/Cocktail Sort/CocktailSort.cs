/// <summary>
/// Cocktail Sort Algorithm implementation in C#
/// The algorithm sorts an array of integers by iterating over the array in both directions,
/// swapping elements if they are in the wrong order. The process is repeated until the array is fully sorted.
/// </summary>
/// <param name="array">Array to be sorted</param>
/// <returns>Sorted array</returns>
public static int[] CocktailSort(int[] array)
{
    bool swapped;
    do
    {
        swapped = false;
        for (int i = 0; i <= array.Length - 2; i++)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
                swapped = true;
            }
        }

        if (!swapped)
        {
            break;
        }

        swapped = false;

        for (int i = array.Length - 2; i >= 0; i--)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
                swapped = true;
            }
        }
    } while (swapped);

    return array;
}