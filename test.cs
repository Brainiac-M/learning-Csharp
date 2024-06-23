// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// string first = "5";
// string second = "6";
// int result = int.Parse(first) + int.Parse(second);
// Console.WriteLine(result);

// using System.Globalization;
// CultureInfo.CurrentCulture = new CultureInfo("en-US");

// string value1 = "6";
// string value2 = "5";
// int result = Convert.ToInt32(value1) + Convert.ToInt32(value2);
// Console.WriteLine(result);

// int value = (int) 1.5m;
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m);
// Console.WriteLine(value2);


// string[] values = {"ABC", "2", "90", "DEF", "5"};
// string message = "";
// int total = 0;

// for(int i = 0; i < values.Length; i++)
// {
//     int number = 0;
//     if(int.TryParse(values[i], out number))
//     {
//         total += number;
//         // Console.WriteLine($"Total: {total}");
//     }
//     else
//     {
//         message += values[i];
//         // Console.WriteLine($"Message: {message}");
//     }

// }

// Console.WriteLine($"Total: {total}");
// Console.WriteLine($"Message: {message}");

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// int result1 = Convert.ToInt32 (value1/ value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


//#################################################################################
//#################################################################################
//#################################################################################

//ARRAY OPERATIONS

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

string [] pallets = {"B14", "A11", "B12", "A13"};

//sorting
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);

// foreach( var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// //reverse
// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);

// foreach( var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

//clear
// Console.WriteLine("");

// // Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);

// // if (pallets[0] != null)
// // {
// //     Console.WriteLine($"After: {pallets[0].ToLower()}");
// // }
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// //resize
// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing to 6...count: {pallets.Length}");

// pallets[4] = "MN32";
// pallets[5] = "AZ40";

// foreach( var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// Console.WriteLine("");
// Array.Resize(ref pallets, 5);
// Console.WriteLine($"Resizing to 5...count: {pallets.Length}");
// foreach( var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }




//Split() and Join()

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// //Console.WriteLine(valueArray);
// Array.Reverse(valueArray);
// //Console.WriteLine(valueArray);
// //string result = new string(valueArray);

// string result = String.Join(",", valueArray); //convert character array to comma-separated string array 
// Console.WriteLine(result);

// //split 
// string[] items = result.Split(",");
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }




//#################################################################################
//#################################################################################
//#################################################################################

//CODING CHALLENGE: REVERSE THE WORDS IN A SENTENCE
// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] itemsArray = pangram.Split(" ");

// // foreach (string item in itemsArray)
// // {
// //     Console.WriteLine(item);
// // }

// // create an empty array to be used to store final result
// string [] newItemsArray = new string[itemsArray.Length];
// // Console.WriteLine(newItemsArray);

// //Iterate through each item to reverse the characters
// for (int i = 0; i < itemsArray.Length; i++)
// {
//     char[] letters = itemsArray[i].ToCharArray();
//     Array.Reverse(letters);
//     // Console.WriteLine(letters);

//     // put the reversed items into the empty array
//     newItemsArray[i] = new string(letters);
// }

// // display result
// string result =  String.Join(" ", newItemsArray);
// Console.WriteLine(result);



//#################################################################################
//#################################################################################
//#################################################################################

//CODING CHALLENGE: SORD ORDER IDS AND TAG ERRORS


// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// //split string and put elements in an array
// string[] orderArray = orderStream.Split(",");

// // sort array alphabetically
// Array.Sort(orderArray); 
// // foreach(string item in orderArray)
// // {
// //     Console.WriteLine(item);
// // }

// for(int i = 0; i < orderArray.Length; i++)
// {
//     char[] id = orderArray[i].ToCharArray();

//     if(id.Length != 4)
//     {
//         Console.WriteLine($"{orderArray[i]}     - Error");
//     }
//     else
//     {
//         Console.WriteLine(orderArray[i]);
//     }
// }


// OR

// foreach (var item in items)
// {
//     if (item.Length == 4)
//     {
//         Console.WriteLine(item);
//     }
//     else
//     {
//         Console.WriteLine(item + "\t- Error");
//     }
// }




//#################################################################################
//#################################################################################
//#################################################################################

//STRING FORMATTING

//Composite Formatting 
// string first = "Hello";
// string second = "world";
// string result = string.Format("{0} {1}!!!", first, second);
// Console.WriteLine(result);

// Console.WriteLine("{0} {1}!!!", second,  first); //world Hello!!!
// Console.WriteLine("{0} {0} {0}", first, second); //Hello Hello Hello



//String interpolation
// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");


//Currency Formatting
// decimal price = 139.3m;
// int discount = 40;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");


//NUMBER FORMATTING
// decimal measurement = 12456779.45677474m;
// Console.WriteLine($"The answer is {measurement:N} units");
// Console.WriteLine($"The answer is {measurement:N5} units");


//FORMATTING Percentages
// decimal tax = .36785666m;
// Console.WriteLine($"Tax rate: {tax:P2}");
// Console.WriteLine($"Tax rate: {tax:P4}");


decimal price = 90.799m;
decimal salePrice = 50.9957m;
string yourDiscount = String.Format("You saved {0:C3} off your regular {1:C2} price.", (price - salePrice), (price));

yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
Console.WriteLine(yourDiscount);


