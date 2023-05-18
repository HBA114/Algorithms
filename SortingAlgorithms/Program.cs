using SortingAlgorithms.Algorithms.SelectionSort;

List<int> numberList = new() { 1, 4, 2, 9, 0, 3, 7, 6, 5, 8 };
Console.WriteLine("Original: ");
foreach (var item in numberList)
{
    Console.Write($"{item} , ");
}
Console.WriteLine("");

var result = SelectionSort.Sort(numberList);

Console.WriteLine("Sorted: ");
foreach (var item in result)
{
    Console.Write($"{item} , ");
}
Console.WriteLine("");

var resultDescending = SelectionSort.SortByDescending(numberList);

Console.WriteLine($"Sorted Descending: ");
foreach (var item in resultDescending)
{
    Console.Write($"{item} , ");
}
Console.WriteLine($"");
