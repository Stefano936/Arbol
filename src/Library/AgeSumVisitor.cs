using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Library;

public class AgeSumVisitor : Visitor
{
    public int age {get; set; }
    public override void Visit(Node node)
    {
        if (node.person != null)
        {
            age += node.person.GetEdad();
        }
        foreach(var child in node.Children)
        {
            child.Accept(this);
        }
        this.ContentBuilder.Clear();
        this.ContentBuilder.Append(age);
    }
}
