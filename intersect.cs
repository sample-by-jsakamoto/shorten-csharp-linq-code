// Source List with String A,B,C,D,E
var listA = new [] {"A","B","C","D","E"};

// List To Compare with String 1,A,4,E,5
var listB = new [] {"1","A","4","E","5"};

// Retrieve the List of String which appear on both List
var matchList = listA.Intersect(listB).ToList();

// Output the list of matched string
matchList.ForEach(Console.WriteLine);