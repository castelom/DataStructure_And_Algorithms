using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_And_Algorithms.DataStructures.Basic
{
    public class LinkedNode<T> : BasicNode<T>
    {
        public LinkedNode<T>? next;

        public LinkedNode(T value) : base(value) { }
    }
}
