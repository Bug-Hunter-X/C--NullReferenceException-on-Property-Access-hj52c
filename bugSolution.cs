public class ExampleClass
{
    public int? MyProperty { get; set; } // Now nullable

    public void MyMethod()
    {
        // Check for null before accessing the property
        if (MyProperty.HasValue)
        {
            Console.WriteLine(MyProperty.Value.ToString());
        }
        else
        {
            Console.WriteLine("MyProperty is null");
        }

        //Alternative using null-conditional operator
        Console.WriteLine(MyProperty?.ToString() ?? "MyProperty is null"); 
    }
}