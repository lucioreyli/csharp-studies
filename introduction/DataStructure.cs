using System.Collections.Generic;
using static System.Console;

namespace DataStructure
{
    class ArrayExample
    {
        public void Init()
        {
            int[] x = new int[3];
            x[0] = 5;
            x[1] = 10;
            x[2] = 15;
            WriteLine(x[1]);

            string[] names = new string[2];
            names[0] = "Jé";
            names[1] = "Law";

            string[] weeks = new string[] {
        "Dom",
        "Seg",
        "Ter",
        "Qua",
        "Qui",
        "Sex",
        "Sáb"
      };
        }
    }

    class StackExample
    {
        public void Init()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(4);
            stack.Push(6);
            stack.Push(8);
            stack.Push(10);
            WriteLine(stack.ToArray().GetValue(4));
            WriteLine($"The stack have {stack.Count} items.");

            stack.Pop();
            WriteLine(stack.Peek());
            WriteLine($"The stack have {stack.Count} items.");

            stack.Clear();
            WriteLine($"The stack have {stack.Count} items.");
        }
    }

    class QueueExample
    {
        public void Init()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Hi!");
            queue.Enqueue("New item");
            queue.Enqueue("Another item");
            WriteLine($"The item {queue.Dequeue()} has been removed.");
            WriteLine($"The queue have {queue.Count} items.");
        }
    }

    class TupleExample
    {
        public void Init()
        {
            (string name, int age) person = ("Filipe", 16);
            WriteLine(person);
        }
    }
}
