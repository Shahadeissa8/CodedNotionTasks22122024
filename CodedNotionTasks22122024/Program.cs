﻿
using System.Collections;
using System.Linq;

#region tasks
Console.WriteLine("=====================================Shahad Eissa=============================================\n");

ArrayList myArray = new ArrayList();
myArray.Add("banana");
myArray.Add("apple");
myArray.Add("cherry");


foreach (var printing in myArray)
{
    Console.WriteLine(printing);
}
myArray.Insert(2, "orange");
myArray.Remove(1);

Console.WriteLine("enter your search of fruits: ");
string testingItem = Console.ReadLine().ToLower();
if (myArray.Contains(testingItem))//first go to the list, then check inside that list if the testing item is availbe indside it
{
    Console.WriteLine(myArray.IndexOf(testingItem));
    Console.WriteLine("the array list contains " + testingItem + " and has an index of " + myArray.IndexOf(testingItem));
}
else
{
    Console.WriteLine("item does not exist "); //not requied
}
Console.WriteLine("new array list is: ");
foreach (var printing in myArray)
{
    Console.WriteLine(printing);
}
int x;
#endregion

#region bonus
Console.WriteLine("\n=====================================bonus=============================================");
/* understanding the question
array list {4,5,66,7,8,8,30,,,,}
input 25 
whatever number>25 add it to newarraylist (66,30)
function takes two parameters list and the number ur talking about
values appearing put them in a new list
big loop
for loop with if statement 
returns small loop 
//small loop takes elements from big loop that are bigger than 40
cant use int with array list
*/
ArrayList bigArray = new ArrayList();
ArrayList smallArray = new ArrayList();
bigArray.Add(10);
bigArray.Add(20);
bigArray.Add(30);
bigArray.Add(40);
bigArray.Add(50);
bigArray.Add(60); //adding elements to the array list
int threshold = 40;

foreach (var item in bigArray) //looping around all the array list
{
if ((int)item > threshold) //casting the elements inside the array list to manage to compare it to an in integer
{
Console.WriteLine("number is bigger than 50 is " + item);
smallArray.Add(item);
}
}
Console.Write("the numbers in the second arraylist are: ");
foreach (var item2 in smallArray)
{
    Console.Write(" " + item2);

}
//extra note: we can make the user write the elements inside the array list
#endregion