using System;

namespace LatihanInheritanceReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("David", 17);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Linda", 27, 160201, "Guru TIK");
            teacher.GetNameAndAge();

            Student student = new Student("Tasya", 17, 19051, "tasyaunyu@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
