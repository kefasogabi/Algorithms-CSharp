using Algorithms_DataStruct_Lib;
using System.Diagnostics.CodeAnalysis;

public class CustomersComparer : IEqualityComparer<Customer>
{
    public bool Equals(Customer? x, Customer? y) => x.Age == y.Age && x.Name == y.Name;

    public int GetHashCode( Customer obj) => obj.GetHashCode();
    
}