using DataStructure_And_Algorithms.DataStructures.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_And_Algorithms.DataStructures.List
{
    public class MyLinkedList<T> where T : IComparable<T>
    {
        private LinkedNode<T>? Head { get; set; }
        private int count;
        
        public MyLinkedList()
        {
            count = 0;
        }

        public MyLinkedList(T value)
        {
            count = 0;
            Head = new LinkedNode<T>(value);  
        }

        public LinkedNode<T> getHead()
        {
            return Head;
        }

        public bool isEmpty()
        {
            return this.count == 0;
        }

        public int size()
        {
            return this.count;
        }

        public void push(T value)
        {
            LinkedNode<T> node = new LinkedNode<T>(value);
            LinkedNode<T> current;
            if (Head == null) 
            {
                Head = node;
            }//List Empty
            else
            {
                current = Head;
                while(current.next != null) 
                {
                    current = current.next;
                }

                current.next = node;
            }
            this.count++;
        }

        public LinkedNode<T> getElementAt(int index)
        {
            if (index >= 0 && index < this.count)
            {
                LinkedNode<T> current = Head;
                for (int i = 0; i < index; i++)
                {
                    current = current.next;
                }

                return current;
            }
            else
            {
                return null;
            }
        }

        public int indexOf(T value)
        {
            LinkedNode<T> current = Head;
            for (int i = 0; i < this.count; i++)
            {
                if (current.Value.CompareTo(value) == 0)
                {
                    return i;
                }
                current = current.next;
            }
            return -1;
        }

        public LinkedNode<T> RemoveAt(int index)
        {
            if(index >= 0 && index < this.count)
            {
                LinkedNode<T> current = Head;
                if(index == 0)
                {
                    Head = Head.next;
                }
                else
                {
                    LinkedNode<T> previous = getElementAt(index-1);
                    current = previous.next;
                    previous.next = current.next;
                }

                this.count--;
                return current;
            }
            return null;
        }

        public LinkedNode<T> RemoveElem(T value)
        {
            LinkedNode<T> current = Head;
            int index = indexOf(value);

            if (index >= 0)
            {
                LinkedNode<T> removedItem = RemoveAt(index);
                return removedItem;
            }

            return null;
        }

        public bool InsertAt(int index, T value)
        {
            LinkedNode<T> node = new LinkedNode<T>(value);
            if(index == 0)
            {
                node.next = Head;
                Head = node;
            }
            else if (index >= 0 && index < this.count)
            {
                LinkedNode<T> previous = getElementAt(index-1);
                node.next = previous.next;
                previous.next = node;
                
            }
            else
            { 
                return false;
            }
            this.count++;
            return true;
        }

        

        
    }
}
