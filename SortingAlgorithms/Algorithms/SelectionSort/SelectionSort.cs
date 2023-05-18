namespace SortingAlgorithms.Algorithms.SelectionSort;

public static class SelectionSort
{
    public static List<int> Sort(List<int> unsortedList, int index = 0)
    {
        if (index == unsortedList.Count - 1) return unsortedList;
        int tempNumber = unsortedList[index];
        int tempIndex = index;
        int smallest = unsortedList[index];
        for (int i = index; i < unsortedList.Count; i++)
        {
            if (unsortedList[i] < smallest)
            {
                smallest = unsortedList[i];
                tempIndex = i;
            }
        }
        unsortedList[index] = unsortedList[tempIndex];
        unsortedList[tempIndex] = tempNumber;
        return Sort(unsortedList, index + 1);
    }

    public static List<int> SortByDescending(List<int> unsortedList, int index = 0)
    {
        if (index == unsortedList.Count - 1) return unsortedList;
        int tempNumber = unsortedList[index];
        int tempIndex = index;
        int biggest = unsortedList[index];
        for (int i = index; i < unsortedList.Count; i++)
        {
            if (unsortedList[i] > biggest)
            {
                biggest = unsortedList[i];
                tempIndex = i;
            }
        }
        unsortedList[index] = unsortedList[tempIndex];
        unsortedList[tempIndex] = tempNumber;
        return SortByDescending(unsortedList, index + 1);
    }
}
