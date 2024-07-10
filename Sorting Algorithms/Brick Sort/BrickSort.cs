/// <summary>
/// Sorts an array using the Brick Sort algorithm.
/// </summary>
/// <param name="arr">The array to be sorted.</param>
static void BrickSort(int[] arr)
{
    bool sorted = false;
    while (!sorted)
    {
        sorted = true;
        for (int i = 1; i <= arr.Length - 2; i += 2)
        {
            if (arr[i] > arr[i + 1])
            {
                Swap(ref arr[i], ref arr[i + 1]);
                sorted = false;
            }
        }
        for (int i = 0; i <= arr.Length - 2; i += 2)
        {
            if (arr[i] > arr[i + 1])
            {
                Swap(ref arr[i], ref arr[i + 1]);
                sorted = false;
            }
        }
    }
}

/// <summary>
/// Swaps two elements in an array.
/// </summary>
/// <param name="a">First element to swap.</param>
/// <param name="b">Second element to swap.</param>
static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
