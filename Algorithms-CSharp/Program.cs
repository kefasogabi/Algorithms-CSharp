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





//static unsafe void IterateOver(int[] array)
//{
//    fixed(int* p = array)
//    {
//        int* b = p;

//        for(int i = 0;i < array.Length; i++)
//        {
//            Console.WriteLine(*b);
//            b++;
//        }

//    }
//}


//static void ArraysDemo()
//{
//    int[] a1;

//    a1 = new int[10];

//    int[] a2 = new int[5];

//    int [] a3 = new int[5] {1,2,3,4,5};

//    int [] a4 = { 1, 2, 3, 4, 5 };

//    for(int i = 0; i <= a3.Length - 1; i++)
//    {
//        Console.WriteLine($"{a3[i]}");
//    }

//    Console.WriteLine();

//    foreach(var el in a4)
//    {
//        Console.WriteLine($"{el}");
//    }

//    //Multi-Dimentional Array

//    int[,] dimen = {{1,2,4,0},{0,8,8,9}};

//    for (int i = 0; i < dimen.GetLength(0); i++)
//    {
//        for (int j = 0; j < dimen.GetLength(1); j++)
//        {
//            Console.WriteLine(dimen[i, j]);
//        }

//    }


//    //Jagged Array

//    int[][] jagged = new int[4][];
//    jagged[0] = new int[2] {1,7};
//    jagged[1] = new int[1] {8};
//    jagged[2] = new int[3] {9,1,7};
//    jagged[3] = new int[4] {3,2,1,7};

//    for(int i = 0;i < jagged.Length; i++)
//    {
//        for(int j = 0;j < jagged[i].Length; j++)
//        {
//            Console.Write(jagged[i][j]);
//            Console.Write("\0");
//        }
//        Console.WriteLine("");
//    }


   

   

//    Console.WriteLine();

//    Console.Read();
//}

//var stack = new LinkedStack<int>();

//stack.Push(1);
//stack.Push(2);
//stack.Push(3);
//stack.Push(4);

//Console.WriteLine($"Should print out 4: {stack.Peek()}");

//stack.Pop();

//Console.WriteLine($"Should print out 3: {stack.Peek()}");


//Console.WriteLine("Iterate over the stack.");

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}


var CustomerList = new List<Customer>()
{
    new Customer() { Name = "Ann", Age = 3 },
    new Customer() { Name = "Bill", Age = 16 },
    new Customer() { Name = "Rose", Age = 20 },
    new Customer() { Name = "Rob", Age = 14 },
    new Customer() { Name = "Bill", Age = 28 }, 
    new Customer() { Name = "John", Age = 14 }, 
};

var intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12, 3, 2, 1 };

bool contains = intList.Contains(3);
bool contains2 = CustomerList.Contains(new Customer() { Name = "Rob", Age = 14 }, new CustomersComparer());

bool exists = CustomerList.Exists(x => x.Age == 28);

int min = intList.Min();
int max = intList.Max();

int youngestCustomerAge = CustomerList.Min(x => x.Age);

Customer bill = CustomerList.Find(x => x.Name == "Bill");

Customer lastBill = CustomerList.FindLast(x => x.Name == "Bill");

Customer lastBill2 = CustomerList.Last(x => x.Name == "Bill");

List<Customer> customers = CustomerList.FindAll(x => x.Age > 18);
IEnumerable<Customer> customers2 = customers.Where(x => x.Age > 18);

int index1 = CustomerList.FindIndex(x => x.Age == 14);
int lastIndex = CustomerList.FindLastIndex(x => x.Age > 18);

int indexOf = intList.IndexOf(2);
int lastIndexOf = intList.LastIndexOf(2);


// for list
bool isTrueForAll = CustomerList.TrueForAll(x => x.Age > 10);

// from linq

bool all = CustomerList.All(x => x.Age > 18);

bool areThereAny = CustomerList.Any(x => x.Age == 3);

int count = CustomerList.Count( x => x.Age > 18);

Customer firstBill = CustomerList.First(x => x.Name == "Bill");

Customer singleAnn = CustomerList.Single(x => x.Name == "Ann");


bool Exists(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(number == array[i])
        {
             return true;
        }
    }
    return false;
}


int IndexOf(int[] array, int number)
{
    for(int i = 0;i < array.Length; i++)
    {
        if(array[i] == number)
        {
            return i;
        }
    }

    return -1;
}


Console.ReadKey();  