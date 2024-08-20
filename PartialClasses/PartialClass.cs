namespace PartialClasses;

public partial class PartialClass
{
    public void Method1()
    {
        Console.WriteLine("Method1 from 1st PartialClass");
    }
}

public partial class PartialClass
{
    public void Method2()
    {
        Console.WriteLine("Method2 from 2nd PartialClass");
    }
}

// # Partial classes provides us an option to split classes into multiple parts and in multiple source files.
// # All parts are combined into one single class during compile time.
// # All parts should contain the keyword partial, should be of the same accessibility.
// # All parts should be present in the same assembly for it to be included during compile time


//Partial classes inheriting from a base class
//When inheriting from any base class, only one partial class needs to have the base class specified.
public class BaseClass
{
    public void Method1()
    {
        Console.WriteLine("Method1 from BaseClass");
    }
}
public partial class PartialClass : BaseClass
{

}
//  # You can specify the same base class in more than one partial class. It will get flagged as redundant by some IDE
//tools, but it does compile correctly
//  # You cannot specify different base classes in multiple partial classes, it will result in a compiler error
public partial class PartialClass : BaseClass { }
