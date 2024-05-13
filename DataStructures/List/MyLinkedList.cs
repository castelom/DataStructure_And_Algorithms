using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_And_Algorithms.DataStructures.List
{
    public class MyLinkedList<T>
    {
        public T? value;
        public MyLinkedList<T>? next;
        public MyLinkedList<T>? head;
        
        private int count;
        
        public MyLinkedList()
        {
            next = null;
            count = 0;
            head = null;
        }

        public MyLinkedList(T value)
        {
            next = null;
            count = 0;
            this.value = value;
            head = null;
        }

        public void push(T value)
        {
            MyLinkedList<T> node = new MyLinkedList<T>(value);
            MyLinkedList<T> current;
            if (this.head == null) 
            {
                this.head = node;
            }//List Empty
            else
            {
                current = this.head;
                while(current.next != null) 
                {
                    current = current.next;
                }

                current.next = node;
            }
            this.count++;
        }

        public T RemoveAt(int index)
        {
            if(index >= 0 && index < this.count)
            {
                MyLinkedList<T> current = this.head;
                if(index == 0)
                {
                    this.head = this.head.next;
                }
                else
                {
                    MyLinkedList<T> previous = current;
                    for(int i = 0; i < index; i++)
                    {
                        previous = current;
                        current = current.next;
                    }

                    previous.next = current.next;
                }

                this.count--;
                return current.value;
            }
            return default(T);
        }
    }
}
