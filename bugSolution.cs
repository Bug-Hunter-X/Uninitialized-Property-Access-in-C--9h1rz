public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property with a default value

    public void MyMethod()
    {
        // Accessing a property that has been initialized
        int value = MyProperty + 10;
    }
}