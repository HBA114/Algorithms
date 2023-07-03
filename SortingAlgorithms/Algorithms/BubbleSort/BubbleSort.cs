namespace SortingAlgorithms.Algorithms.BubbleSort;

public static class BubbleSort
{
    public static List<int> Sort(List<int> unsortedList)
    {
        int sortedCount = 0;   

        do
        {
            for (int i = 1; i < unsortedList.Count - sortedCount; i++)
            {
                if (unsortedList[i - 1] > unsortedList[i])
                {
                    int temp = unsortedList[i];
                    unsortedList[i] = unsortedList[i - 1];
                    unsortedList[i - 1] = temp;
                }
            }
            sortedCount++;
        } while (sortedCount < unsortedList.Count);
        
        return unsortedList;
    }

    public static List<int> SortByDescending(List<int> unsortedList)
    {
        int sortedCount = 0;
        
        do
        {
            for (int i = 1; i < unsortedList.Count - sortedCount; i++)
            {
                if (unsortedList[i - 1] < unsortedList[i])
                {
                    int temp = unsortedList[i];
                    unsortedList[i] = unsortedList[i - 1];
                    unsortedList[i - 1] = temp;
                }
            }
            sortedCount++;
        } while (sortedCount < unsortedList.Count);
        
        return unsortedList;
    }
}
