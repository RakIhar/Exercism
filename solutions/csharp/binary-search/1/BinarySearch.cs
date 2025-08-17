public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int min = 0, max = input.Length - 1;
        if (max == -1) return -1;
        int current = - 1;
        bool isFound = false;
        while (max > min)
        {
            current = (min + max) / 2;
            if (input[current] > value)
            {
                max = current - 1;
            }
            else if (input[current] < value)
            {
                min = current + 1;
            }
            else
            {
                isFound = true;
                break;
            }
        }
        if (max == min)
        {
            current = max;
            isFound = input[current] == value;
        }
        return isFound ? current : -1;
    }
}