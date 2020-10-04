using System;

namespace oop_6115261027_w06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Yeri", " ", 35000, "Lecturer");
            Person p2 = new Person("Wendy", "", 35000, "Lecturer");
            Person p3 = new Person("Iren", "", 25000, "Staff");
            Faculty f1 = new Faculty("Faculty of Educational");
            f1.setPerson(p1, 0);
            f1.setPerson(p2, 1);
            f1.setPerson(p3, 2);
            f1.printAll();
        }
    }
}
