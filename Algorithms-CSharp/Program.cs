using Algorithms_CSharp;
using Algorithms_DataStruct_Lib;
using System.Diagnostics;



//var ints = In.ReadInts("1Kints.txt").ToArray();

//var watch = new Stopwatch();
//watch.Start();

//var triplets = ThreeSum.Count(ints);
//watch.Stop();

//Console.WriteLine($"The number of \"zero-sum\" triplets:{triplets}");
//Console.WriteLine($"Time taken:{watch.Elapsed:g}");

//IterateOver(new int[] { 1,2,3});





static unsafe void IterateOver(int[] array)
{
    fixed(int* p = array)
    {
        int* b = p;

        for(int i = 0;i < array.Length; i++)
        {
            Console.WriteLine(*b);
            b++;
        }

    }
}


static void ArraysDemo()
{
    int[] a1;

    a1 = new int[10];

    int[] a2 = new int[5];

    int [] a3 = new int[5] {1,2,3,4,5};

    int [] a4 = { 1, 2, 3, 4, 5 };

    for(int i = 0; i <= a3.Length - 1; i++)
    {
        Console.WriteLine($"{a3[i]}");
    }

    Console.WriteLine();

    foreach(var el in a4)
    {
        Console.WriteLine($"{el}");
    }

    //Multi-Dimentional Array

    int[,] dimen = {{1,2,4,0},{0,8,8,9}};

    for (int i = 0; i < dimen.GetLength(0); i++)
    {
        for (int j = 0; j < dimen.GetLength(1); j++)
        {
            Console.WriteLine(dimen[i, j]);
        }

    }


    //Jagged Array

    int[][] jagged = new int[4][];
    jagged[0] = new int[2] {1,7};
    jagged[1] = new int[1] {8};
    jagged[2] = new int[3] {9,1,7};
    jagged[3] = new int[4] {3,2,1,7};

    for(int i = 0;i < jagged.Length; i++)
    {
        for(int j = 0;j < jagged[i].Length; j++)
        {
            Console.Write(jagged[i][j]);
            Console.Write("\0");
        }
        Console.WriteLine("");
    }


   

   

    Console.WriteLine();

    Console.Read();
}