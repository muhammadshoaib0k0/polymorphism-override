using System;

namespace polymorphism_override
{

    /// <summary>
    /// poly morphism overriding base class reference variable point to the derive class obj and called the correct methods
    /// we use over ride where we want to change the implementation of methods 
    /// </summary>





    public class Employee
    {
        public string first_name="muhammad";
        public string last_name="shoaib";
            public virtual  void print()
            {
                Console.WriteLine(first_name+""+last_name);
            Console.WriteLine("");
            }
    }
    public class part : Employee
    {
        public  override void print()
        {
            Console.WriteLine(first_name + "" + last_name+"   part time ");
        }

    }
    public class full : Employee
    {
        public override void print()
        {
            Console.WriteLine(first_name + " " + last_name +"     full time");
        }

    }
    public class  temporary : Employee
    {
        public override void print()
        {
            Console.WriteLine(first_name + "" + last_name+ "    temporary");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Employee [] employees = new Employee[4];
            
            employees[0] = new Employee();
            // here base class reference assign to the derived class objects 
            employees[1] = new part();
            employees[2] = new full();
            employees[3] = new temporary();
            foreach (Employee o in employees)
            {
                o.print();

            }












        }
    }
}
