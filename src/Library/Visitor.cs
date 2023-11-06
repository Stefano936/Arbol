using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Library;
using System.Text;

public abstract class Visitor
{
    public abstract void Visit(Node node);

    public string Content
    {
        get
        {
            return this.ContentBuilder.ToString();
        }
    }
    protected StringBuilder ContentBuilder { get; } = new StringBuilder();
}
