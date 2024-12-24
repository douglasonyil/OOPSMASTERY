//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Intrinsics.Arm;
//using System.Text;
//using System.Threading.Tasks;

//namespace CollectionProjects
//{
//    public class Student : IComparable<Student>
//    {
//        public int Studid { get; set; }
//        public string Name { get; set; }
//        public int Class { get; set; }
//        public float Marks { get; set; }

//        public int CompareTo(Student? other)
//        {
//            if (Studid > other.Studid)
//            {
//                return 1;
//            }
//            else if (Studid < other.Studid)
//            {
//                return -1;
//            }
//            else
//            {
//                return 0;
//            }
//        }
        
//        //public int CompareTo(Student? other)
//        //{
//        //    if (Marks > other.Marks)
//        //    {
//        //        return 1;
//        //    }
//        //    else if (Marks < other.Marks)
//        //    {
//        //        return -1;
//        //    }
//        //    else
//        //    {
//        //        return 0;
//        //    }
//        //}
//    }
//    class CompareStudents : IComparer<Student>
//    {
//        public int Compare(Student? x, Student? y)
//        {
//            if (x.Marks > y.Marks)
//            {
//                return -1;
//            }
//            else if (x.Marks < y.Marks)
//            {
//                return 1;
//            }
//            else
//            {
//                return 0;
//            }            
//        }
//    }

//    public class TestStudent
//    {
//        public static int CompareNames(StudentS1, StudentS2)
//        {
//            return S1.Name.CompareTo(S2.Name);
//        }
//        static void Main(string[] args)
//        {
//            Student s1 = new Student { Studid = 103, Name = "Douglas", Class = 10, Marks = 600.00f };
//            Student s2 = new Student { Studid = 106, Name = "Onyil", Class = 10, Marks = 575.00f };
//            Student s3 = new Student { Studid = 105, Name = "Ogutu", Class = 10, Marks = 700.00f };
//            Student s4 = new Student { Studid = 102, Name = "Mercy", Class = 10, Marks = 455.00f };
//            Student s5 = new Student { Studid = 107, Name = "Ojala", Class = 10, Marks = 510.00f };
//            Student s6 = new Student { Studid = 101, Name = "Obwana", Class = 10, Marks = 490.00f };

//            List<Student> students = new List<Student> { s1, s2, s3, s4, s5, s6 };

//            CompareStudents cs = new CompareStudents();

//            Comparison<Student> obj = new Comparison<Student>(CompareNames);
//            students.Sort(obj);

//            //students.Sort();

//            //students.Sort(cs);

//            students.Sort();

//            //students.Sort(1, 5, cs);

//            foreach (Student s in students)
//            {
//                Console.WriteLine(s.Studid + " " + s.Name + " " + s.Class + " " + s.Marks);
//            }

//        }
//    }
//}
