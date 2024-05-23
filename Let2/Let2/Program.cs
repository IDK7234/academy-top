using System;
using System.Runtime.Versioning;
using static System.Console;

namespace Hell
{
    public abstract class Human
    {
        string first_name, last_name;
        DateTime date;
        public Human() { }

        public Human(string fname, string lname, DateTime d) { }
        public virtual void Show()
        {
            WriteLine($"Фамилия {last_name}, Имя {first_name}, Дата рождения {date.ToShortDateString()}");
        }
        public abstract void Think();
    }

    public abstract class Learner : Human
    {
        string institution;

        protected Learner(string fname, string lname, DateTime d, string institution) : base(fname, lname, d)
        {
        }
        public Learner() { }
        public abstract void Study();

        public virtual void Show()
        {
            base.Show();
            WriteLine($"Institution {institution}");
        }
    }

    public class Student : Learner
    {
        string groupname;
        public Student(string fname, string lname, DateTime d, string institution, string groupname) : base(fname, lname, d, institution)
        {
        }
        public Student() { }

        public override void Study()
        {
            WriteLine("I study");
        }

        public override void Think()
        {
            WriteLine("I think like student");
        }
        public void Show()
        {
            base.Show();
            WriteLine($"Group name {groupname}");
        }
    }

    public class SchoolChild : Learner
    {
        public SchoolChild(string fname, string lname, DateTime d, string institution) : base(fname, lname, d, institution)
        {
        }
        public SchoolChild() { }
        public override void Show()
        {
            base.Show();
            WriteLine($"I'm school child");
        }

        public override void Study()
        {
            WriteLine("Am i studying?");
        }

        public override void Think()
        {
            WriteLine("I think like child");
        }
    }

    class Pupil : Learner
    {
        public Pupil(string fname, string lname, DateTime d, string institution) : base(fname, lname, d, institution)
        {
        }
        public Pupil() { }

        public override void Show()
        {
            base.Show();
            WriteLine("Help pls");
        }

        public override void Study()
        {
            WriteLine("Who?");
        }

        public override void Think()
        {
            WriteLine("What?");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Learner[] arr = { new Student(), new SchoolChild(), new Pupil() };
            foreach (Learner item in arr)
            {
                try
                {
                    ((Student)item).Show();
                }
                catch
                {

                }

                if (item is SchoolChild)
                {
                    ((SchoolChild)item).Show();
                }

                Pupil a = item as Pupil;
                if (a != null)
                {
                    a.Show();
                }
            }
        }
    }
}