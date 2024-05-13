using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_And_Algorithms.DataStructures.Basic
{
    public class BasicNode<T>
    {
        public T Value { get; set; }

        public BasicNode(T value) 
        {
            Value = value;
        }
    }
}
