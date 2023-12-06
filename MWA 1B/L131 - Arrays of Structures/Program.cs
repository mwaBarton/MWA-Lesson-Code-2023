using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L131___Arrays_of_Structures
{
    internal class Program
    {
        struct Lesson
        {
            public string teacher, room;
            public string[] students;
        }

        static Lesson InputLesson()
        {
            Lesson result;

            Console.Write("Enter teacher name: ");
            result.teacher = Console.ReadLine();
            Console.Write("Enter room number: ");
            result.room = Console.ReadLine();

            Console.Write("How many students in the lesson? ");
            int numStudents;
            while (!int.TryParse(Console.ReadLine(), out numStudents))
            {
                Console.Write("How many students in the lesson? ");
            }

            result.students = new string[numStudents];
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter name for student {i}: ");
                result.students[i] = Console.ReadLine();
            }

            return result;
        }

        static void PrintLesson(Lesson l)
        {
            Console.WriteLine(l.teacher);
            Console.WriteLine(l.room);
            Console.WriteLine("Students:");
            foreach (string s in l.students)
            {
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            //Q2.
            //Create a structure for a lesson: needs an array of people(students),
            //a teacher, a room number and a course.Set up a structure for this lesson!

            Lesson l = InputLesson();

            PrintLesson(l);

            Console.ReadKey();
        }
    }
}
