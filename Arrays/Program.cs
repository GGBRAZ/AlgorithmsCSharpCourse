//ArraysDemo();
//TestOneBasedArray();
JaggedArraysDemo();

static void ArraysDemo()
{
    int[] a1;
    a1 = new int[10];

    int[] a2 = new int[10];

    int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

    int[] a4 = { 1, 2, 3, 6, 9 };

    //for (int i = 0; i < a3.Length; i++)
    for (int i = 0; i <= a3.Length - 1; i++)
    {
        Console.Write($"{a3[i]}");
    }

    Console.WriteLine();

    foreach (var el in a4)
    {
        Console.Write($"{el}");
    }

    Console.WriteLine();

    Array myArray = new int[5];

    Array myArray2 = Array.CreateInstance(typeof(int), 5);
    myArray2.SetValue(1, 0);

    Console.ReadKey();
}

static void TestOneBasedArray()
{
    Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
    myArray.SetValue(2019, 1);
    myArray.SetValue(2020, 2);
    myArray.SetValue(2021, 3);
    myArray.SetValue(2022, 4);

    Console.WriteLine($"Starting index:{myArray.GetLowerBound(0)}");
    Console.WriteLine($"Ending index:{myArray.GetUpperBound(0)}");

    //for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
    for (int i = 1; i < 5; i++)
    {
        Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
    }
}

static void MultiDimArrays()
{
    int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
    int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

    for (int i = 0; i < r2.GetLength(0); i++)
    {
        for (int j = 0; j < r2.GetLength(1); j++)
        {
            Console.WriteLine($"{r2[i, j]}");
        }
        Console.WriteLine();
    }
}

static void JaggedArraysDemo()
{
    int[][] jaggedArray = new int[4][];
    jaggedArray[0] = new int[1];
    jaggedArray[1] = new int[3];
    jaggedArray[2] = new int[2];
    jaggedArray[3] = new int[4];

    Console.WriteLine("Enterthe numbers for jagged array");
    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            string st = Console.ReadLine();
            jaggedArray[i][j] = int.Parse(st);
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Printing the Elements");

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            Console.Write(jaggedArray[i][j]);
            Console.Write("\0");
        }
        Console.WriteLine("");
    }
}
