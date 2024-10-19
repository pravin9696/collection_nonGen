using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_nonGen.Assignment
{
    class student
    {
        public int roll { get; set; }
        public string name { get; set; }
    }
    internal class Assignment01
    {
        public void method2()
        {
            student s1 = new student() { roll = 1, name = "AAAA" };
            student s2 = new student() { roll = 2, name = "BBB" };
            student s3 = new student() { roll = 3, name = "CCC" };
            ArrayList studArList = new ArrayList() { s1, s2, s3 };

            Hashtable college = new Hashtable();
            college.Add("FE", studArList);

            student s4 = new student() { roll = 4, name = "dd" };
            student s5 = new student() { roll = 5, name = "ee" };
            student s6 = new student() { roll = 6, name = "ff" };
            ArrayList studArList2 = new ArrayList() { s4, s5, s6 };
            college.Add("SE", studArList2);
            bool flag = false;
            string ky;
            Console.WriteLine("Enter key to search student");
            ky = Console.ReadLine();

            foreach (var item in college)
            {
                DictionaryEntry t = (DictionaryEntry)item;
                if (string.Compare(ky,t.Key.ToString())==0)//ky FE   t.key  SE
                {
                    flag = true;
                    ArrayList temp = (ArrayList)t.Value;
                    foreach (var ss in temp)
                    {
                        student tt1 = (student)ss;
                        Console.WriteLine(tt1.roll+" "+tt1.name);
                    }
                    break;
                }
            }
            if (flag==false)
            {
                Console.WriteLine("key not found!!!");
            }
            
        }
        public void method1()
        {
            student s1=new student() { roll=1,name="AAAA"};
            student s2 = new student() { roll = 2, name = "BBB" };
            student s3 = new student() { roll = 3, name = "CCC" };
            ArrayList studArList = new ArrayList() { s1,s2,s3};

            Hashtable college = new Hashtable();
            college.Add("FE",studArList);

            student s4 = new student() { roll = 4, name = "dd" };
            student s5 = new student() { roll = 5, name = "ee" };
            student s6 = new student() { roll = 6, name = "ff" };
            ArrayList studArList2 = new ArrayList() { s4, s5, s6 };
            college.Add("SE", studArList2);

            int roll;
            Console.WriteLine("Enter roll no to search student");
            roll = int.Parse(Console.ReadLine());
            bool flag = false;
            foreach (var item in college)
            {
                DictionaryEntry temp1 = (DictionaryEntry)item;
                ArrayList tt = (ArrayList)temp1.Value;

                foreach (var s in tt)
                {
                    student ss = (student)s;
                    if (ss.roll==roll)
                    {
                        flag = true;
                        Console.WriteLine(ss.roll+" "+ss.name);
                        Console.WriteLine("Key:"+temp1.Key);
                        break;
                    }
                }
                if (flag==true)
                {
                    break;
                }

            }
            if (flag==false)
            {
                Console.WriteLine("Record not found!!!");
            }
        }
    }
}
