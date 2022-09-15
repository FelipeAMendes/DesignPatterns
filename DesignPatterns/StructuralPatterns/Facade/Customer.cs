﻿namespace DesignPatterns.StructuralPatterns.Facade;

// Customer class
public class Customer
{
    public Customer(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
