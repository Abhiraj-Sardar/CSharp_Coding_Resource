// readonly is a keyword used primarily to declare that a field can only be assigned a value during its declaration 
// or inside a constructor of the same class. Once the constructor finishes executing, 
// the field becomes immutable and its value or reference cannot be changed.

using System;

class GarbageCollector
{
    public static void Main()
    {
        for(int i=0;i<100; i++)
        {
           var obj = new Object();
        }
        GC.Collect(); // Forces garbage collection of all generation (Gen - 0, 1, 2)
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Forced garbage collection completed.");

        String name = "Abhiraj";
        Console.WriteLine("Generation Name:"+GC.GetGeneration(name)); // 2147483647 which is Gen - 2

        long before = GC.GetTotalMemory(false);
        int[] arr = new int[1000];
        long after = GC.GetTotalMemory(false);

        Console.WriteLine($"Memory before: {before} bytes"); //Memory before: 64016 bytes
        Console.WriteLine($"Memory after: {after} bytes"); //Memory after: 72240 bytes
    }
}
