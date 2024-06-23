// string val1 = "a";
// string val2 = "A";
// Console.WriteLine(val1.Trim().ToLower() == val2.Trim().ToLower());

/*For loop*/
// string [] names = {"Bob", "Malik", "Saheed"};

// for (int i = names.Length - 1; i >= 0; i--){
//     Console.WriteLine(names[i]);
// }


/*======================================================*/
/*======================================================*/
/*======================================================*/
/*FIZZBUZZ GAME*/
// for(int i = 1; i <= 100; i++){
//     if((i % 3 == 0) && (i % 5 == 0)){
//         Console.WriteLine($"{i} - FizzBuzz");
//     }
//     else if(i % 3 == 0){
//         Console.WriteLine($"{i} - Fizz");
//     }else if(i % 5 == 0){
//         Console.WriteLine($"{i} - Buzz");
//     }
//     else{
//         Console.WriteLine(i);
//     }
// }

/*======================================================*/
/*======================================================*/
/*======================================================*/
/*DO-WHILE LOOP*/

// Random random = new Random();
// int current = 0;

// do{
//     current = random.Next(1,20);
//     Console.WriteLine(current);
// }while(current != 9);



// Random random = new Random();
// int current = random.Next(1,20);

// do{
//     current = random.Next(1,20);

//     if(current >=  8) continue;

//     Console.WriteLine(current);
// }while(current != 10);


/*======================================================*/
/*======================================================*/
/*======================================================*/
/*WHILE LOOP*/
// Random random = new Random();
// int current = random.Next(1,20);
// while(current >= 5){
//     Console.WriteLine(current);
//     current = random.Next(1,20);
// }
// Console.WriteLine($"Last number: {current}");


/*======================================================*/
/*======================================================*/
/*======================================================*/
/*ROLE PLAYING GAME*/
// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


/*======================================================*/
/*======================================================*/
/*======================================================*/
/*VALIDATE INTEGER INPUT*/

// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNubmer = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do{
//     readResult = Console.ReadLine();

//     if(readResult != null){
//        valueEntered = readResult;
    
//     } 
    
//     validNubmer = int.TryParse(valueEntered, out numValue);

//     if (validNubmer == true){
//         if(numValue <= 5 || numValue >= 10){
//             validNubmer = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }else{
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }

// } while(validNubmer == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();


/*======================================================*/
/*======================================================*/
/*======================================================*/
/*VALIDATE STRING INPUT*/

// string? readResult;
// string roleName = "";
// bool validEntry = false;

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

// do{
//     readResult = Console.ReadLine();
//     string formattedResult = "";

//     if(readResult != null)
//     {
//         roleName = readResult;
//     }

//     formattedResult = roleName.Trim().ToLower();
//     Console.WriteLine($"You input ({readResult}) was formatted to ({formattedResult})");

//     if((formattedResult == "administrator") || (formattedResult == "manager") || (formattedResult == "user"))
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.WriteLine($"The role name that you entered, \"{readResult}\", is not valid. Enter your role name (Administrator, Manager, or User)");
//     }

// }while(validEntry == false);

// Console.WriteLine($"Your input value ({readResult}) has been accepted.");
// readResult = Console.ReadLine();



/*======================================================*/
/*======================================================*/
/*======================================================*/
/*PROCESS THE CONTENTS OF A STRING ARRAY*/

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// int periodLocation;
// string myString = "";

// for(int i = 0; i < myStrings.Length; i++){

//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");
//     string mySentence;

//     while(periodLocation != -1){

//         // first sentence is the string value to the left of the period location
//         mySentence = myString.Remove(periodLocation);

//         // the remainder of myString is the string value to the right of the location
//         myString = myString.Substring(periodLocation + 1);

//         // remove any leading white-space from myString
//         myString = myString.TrimStart();

//         // update the comma location and increment the counter
//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }

//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }



/*======================================================*/
/*======================================================*/
/*======================================================*/
/*LANGUAGE INTEGRATED QUERY(LINQ)*/

// List<int> scores = [100, 30,80,90,99,70,150];

// IEnumerable<int> scoreQuery = 
//     from score in scores 
//     where score > 80
//     orderby score descending
//     select score;

// List<int> myScores = scoreQuery.ToList();

// foreach (var score in myScores){
//     Console.WriteLine(score);
// }