# Decision logic challenge

In this challenge, you implement decision logic based on a series of business rules. The business rules specify the access that is granted to users based on their role-based permissions and their career level. Code branches display a different message to the user depending on their permissions and level.

Here are the Business Rules that your solution must satisfy:

- If the user is an Admin with a level greater than 55, output the message:

```Plain Text
Welcome, Super Admin user.
```

- If the user is an Admin with a level less than or equal to 55, output the message:

```Plain Text
Welcome, Admin user.
```

- If the user is a Manager with a level 20 or greater, output the message:

```Plain Text
Contact an Admin for access.
```

- If the user is a Manager with a level less than 20, output the message:

```Plain Text
You do not have sufficient privileges.
```

- If the user isn't an Admin or a Manager, output the message:

```Plain Text
You do not have sufficient privileges.
```

Update your Program.cs code to accommodate each of the business rules.

## Test your solution using the initial data values suggested

Build and run your code.

Evaluate the output.

When you run your code, including the initial configuration data, you should see the following output:

```Plain Text
Welcome, Admin user.
```

- Test for the other business rules

- Update the values assigned to permission and level.

- Save and run your code.

- Evaluate the output to verify that the other business rules are satisfied.
