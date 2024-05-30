using System;
using System.Collections.Generic;

public class Virus : ICloneable
{
    public double Weight { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus(double weight, int age, string name, string species)
    {
        Weight = weight;
        Age = age;
        Name = name;
        Species = species;
    }

    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    public object Clone()
    {
        Virus clone = (Virus)this.MemberwiseClone();
        clone.Children = new List<Virus>();
        foreach (var child in Children)
        {
            clone.Children.Add((Virus)child.Clone());
        }
        return clone;
    }

    public void PrintInfo(string indent = "")
    {
        Console.WriteLine($"{indent}Virus: {Name}, Species: {Species}, Age: {Age}, Weight: {Weight}");
        foreach (var child in Children)
        {
            child.PrintInfo(indent + "  ");
        }
    }
}
