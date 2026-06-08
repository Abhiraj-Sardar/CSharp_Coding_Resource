Func<int,int,int> add = (a,b) => a+b;
Func <int, int> square = x => x*x;
Func <int, int, bool> max = (x,y) => x>y;

Console.WriteLine(add(10,20)); //30
Console.WriteLine(square(10)); //100
Console.WriteLine(max(10,20)); //False