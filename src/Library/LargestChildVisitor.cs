using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Library;

public class LargestChildVisitor : Visitor
{
    public Node LargestChild { get; private set; }
    public int LargestAge { get; private set; }

    public override void Visit(Node node)
    {
        if (node.IsLeaf && node.person != null) // Cambiar node.IsLeaf() a node.IsLeaf y node.person a node.Person
        {
            int age = node.person.Age;
            if (LargestChild == null || age > LargestAge)
            {
                LargestChild = node;
                LargestAge = age;
            }
        }

        foreach (Node child in node.Children)
        {
            Visit(child);
        }
    }
}
