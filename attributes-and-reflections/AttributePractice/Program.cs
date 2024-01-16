using System;
using System.Reflection;

namespace AttributePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person()
            {
                FirstName = "Bob",
                LastName = "Smith",
                SSN = "123445",
                Age = 21,
                Birthday = "April 20"

            };

            Person p2 = new Person()
            {
                FirstName = "John",
                LastName = "Doe",
                SSN = "123445",
                Age = 40,
                Birthday = "July 17"
            };

            Person p3 = new Person()
            {
                FirstName = "Jeff",
                LastName = "Ring",
                SSN = "123445",
                Age = 22,
                Birthday = "May 14"
            };

            Person p4 = new Person()
            {
                FirstName = "Alex",
                LastName = "Smith",
                SSN = "11234",
                Age = 38,
                Birthday = "January 2"
            };

            Person p5 = new Person()
            {
                FirstName = "Rob",
                LastName = "Brown",
                SSN = "45678",
                Age = 14,
                Birthday = "December 19"
            };

            Console.WriteLine(p1);
            Type t1 = p1.GetType();
            Console.WriteLine(t1);

            /*  ConstructorInfo[] c = t1.GetConstructors();
             foreach(ConstructorInfo ci in c){
                 Console.WriteLine(ci);
             }

             PropertyInfo[] p = t1.GetProperties();
             foreach(PropertyInfo pi in p){
                 Console.WriteLine(pi);
             }

             MemberInfo[] m = t1.GetMembers();
             foreach(MemberInfo mi in m){
                 Console.WriteLine(mi);
                 object[] att = mi.GetCustomAttributes(true);
                 foreach(object o in att){
                     Console.WriteLine(o);
                     if(o is PersonalInformationAttribute){
                         Console.WriteLine("Personal - don't print");
                         PersonalInformationAttribute pia = (PersonalInformationAttribute)o;
                         if(pia.Level == 3){
                             Console.WriteLine("Super Private");
                         } else {
                             Console.WriteLine("Sorta Private");
                         }
                     }
                 }
                 Console.WriteLine("-------------");

             }


              MemberInfo[] m1 = t1.GetMembers();
             foreach(MemberInfo mi1 in m1){
                 Console.WriteLine(mi1);
                 object[] att1 = mi1.GetCustomAttributes(true);
                 foreach(object o1 in att1){
                     Console.WriteLine(o1);
                 }
                 Console.WriteLine("---------");
             }

             MemberInfo[] m2 = t1.GetMembers();
             foreach(MemberInfo mi2 in m2){
                 Console.WriteLine(mi2);
                 object[] att2 = mi2.GetCustomAttributes(true);
                 foreach(object o2 in att2){
                     Console.WriteLine(o2);
                 }
                 Console.WriteLine("---------");
             }

             int x = 10;
             Boolean b = true;
             Console.WriteLine(x.GetType());
             Console.WriteLine(b.GetType());
             */

            Person[] per = { p1, p2, p3, p4, p5 };
            foreach (Person p in per)
            {
                Console.WriteLine(p.ToStringRedacted());
            }

        }
    }
}
