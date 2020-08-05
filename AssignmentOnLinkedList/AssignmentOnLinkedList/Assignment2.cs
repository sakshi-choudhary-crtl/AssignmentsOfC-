using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnLinkedList
{
   
       
            public class Person
        {
            public int age
            {
                get;
                set;
            }

            public string fname
            {
                get;
                set;
            }
            public string lname
            {
                get;
                set;
            }
            public string city
            {
                get;
                set;
            }
            public Person()
            {

            }
            public Person(int _age, string _fanme, string _lname, string _city)
            {
                age = _age;
                fname = _fanme;
                lname = _lname;
                city = _city;


            }
            public void Display()
            {

                Console.WriteLine("Name :{0} ", fname + lname);
                Console.WriteLine("Age :{0}", age);
                Console.WriteLine("City :{0}", city);
            }
        }
        class Assignment2
        {
            static void Main()
            {
                List<Person> li = new List<Person>()
            {

                new Person(){ age=22, fname="Sakshi",lname="Choudhary",city="Jhabua"},
                new Person(){ age=12, fname="Anita",lname="Choudhary",city="Thandla"},
                new Person(){ age=15, fname="Nancy",lname="Rana",city="Guna"},
                new Person(){ age=40, fname="Akshay",lname="Kumar",city="Mumbai"},
                new Person(){ age=45, fname="Anahat",lname="Jat",city="Gwalior"}

            };
                Console.WriteLine("Details of the 5 Person:");
                foreach (var p in li)
                {
                    p.Display();

                }



            }

        }

    }



