using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
     class PersonalInfo
    {
        //data fields
        private string name;
        private string address;
        private string phoneNumber;
        private int age;

        //constructors

        PersonalInfo() { }
        public PersonalInfo(string name,string address,string phoneNumber,int age)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.age = age;
        }

        //accesers modifiers

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
