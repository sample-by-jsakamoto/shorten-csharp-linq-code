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
