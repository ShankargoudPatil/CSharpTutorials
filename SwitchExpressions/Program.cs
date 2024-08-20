//A switch statement is a type of selection control mechanism used to allow the value of a variable
//or expression to change the control flow of program execution via search and map.


string dayOfWeek = "Sunday";

// #Switch statement
Console.WriteLine("Switch statement-------");

switch (dayOfWeek)
{
    case "Monday":
        Console.WriteLine("It's the start of the week.");
        break;
    case "Friday":
        Console.WriteLine("It's the end of the week.");
        break;
    case "Sunday":
        Console.WriteLine("It's the weekend.");
        break;
    default:
        Console.WriteLine("It's a weekday.");
        break;
}


// #Switch expression
Console.WriteLine("Switch expression------");

string message = dayOfWeek switch
{
    "Monday" => "It's the start of the week.",
    "Friday" => "It's the end of the week.",
    "Sunday" => "It's the weekend.",
    _ => "It's a weekday."
};

Console.WriteLine(message);

//#Switch expression with conditions
int number = 15;

switch (number)
{
    case var n when n < 0:
        Console.WriteLine("The number is negative.");
        break;
    case var n when n >= 0 && n <= 10:
        Console.WriteLine("The number is between 0 and 10.");
        break;
    case var n when n > 10:
        Console.WriteLine("The number is greater than 10.");
        break;
    default:
        Console.WriteLine("The number is not defined.");
        break;
}

// # Switch expression with conditions
string message1 = number switch
{
    var n when n < 0 => "The number is negative.",
    var n when n >= 0 && n <= 10 => "The number is between 0 and 10.",
    var n when n > 10 => "The number is greater than 10.",
    _ => "The number is not defined."
};

Console.WriteLine(message1);


