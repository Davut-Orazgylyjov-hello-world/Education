using System;

namespace Education
{
    internal class Program
    {
        private struct MyClass
        {
            public int a, b, c;
            
            public MyClass(int a = 10, int b = 10, int c = 10)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
        
        static void Foo(ref MyClass myClass)
        {
            myClass.a -= 5;
        }
        
        public static void Main(string[] args)
        {
          //  var myClass = new MyClass(32,53,12)
                
            var myClass = new MyClass {a = 12};
            
            Foo(ref myClass);

            Console.WriteLine(myClass.a);

        }
    }
}