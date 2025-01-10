using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        //Branch Addition 2 for PR

        //Static 

        static String var1 = "This is Static Variable."; //Static Variable
        String var2 = "This is non-static variable."; //Non-static Variable
        static void Method1() //Static Method
        {
            Console.WriteLine("This is Static Method.");
        }
        void Method2() //Non-static Method
        {
             Console.WriteLine("This is non-static method.");
        }



        //Polymorphism 
        void PolyMethod() 
        {
            Console.WriteLine("This is first overloaded Method.");
        }

        void PolyMethod(String Message)
        {
               Console.WriteLine(Message);
        }



        //Inheritance
        public class Base
        {
            public void BaseMethod()
            {
                Console.WriteLine("This is Base Class Method.");
            }
        }
        class Sub1 : Base
        {
            public void SubMethod()
            {
                Console.WriteLine("This is Sub Class Method.");
            }
        }

        //Method Overriding
        class Base2
        {
            private String DataMember1;
            protected String DataMember2;

            public Base2(String PvtMember, String PrtdMember)
            {
                DataMember1=PvtMember;
                DataMember2=PrtdMember;
            }
            public void Print()
            {
                Console.WriteLine($"\nThis is overriden method in base class.\n{DataMember1}");
            }
            public void PvtAccess()
            {
                String data = DataMember1;
                Console.WriteLine(data);
            }

        }

        class Sub2 : Base2
        {
            public Sub2(String PvtMember, String PrtdMember) : base(PvtMember, PrtdMember)
            {
            }
            public void Print()
            {
                Console.WriteLine($"This is overriding method in sub class.\n{DataMember2}");
            }

        }



        //Abstraction
        abstract class BluePrint
        {
            public abstract void AbsMethod();

            public void ConcreteMethod()
            {
                Console.WriteLine("This is Concrete Method.");
            }
        }

        class Abs1 : BluePrint
        {
            public override void AbsMethod()
            {
                Console.WriteLine("This is the Abstract Method.");
            }

        }



        //Interface

        interface Inter1
        {
            void InterMethod();
        }

        class Stud : Inter1
        {
            public void InterMethod()
            {
                Console.WriteLine("This is Pure Abstract method using Interface.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This is Main Method.");

            //Static

            Program.Method1(); 

            Program p1 = new Program();
            p1.Method2(); //Encapsulation

            Console.WriteLine(Program.var1); 
            Console.WriteLine(p1.var2); 


            //Polymorphism

            p1.PolyMethod();
            p1.PolyMethod("This is second overloaded method.");

            
            //Inheritance

            Sub1 s1 = new Sub1();
            s1.BaseMethod();
            s1.SubMethod();

            Sub2 s2 = new Sub2("Private Member","Protected Member");
            s2.Print(); //Method Overriding
            s2.PvtAccess();

            Base2 b2 = new Base2("Private Member", "Protected Member");
            b2.Print(); //Private Member


            //Abstraction

            Abs1 a1 = new Abs1();
            a1.ConcreteMethod();
            a1.AbsMethod();


            //Interface

            Inter1 i1 = new Stud();
            i1.InterMethod();



        }
    }
 
}
