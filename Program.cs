using System;
using System.Linq;
using System.Collections.Generic;


namespace FinalTask_Module_15
{
    /// <summary>
    /// Список студентов в одном классе
    /// </summary>
    public class Classroom
    {
        public List<string> Students = new List<string>();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

            var allStudents = GetAllStudents(classes);
            
            Console.WriteLine(string.Join(" ", allStudents));
        }

        /// <summary>
        /// Добавляет учихся из всех классов в один список
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        static string[] GetAllStudents(Classroom[] classes)
        {
            var allStudents = (from c in classes
                              from s in c.Students
                              select s).ToArray();
            return allStudents;
        }


    }
    
}
