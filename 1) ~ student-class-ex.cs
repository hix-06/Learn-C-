using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsole
{
    public class Student
    {
        public Student(string name, string number){
            this.Name = name;
            this.PhoneNumber = number;
        }
        public string Name {get;}
        public string PhoneNumber { get;}
        public double CumulativeGPA { get; set; }
        private string _address = "";
        public string Address {
            get { return _address; }
            set 
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _address = value;
                }
            }
        }
        public int Age {get; init;}
        

    }
}
