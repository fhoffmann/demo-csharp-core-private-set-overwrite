# demo-csharp-core-private-set-overwrite
How to set a value to a private property

```c#
var objA = new Data("Hello", "World!");
Console.WriteLine(objA);
//Hello World!

// set is private. Not allowed
//objA.ValueB = "Germany!"; // CS0272

// Get the type
var type = objA.GetType();
//var type = typeof(Data); // alternative

// Get the property and set the value
var prop = type.GetProperty("ValueB");
prop.SetValue(objA, "Germany");

Console.WriteLine(objA);
//Hello Germany
```
[Code](PrivateSetOverwriteTest/Program.cs)
