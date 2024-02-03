using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    internal class ToDo
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();
            string retry = "no";

            do
            {
            Console.WriteLine("What do you want to do?\n[S]ee all todos\n[A]dd a todo\n[R]emove a todo\n[E]xit");
            string selectedOption = Console.ReadLine().ToLower();

                switch (selectedOption)
                {
                    case "s":
                        if(todoList.Count > 0)
                        {
                            int index = 1;
                            foreach (string item in todoList)
                            {
                                Console.WriteLine(index + ". " + item);
                                index++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("List is empty!\n");
                        }
                        break;
                    case "a":
                        Console.WriteLine("Todo name: ");
                        todoList.Add(Console.ReadLine());
                        break;
                    case "r":
                        Console.WriteLine("Todo name: ");
                        string todoToRemove = Console.ReadLine();

                        if (todoList.Contains(todoToRemove))
                        {
                            todoList.Remove(todoToRemove);
                            Console.WriteLine("Todo deleted: \n" + todoToRemove);
                        }
                        else
                        {
                            Console.WriteLine("That todo doesn't exist\n");
                        }
                        break;
                    case "e":
                        retry = Console.ReadLine();
                        break;
                }
            } while (retry == "no");
        }
    }
}
