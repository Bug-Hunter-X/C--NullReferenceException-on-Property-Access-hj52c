# C# NullReferenceException Example

This repository demonstrates a common C# error: a `NullReferenceException` that occurs when attempting to access a property of an object that is currently null.  The example shows how to reproduce this error and how to properly handle it.

**Problem:** The `MyProperty` in `ExampleClass` isn't initialized, and directly accessing `MyProperty.ToString()` can lead to a `NullReferenceException`. 

**Solution:** Implement null checks to prevent the exception. Various approaches are shown in `bugSolution.cs`.