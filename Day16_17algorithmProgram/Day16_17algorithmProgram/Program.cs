using Day16_17algorithmProgram;
class Program
{
    static void Main(String[] args)
    {
        string flag = "Y";
        while (flag == "Y" || flag == "y")
        {
            Console.WriteLine("Welcome To Datastructures and Algorithms");
            Console.WriteLine("1.Permutation Using Recursion\n2.BinarySearch\n3.InsertionSort\n4.BubbleSort\n5.MergeSort\n6.Anagram\n7.PrimeNumber\n8.AnagramAndPalindromeNumber\n9.SearchingAndSortingUsingGenerics\n10.FindNumber\n11.TaskDoneByMaximumAmount\n12.CustomisedMessages  ");
            Console.WriteLine("Enter Your Option");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                //case 1:
                //    PermutationsOfString permutationsofstring = new PermutationsOfString();
                //    permutationsofstring.permutations();
                //    break;
                //case 2:
                //    BinarySearchProb binarysearchprob = new BinarySearchProb();
                //    binarysearchprob.binarySearch();
                //    break;
                //case 3:
                //    BubbleSort insertionsort = new BubbleSort();
                //    insertionsort.insertionSort();
                //    break;
                //case 4:
                //    BubbleSort bubblesort = new BubbleSort();
                //    bubblesort.bubbleSort();
                //    break;
                //case 5:
                //    MergeSort mergesort = new MergeSort();
                //    mergesort.mergeSort();
                //    break;
                //case 6:
                //    Anagrams anagrams = new Anagrams();
                //    anagrams.checkAnagrams();
                //    break;
                //case 7:
                //    PrimeNumbers primenumbers = new PrimeNumbers();
                //    primenumbers.primeNumbers();
                //    break;
                //case 8:
                //    AnagramAndPalindromeNumber anagramandpalindromenumber = new AnagramAndPalindromeNumber();
                //    anagramandpalindromenumber.anagramAndPalindrome();
                //    break;
                //case 9:
                //    SearchingAndSortingUsingGenerics searchingandsortingusinggenerics = new SearchingAndSortingUsingGenerics();
                //    searchingandsortingusinggenerics.SearchingAndSorting();
                //    break;
                //case 10:
                //    FindNumber findnumber = new FindNumber();
                //    findnumber.Find();
                //    break;
                //case 11:
                //    TaskDoneByMaximumAmount taskdonebymaximumamount = new TaskDoneByMaximumAmount();
                //    taskdonebymaximumamount.tasks();
                //    break;
                case 12:
                    CustomizedMessage customizedmessage = new CustomizedMessage();
                    customizedmessage.printMessage();
                    break;
                default:
                    Console.WriteLine("-------Enter the valid option---");
                    break;
            }
            Console.WriteLine("\nDo you want to continue");
            flag = Console.ReadLine();
        }
        Console.ReadKey();
    }
}