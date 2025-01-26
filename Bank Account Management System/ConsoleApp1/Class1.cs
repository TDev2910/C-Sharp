using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        Person person1 = new Person("");
        Person person2 = new Person("Nam");
        Person person3 = new Person("Nam","Nguyen");
        Person person4 = new Person("Nam","Nguyen",20);

        public void Dosomething(Person p)
        {
            Console.WriteLine("First name : " + p.firstName);
            Console.WriteLine("Last name : " + p.lastName);
            Console.WriteLine("Age : " + p.age);
        }
    }

    class Person
    {
        public Person() : this("")
        {
            
        }
        public Person(string first) : this(first,"")
        {

        }
        public Person(string first, string last) : this(first,last,0)
        {
            
        }
        public Person(string firstname , string lastname, int age)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.age = age;
            var obj = new Class1();
            obj.Dosomething(this); 
        }

        public  string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public void Dosomething(Person p)
        {

        }
    }
}
