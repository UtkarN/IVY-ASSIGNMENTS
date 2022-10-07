using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_04
{

    public class people
    {
        string book_name;

        public void set_book(string book)
        {
            this.book_name = book;
            Console.WriteLine(book_name);
        }


    }

    public class student : people
    {


        public void take_book()
        {

            Console.WriteLine("Student is taking a book for one day from Librarian");

        }
        public void give_aatendance()
        {
            Console.WriteLine("Present Teacher(Sir/Ma'am)");
        }
        public void attend_class()
        {
            Console.WriteLine("I am attending class\n\n");
        }
    }
    public class teacher : people
    {
        public void take_book(string book1)
        {
            Console.WriteLine("Teacher is takeing a book for maore days than student from Librarian");
            set_book(book1);
        }
        public void take_attendance()
        {
            Console.WriteLine("I am taking Attendance");
        }
        public void take_class()
        {
            Console.WriteLine("I am taking Class\n\n");
        }

    }

    public class librarian : people
    {
        /*The librarian can allot a book
         give attendance*/
        public void allot_book()
        {
            Console.WriteLine("Librarian allot the book");
            set_book("C# programming");
        }
        public void give_attendance(string name)
        {
            Console.WriteLine("Librarian is giving Attendance\n\n");
        }
    }


    internal class University
    {
        static void Main(string[] args)
        {
            student s = new student();

            s.take_book();
            s.set_book("C# programming");
            s.give_aatendance();
            s.attend_class();


            teacher t = new teacher();

            t.take_book("C# programming");

            t.take_attendance();
            t.take_class();

            librarian l = new librarian();

            l.allot_book();

            l.give_attendance("Student");

        }
    }
}
