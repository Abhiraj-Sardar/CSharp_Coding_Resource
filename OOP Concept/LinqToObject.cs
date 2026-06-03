
//select one

int[] num = { 5, 4, 1, 3, 9, 8 };
var number = from n in num 
                  select n;
foreach (var i in number)
{
    Console.WriteLine(i.ToString()); //5 4 1 3 9 8
}

//multiple select

int[] num1 = { 12, 34, 5, 6, 7, 33 };
int[] num2 = { 12, 3, 4, 5, 6, 11 };

var query1 = from a in num1
             from b in num2
             where a <= b
             select new { a, b };

foreach(var q in query1)
{
    Console.Write(q.a+ " "+ q.b);
    Console.WriteLine();
}

//12 12
//5 12
//5 5
//5 6
//5 11
//6 12
//6 6
//6 11
//7 12
//7 11


string[] words = { "cherry", "apple", "blueberry" };
var query2 = from w in words
             orderby w
             select w;

foreach (var q in query2)
{
    Console.Write(q + " "); //apple blueberry cherry
}


//count function
int[] factorsOf300 = { 2, 2, 3, 5, 5 };

var query3 = from n in factorsOf300
             .Distinct()
             select n;

foreach (var q in query3)
{
    Console.Write(q + " "); // 2 3 5
}
Console.WriteLine(query3.Count()); // 3


//use of count
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 2 };
int result = numbers.Count(n => n % 2 != 0);
Console.WriteLine("Total Count of odd no: "+result); // 5
