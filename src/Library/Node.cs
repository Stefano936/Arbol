﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        public Person person;

        private List<Node> children = new List<Node>();

        public ReadOnlyCollection<Node> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }
        public bool IsLeaf
        {
            get { return Children.Count == 0; }
        }

        public Node(Person person)
        {
            this.person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
