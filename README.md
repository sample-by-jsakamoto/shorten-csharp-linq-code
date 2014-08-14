Start from here.

```C#
// Source List with String A,B,C,D,E
var listA = new List<string>();
listA.Add("A");
listA.Add("B");
listA.Add("C");
listA.Add("D");
listA.Add("E");

// List To Compare with String 1,A,4,E,5
var listB = new List<string>();
listB.Add("1");
listB.Add("A");
listB.Add("4");
listB.Add("E");
listB.Add("5");

// Retrieve the List of String which appear on both List
var matchList = listA.Intersect(listB).ToList();

for (int i = 0; i < matchList.Count; i++)
{
	// Output the list of matched string
	Console.WriteLine(matchList[i]);
}
```

We can use "collection initializer".

```C#
// Source List with String A,B,C,D,E
var listA = new List<string> {"A","B","C","D","E"};

// List To Compare with String 1,A,4,E,5
var listB = new List<string> {"1","A","4","E","5"};

// Retrieve the List of String which appear on both List
var matchList = listA.Intersect(listB).ToList();

for (int i = 0; i < matchList.Count; i++)
{
	// Output the list of matched string
	Console.WriteLine(matchList[i]);
}
```

We can use "ForEach" extension method instead of "for" loop. This effect deletion variable "i".

```C#
// Source List with String A,B,C,D,E
var listA = new List<string> {"A","B","C","D","E"};

// List To Compare with String 1,A,4,E,5
var listB = new List<string> {"1","A","4","E","5"};

// Retrieve the List of String which appear on both List
var matchList = listA.Intersect(listB).ToList();

// Output the list of matched string
matchList.ForEach(Console.WriteLine);
```

We can also simple array instead of List<T>. LINQ can apply simple array, too.

```C#
// Source List with String A,B,C,D,E
var listA = new [] {"A","B","C","D","E"};

// List To Compare with String 1,A,4,E,5
var listB = new [] {"1","A","4","E","5"};

// Retrieve the List of String which appear on both List
var matchList = listA.Intersect(listB).ToList();

// Output the list of matched string
matchList.ForEach(Console.WriteLine);
```

We can write method chain style code. then, we succeeded in reducing number of variable.

```C#
// Source List with String A,B,C,D,E
var listA = new [] {"A","B","C","D","E"};

// List To Compare with String 1,A,4,E,5
var listB = new [] {"1","A","4","E","5"};

// Retrieve the List of String which appear on both List
// Output the list of matched string
listA.Intersect(listB)
	.ToList()
	.ForEach(Console.WriteLine);
```
