# Uninitialized Property Access in C#

This example demonstrates an uncommon but potentially problematic code error in C#: accessing a class property before it's been explicitly initialized.  While many developers quickly catch this, especially with simple examples, it can be insidious in larger programs or when dealing with complex object relationships.

The `bug.cs` file shows the code with the error.  `bugSolution.cs` provides the fix.

## Reproducing the Bug

1. Compile and run `bug.cs`.
2. Observe the `NullReferenceException`.