using Algorithms_DataStruct_Lib;
using System.Diagnostics;
using ThreeSums;

var ints = In.ReadInts("./data/1Kints.txt").ToArray();
var watch = new Stopwatch();
watch.Start();

var triplets = ThreeSum.Count(ints);
watch.Stop();
Console.WriteLine($"The number of \"zero-sum\" triplets:{triplets}");
Console.WriteLine($"Time taken:{watch.Elapsed:g}");
Console.ReadLine();