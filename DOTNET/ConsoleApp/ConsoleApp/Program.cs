using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Type tpy = typeof(Developer);
            Console.WriteLine("Class Attribute");
            Attribute[] attr = Attribute.GetCustomAttributes(tpy);
            foreach (Attribute a in attr)
            {
                MyAttribute devloper = (MyAttribute)a;
                Console.WriteLine(devloper.getPublisherName() + "\t" + devloper.version);
            }
            Console.WriteLine("Method Attribute");
            Type [] type=new Type[1];
            type[0]=typeof(Int32);
            
            Attribute[] attr_method = Attribute.GetCustomAttributes(tpy.GetMethod("getData",type));
            foreach (Attribute a in attr_method)
            {
                MyAttribute devloper = (MyAttribute)a;
                Console.WriteLine(devloper.getPublisherName() + "\t" + devloper.version);
            }
            Console.ReadLine();

        }
    }

    [MyAttribute("Parth Roy", version = 2.0f)]
    [MyAttribute("Royal Dreams")]
    class Developer
    {
        int x;
        [MyAttribute("Keval Navadiya", version = 5.12f)]
        public int getData()
        {
            return x;
        }
        [MyAttribute("Keval Navadiya", version = 5.12f)]
        public int getData(int a,int y)
        {
            return x;
        }       
        [MyAttribute("Parth Roy", version = 1.20f)]
        public int getData(int x)
        {
            return x;
        }
        [MyAttribute("Darshit Akbari")]
        public void putData(int x)
        {
            this.x=x;
        }
    }

    [AttributeUsage (AttributeTargets.Class|AttributeTargets.Method,AllowMultiple=true)]
    class MyAttribute : Attribute
    {
        public string publisher;
        public float version;
        public MyAttribute()
        {
            publisher = "Royal Dreams";
            version = 0.0f;
        }
        public MyAttribute(string str)
        {
            this.publisher = str;
        }
        public string getPublisherName() { return (string)publisher; }
    }
}
