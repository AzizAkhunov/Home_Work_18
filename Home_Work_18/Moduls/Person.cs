using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_18.Moduls
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long PassportId { get; set; }
        public Passport Passport { get; set; }
        public ICollection<Car> Cars { get; set;}
    }
}
