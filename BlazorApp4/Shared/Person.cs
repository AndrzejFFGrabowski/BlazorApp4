using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp4.Shared
{
    public class Person
    {
        public int Id { get; set; }
        public String name { get; set; } = String.Empty;
        //public int age { get; set; }
        public Person()
        {

        }
        public Person(int id, string name)
        {
            Id = id;
            this.name = name;
        }
    }
}
