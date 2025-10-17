# Tasks

In this exercise, you review the code in the Starter project, perform some code clean-up tasks, and then start adding features to your application. The tasks that you complete during this exercise are:

1. Code review: review the contents of the Program.cs file.
2. Sample data: convert the if-elseif-else structure to switch-case structure that improves readability.
3. Menu loop: enclose the main menu and menu item selection in a loop that iterates until the user enters "exit".
4. Menu selections: write the code for a switch-case structure that establishes separate code branches for each menu option.
5. Code branches: write placeholder within the menu item branches that provides user feedback until app features are developed.
6. Verification test: perform verification tests for the code that you develop in this exercise.

## Review the contents of the Program.cs file

In this task, you complete a walkthrough of the Starter project code. The Program.cs file contains a preliminary version of the application that you update during this module. The existing code generates sample data for the application and displays a list of menu options. The menu options represent the main features of your application.

1. Ensure that the GuidedProject folder is open in Visual Studio Code.

    The previous unit includes a Setup section that describes how to open the Starter project. If necessary, go back and follow the Setup instructions.

2. In the EXPLORER view, expand the Starter folder, then select Program.cs.

    When you select the Program.cs file, the file contents open in the Visual Studio Code Editor.

    If the EXPLORER view isn't open, select EXPLORER from the Visual Studio Code Activity Bar. The EXPLORER button is at the top of the Activity Bar.

3. Take a few minutes to review the code in the Program.cs file.

4. Notice that the top portion of your code begins with some variable declarations.

    ```C#
    // the ourAnimals array will store the following: 
    string animalSpecies = "";
    string animalID = "";
    string animalAge = "";
    string animalPhysicalDescription = "";
    string animalPersonalityDescription = "";
    string animalNickname = "";

    // variables that support data entry
    int maxPets = 8;
    string? readResult;
    string menuSelection = "";

    // array used to store runtime data, there is no persisted data
    string[,] ourAnimals = new string[maxPets, 6];
    ```

    At the top of the file, you see a comment line and a list of variables. These variables, animalSpecies through animalNickname, are used to hold the values of the pet characteristics. Later in the code you assign the characteristic values to a multidimensional string array named ourAnimals. Each of these variables is initialized to contain a zero length string "". The ourAnimals array is declared a little further down in the code.

    The next group of variables is a mix of string and int variables that you'll use to generate sample data, read user input, and establish exit criteria for your main program loop. You may have noticed the code line string? readResult;. When used in a variable declaration like this, the ? character defines a nullable type variable. When reading user entered values with the Console.ReadLine() method, it's best to use a nullable type.

    The final variable is a two-dimensional string array named ourAnimals. Since you're instantiating the array without initializing any values, you use the new operator (the new operator is used to create a new instance of a type). The number of rows is defined by maxPets, which has been initialized to eight. The number of characteristics that you're storing is six, the string variables that you examined above.

5. Scroll down to examine the for loop that contains an if-elseif-else selection construct.

6. Notice that the for loop uses the maxPets variable to establish an upper bound on the number of iterations.

7. Notice that the if-elseif-else construct selectively branches your code based on pet characteristics.

    The if-elseif-else construct is used to define different values for the first four iterations of the for loop. After the fourth iteration, all characteristics are assigned an empty, or zero-length, string.

    The values of the animal characteristic variables are assigned to the ourAnimals array at the bottom of the for loop.

8. Scroll to the bottom of the code file, and then examine the code that's used to display the menu options and read the user selection.

9. Notice that you assign the value returned by the Console.ReadLine() method to the nullable string readResult.

    Using a nullable string is best practice for capturing input from the ReadLine() method. Once you verify that the input value isn't null, you assign the value to a standard string variable named menuSelection. This process enables you to evaluate the menu selection value without a concern for null values. Many of the methods that accept strings as an input parameter will generate an error if they're passed a null value. If you don't follow this input pattern, the code compiler is likely to generate a warning when you build your project.

    The final lines of the Program.cs file echo the menu option selection and then pause execution until the Enter key is pressed.

---
