public class ExampleClass
{
    public int MyProperty { get; set; } = 0; //Initialize to 0

    public string MyStringProperty { get; set; } = ""; //Initialize to empty string

    public void MyMethod()
    {
        int value = MyProperty; // Now safe
        string str = MyStringProperty.ToUpper();//Now safe
    }
}