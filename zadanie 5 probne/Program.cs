using System;

namespace zadanie_5_probne
{
    public class Root
    {
        public int data;
        public Root next;
    }
    public class Lista
    {
        public Root head, tail;

        public bool IsEmpty()
        {
            if (head == null)
                return true;
            else
                return false;
        }
        public void Add2List(int n)
        {
            Root w = new Root();
            w.data = n;
            if(IsEmpty())
            {
                head = w;
                tail = w;
            }
            else
            {
                w.next = head;
                head = w;
            }
        }

        public void Disp()
        {
            while(head!=null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lista l1 = new Lista();
            l1.Add2List(12);
            l1.Add2List(10);
            l1.Add2List(3);
            l1.Add2List(2);
            l1.Add2List(6);
            l1.Add2List(7);
            
            l1.Disp();
        }
    }
}
