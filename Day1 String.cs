//Console is a class in the System namespace that provides methods for input and output operations.
//It allows you to read from the console and write to the console. 
//In this code snippet, we are using Console.WriteLine() method to print messages to the console.
//We are also demonstrating string concatenation and string interpolation to create dynamic messages. 
//Additionally, we are using the Length property of strings to get the number of characters in a string.
Console.WriteLine("Hello, World!");
string aFriend = "Bill";
Console.WriteLine(aFriend);
aFriend = "Aryan";
Console.WriteLine(aFriend);
Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}");

// String Interpolation and Concatenation also works with expressions and learn about string properties and methods example Length.
string firstFriend = "Ujjwal";
string secondFriend = "Akshay";
Console.WriteLine($"My friend are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
Console.WriteLine("The name " + secondFriend + " has " + secondFriend.Length + "letters");


//White space in strings and how to trim it using TrimStart(), TrimEnd() and Trim() methods.
//[] is used to show the white space in the string. TrimStart() method removes the white space from the start of the string,
// TrimEnd() method removes the white space from the end of the string and 
//Trim() method removes the white space from both ends of the string.
string greeting = "       Have a Great Day!        ";
Console.WriteLine($"[{greeting}]");
string trimedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimedGreeting}]");
trimedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimedGreeting}]");
trimedGreeting = greeting.Trim();
Console.WriteLine($"[{trimedGreeting}]");

//String methods such as Replace(), ToUpper() and ToLower() to manipulate strings.
//Also demonstrate how to use these methods to change the case of a string and replace certain characters or words in a string.

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// Using the Contains() method to check if a string contains a specific substring. 
// Using the StartsWith() and EndsWith() methods to check if a string starts or ends with a specific substring.

string songLyrics = "Twinkle, twinkle, little star, How I wonder what you are!";
Console.WriteLine(songLyrics.Contains("little"));
Console.WriteLine(songLyrics.Contains("big"));
Console.WriteLine(songLyrics.StartsWith("Twinkle"));
Console.WriteLine(songLyrics.EndsWith("!"));
Console.WriteLine(songLyrics.EndsWith("twinkle"));

// Using the IndexOf() method to find the position of a substring in a string.
// IndexOf returns the zero-based index of the first occurrence, or -1 if not found.

string message = "Hello, welcome to the world of programming!";
Console.WriteLine($"Index of 'welcome': {message.IndexOf("welcome")}");
Console.WriteLine($"Index of 'world': {message.IndexOf("world")}");
Console.WriteLine($"Index of 'xyz': {message.IndexOf("xyz")}"); // Not found, returns -1



int age =25;
Console.WriteLine("I am " +  age + " years old.");
Console.WriteLine($"I am {age} years old.");
Console.WriteLine(age);

//Day 1 comopleted. We have learned about strings, string concatenation, string interpolation, string properties and methods, and how to manipulate strings using various methods. We also learned about the Console class and how to use it for input and output operations.