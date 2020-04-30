using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Human
    {
        public string Name { get; set; }
    }
    class School :Human
    { 
        public List<int> classes { get; set; }
        public School()
        {
            classes = new List<int>();
        }
    }

    class Uchenik:Human
    {
        public List<int> classes { get; set; }
        public List<string> school { get; set; } 
        public Uchenik() 
        {
            classes = new List<int>();
            school = new List<string>();

        }
    }

    class Class 
    {
        public int number { get; set; }
        public List<string> pupils { get; set; }
        public Class()
        {
            pupils = new List<string>();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //List<School> sch = new List<School>
            //{
            //    new School {Name =" gemnazy 1",  classes = new List<int>{ 1 , 2 } },
            //    new School {Name =" gemnazy 3",  classes = new List<int>{ 3, 5 } }
            //};
            //List<Class> cl = new List<Class>
            //{
            //   new Class{ number = 1, pupils = new List<string>{ "alex" , "Tom"} },
            //   new Class{ number = 5, pupils = new List<string>{ "Sergei", "Bill"} }
            //};

           

            List<Uchenik> uch = new List<Uchenik>
            {
                new Uchenik{Name ="Alex" , classes =new List<int>{ 1}, school = new List<string>{"1 gym"} },
                new Uchenik{ Name = "Tom", classes =new List<int>{ 1}, school = new List<string>{"1 gym"}},
                new Uchenik{ Name = "John", classes =new List<int>{ 4}, school = new List<string>{"1 gym"}},
                new Uchenik{ Name = "Timi", classes =new List<int>{ 4}, school = new List<string>{"1 gym"}},
                new Uchenik{ Name = "Bill", classes =new List<int>{ 3}, school = new List<string>{"4 gym"}},
                new Uchenik{ Name = "Billy", classes =new List<int>{ 3}, school = new List<string>{"4 gym"}},
                new Uchenik{ Name = "Michel", classes =new List<int>{ 9}, school = new List<string>{"4 gym"}},
                new Uchenik{ Name = "Ron", classes =new List<int>{ 9}, school = new List<string>{"4 gym"}}
            };
            var selectall = from b in uch
                            orderby b.Name
                            select b;

            foreach (var i in selectall)
            {
                Console.WriteLine($"{i.Name}");
            }
            Console.WriteLine("------------------------------");
            var selec = from h in uch
                            from g in h.school
                            group g by g;
            foreach (var item in selec)
            {
                Console.WriteLine(item.Key + " школе - " + item.Count() + "учеников");
            }



        }
    }
}
