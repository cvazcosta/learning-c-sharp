# Code project 1 - write code that validates integer input

Here are the conditions that your first coding project must implement:

- Your solution must include either a do-while or while iteration.

- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

- Inside the iteration block:

  - Your solution must use a Console.ReadLine() statement to obtain input from the user.

  - Your solution must ensure that the input is a valid representation of an integer.

  - If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

  - Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.

- Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

## Sample code to help out

When using a Console.ReadLine() statement to obtain user input, it's common practice to use a nullable type string (designated string?) for the input variable and then evaluate the value entered by the user. The following code sample uses a nullable type string to capture user input. The iteration continues while the user-supplied value is null:

```C#
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
```

The Boolean expression evaluated by the while statement can be used to ensure user input meets a specified requirement. For example, if a prompt asks the user to enter a string that includes at least three characters, the following code could be used:

```C#
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
```

If you want to use Console.ReadLine() input for numeric values, you need to convert the string value to a numeric type.

The int.TryParse() method can be used to convert a string value to an integer. The method uses two parameters, a string that will be evaluated and the name of an integer variable that will be assigned a value. The method returns a Boolean value. The following code sample demonstrates using the int.TryParse() method:

```C#
// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
```

If the string value assigned to readResult represents a valid integer, the value will be assigned to the integer variable named numericValue, and true will be assigned to the Boolean variable named validNumber. If the value assigned to readResult doesn't represent a valid integer, validNumber will be assigned a value of false. For example, if readResult is equal to "7", the value 7 will be assigned to numericValue.
