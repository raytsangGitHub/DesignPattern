// See https://aka.ms/new-console-template for more information

//This project uses Strategy pattern to access family of sorting algorithms.
// Algorithms are explained in https://en.wikipedia.org/wiki/Sorting_algorithm
//Algorithms are:
// 1. SimpleSortForSmallData: insertion and Selection
// 2. EfficientSortsForBigData: Heap, Merge and quick
// 3. Stable sorts: IntroSort - hybrid sort (based on quicksort, falling back to heapsort), TimSort
// 4. inefficient sorting algorithms: Bubble sort, and variants such as the Comb sort and cocktail sort
// 5. Shell

//Design ToDo: convert object to a List (using as List<>)
// using factory method with strategy. (How to use different design pattern in an app?)
//how the design patterns are interact with each other?
//using only generics for class 

using Behavioral.Strategy.SortingAlgo.ContextSort;
using Behavioral.Strategy.SortingAlgo.StrategySort;

List<string> TestData = new List<string> { "A", "C", "D", "B", "X" };

ContextSorting<List<string>> contextSorting = new(); //new SelectionSort<IList<string>>()
//IStrategySort<List<string>> selectionSort = new SelectionSort<IList<string>>(TestData);  //Need work
List<string> data = contextSorting.SortObject(TestData);

foreach (string item in data)
{
    Console.WriteLine(item);
}


