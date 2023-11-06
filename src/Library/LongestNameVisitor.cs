using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Library;

public class LongestNameVisitor : Visitor
{
    public string LongestName { get; private set; }
    public int LongestNameLength { get; private set; }

    public override void Visit(Node node)
    {
        if (node.person != null)
        {
            string name = node.person.GetNombre();
            int nameLength = name.Length;
            
            if (LongestName == null || nameLength > LongestNameLength)
            {
                LongestName = name;
                LongestNameLength = nameLength;
            }
        }

        foreach (Node child in node.Children)
        {
            Visit(child);
        }
    }
}

