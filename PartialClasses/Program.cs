// See https://aka.ms/new-console-template for more information

using System.IO;
using PartialClasses;

/* you can split the implementation of a class, a struct, a method, or an interface in multiple .cs 
  files using the partial keyword. The compiler will combine all the implementation 
  from multiple .cs files when the program is compiled. */


var employee = new Employee();

Console.WriteLine("Employee Id: {0}", employee.GenerateEmployeeId());

Console.WriteLine("Employee FullName: {0}", employee.GetEmployeeDetails());

//Rules for Partial Classes
/*
* All the partial class definitions must be in the same assembly and namespace.
* All the parts must have the same accessibility like public or private, etc.
* If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
* Different parts can have different base types and so the final class will inherit all the base types.
* The Partial modifier can only appear immediately before the keywords class, struct, or interface.
  Nested partial types are allowed.

//Rules for Partial Methods

 * Partial methods can have in or ref but not out parameters.
 * Partial methods are implicitly private methods, so cannot be virtual.
 * Partial methods can be static methods.
 * Partial methods can be generic.
*/

PartialClass partialClass = new PartialClass();
partialClass.Method1();
partialClass.Method2();
