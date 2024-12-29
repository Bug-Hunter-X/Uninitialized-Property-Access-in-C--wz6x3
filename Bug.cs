public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a non-initialized property will result in the default value (0 for int)
        int value = MyProperty; //value will be 0

        //However, this will still throw a NullReferenceException if MyProperty is a reference type
        //e.g.  public string MyStringProperty {get; set;}
        //string str = MyStringProperty.ToUpper();//This throws an exception
    }
}