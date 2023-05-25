using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupExercise
{
    internal class Program
    {
        static string[] todoList = new string[5];
        static int count = 0;

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("===== TODO LIST =====");
                Console.WriteLine("1. Add Todo");
                Console.WriteLine("2. View Todo List");
                Console.WriteLine("3. Clear Todo List");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTodo();
                        break;
                    case 2:
                        ViewTodoList();
                        break;
                    case 3:
                        ClearTodoList();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddTodo()
        {
            if (count >= todoList.Length)
            {
                Console.WriteLine("Todo list is full!");
                return;
            }

            Console.Write("Enter a new todo: ");
            string todo = Console.ReadLine();

            todoList[count] = todo;
            count++;

            Console.WriteLine("Todo added successfully!");
        }

        static void ViewTodoList()
        {
            if (count == 0)
            {
                Console.WriteLine("Todo list is empty!");
                return;
            }

            Console.WriteLine("===== TODO LIST =====");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
            Console.WriteLine("======================");
        }

        static void ClearTodoList()
        {
            Array.Clear(todoList, 0, count);
            count = 0;
            Console.WriteLine("Todo list cleared!");
        }
    }
}
