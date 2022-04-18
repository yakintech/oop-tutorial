using System;


namespace CSharpOOP.Models
{
    //Category BaseModel den miras aldı. Böylelikle BaseModel de bulunan herşey category e geçti. Inheritance prensibi => OOP nin Inheritance
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
