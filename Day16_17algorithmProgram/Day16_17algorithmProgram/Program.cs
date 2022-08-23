﻿using Day16_17algorithmProgram;
class Program
{
    static void Main(String[] args)
    {
        string flag = "Y";
        while (flag == "Y" || flag == "y")
        {
            Console.WriteLine("Welcome To Datastructures and Algorithms");
            Console.WriteLine("1.Permutation Using Recursion\n2.BinarySearch");
            Console.WriteLine("Enter Your Option");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                //case 1:
                //    PermutationsOfString permutationsofstring = new PermutationsOfString();
                //    permutationsofstring.permutations();
                //    break;
                case 2:
                    BinarySearchProblem binarysearchprob = new BinarySearchProblem();
                    binarysearchprob.binarySearch();
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