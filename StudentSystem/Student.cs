using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Student
    {
        int id, studentClass, subject1, subject2, subject3;
        string name, grp;

        public Student(int Id, string Name, int StudentClass, string Grp, int Subject1, int Subject2, int Subject3)
        {
            this.Id = Id;
            this.Name = Name;
            this.StudentClass = StudentClass;
            this.Grp = Grp;
            this.Subject1 = Subject1;
            this.Subject2 = Subject2;
            this.Subject3 = Subject3;
        }

        public string Grp
        {
            get
            {
                return grp;
            }

            set
            {
                grp = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int StudentClass
        {
            get
            {
                return studentClass;
            }

            set
            {
                studentClass = value;
            }
        }

        public int Subject1
        {
            get
            {
                return subject1;
            }

            set
            {
                subject1 = value;
            }
        }

        public int Subject2
        {
            get
            {
                return subject2;
            }

            set
            {
                subject2 = value;
            }
        }

        public int Subject3
        {
            get
            {
                return subject3;
            }

            set
            {
                subject3 = value;
            }
        }
    }
}
