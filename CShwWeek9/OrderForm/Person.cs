using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Person
    {
        [Key]
        public String Name { get; set; }
        public int Age { get; set; }
        public String Addr { get; set; }

        public Person(String name, int age, String addr)
        {
            Name = name;
            Age = age;
            Addr = addr;
        }
    }
}
