using System.Collections;
using System.Reflection.PortableExecutable;
class comparebySalary : IComparer
{
    public int Compare(object? x, object? y)
    {
        emp t1= x as emp;
        emp t2= y as emp;
        if (t1.salary > t2.salary) return 1;
        else if (t1.salary < t2.salary) return -1;
        else return 0;
        
    }
}
class comparebyname : IComparer
{
    public int Compare(object? x, object? y)
    {
        emp t1 = x as emp;
        emp t2 = y as emp;
        return string.Compare(t1.name, t2.name);
    }
}
class emp:IComparable
{
    public int id { get; set; }
    public string name { get; set; }
    public int salary { get; set; }

    public int CompareTo(object? obj)
    {
        emp temp=obj as emp;

        //if (this.id > temp.id)
        //{
        //    return 1;
        //}
        //else if (this.id < temp.id) 
        //{
        //    return - 1; 
        //}
        //else
        //{
        //    return 0;
        //}
      return  string.Compare(this.name, temp.name);
    }
}
internal class Program
{
    public static void QueueDemo()
    {
        Queue q1 = new Queue();
        q1.Enqueue(100);
        q1.Enqueue("pune");
        q1.Enqueue(3.14);

        var x = q1.Peek();
        Console.WriteLine(x);
        x = q1.Dequeue();
        Console.WriteLine(x);
    }
    public static void StackDemo()
    {
        Stack st1 = new Stack();
        st1.Push(100);
        st1.Push(200);
        st1.Push(300);

        var x = st1.Peek();//300
        Console.WriteLine(x);
        x = st1.Peek();//300
        Console.WriteLine(x);
        x = st1.Peek();//300
        Console.WriteLine(x);

        //foreach (var item in st1)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine(st1.Count);
        //int ct=st1.Count;
        //for (int i = 1; i <= ct; i++)
        //{
        //   var x = st1.Pop();
        //    Console.WriteLine(x);
        //}
        //Console.WriteLine("-----------------------");

        //emp e1 = new emp() { id = 1, name = "abcd", salary = 1234 };
        //emp e2 = new emp() { id = 2, name = "xyz", salary = 5678 };
        //emp e3 = new emp() { id = 3, name = "pqr", salary = 9876};

        //Stack empStack = new Stack();
        //empStack.Push(e1);
        //empStack.Push(e2);
        //empStack.Push(e3);


        //  var t=empStack.Pop();
        //emp tempE = (emp)t;
        //emp tempE2 = t as emp;
        //Console.WriteLine(tempE.id);
        //Console.WriteLine(tempE2.id);
    }
    private static void Main(string[] args)
    {
        //SortedList sl1 = new SortedList();
        //sl1.Add(11,"pune");
        //sl1.Add(3,"nashik");
        //sl1.Add(12,"nagar");

        ////foreach (var x in sl1)
        ////{
        ////    DictionaryEntry temp =(DictionaryEntry) x ;
        ////    Console.WriteLine(temp.Key+" "+temp.Value);
        ////}

        //var t = sl1[11];
        ////DictionaryEntry d = (DictionaryEntry)t;
        //Console.WriteLine(t);
        emp e1 = new emp() { id = 1, name = "abcd", salary = 5678 };
        emp e2 = new emp() { id = 3, name = "xyz", salary = 1234 };
        emp e3 = new emp() { id = 2, name = "pqr", salary = 9876 };

        SortedList EmpSortList = new SortedList();
        EmpSortList.Add(e1, "emp1");
        EmpSortList.Add(e2, "emp2");
        EmpSortList.Add(e3, "emp3");

        foreach (var item in EmpSortList)
        {
            DictionaryEntry temp = (DictionaryEntry)item;
            emp E = (emp)temp.Key;
            Console.WriteLine(E.id+" "+E.name+" "+E.salary);
        }


    }
}