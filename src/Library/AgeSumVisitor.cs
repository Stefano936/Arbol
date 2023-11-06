using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Library;

public class AgeSumVisitor : Visitor
{
    public int TotalAge { get; private set; }

    public override void Visit(Node node)
    {
        if (node.person != null)
        {
            TotalAge += node.person.Age;
        }

        foreach (Node child in node.Children)
        {
            Visit(child);
        }
    }
}
