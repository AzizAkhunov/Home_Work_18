using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_18.Moduls
{
    public class Car
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Person> Children { get; set;}
    }
}
