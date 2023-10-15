using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Person
    {
        private string name { get; set; }
        private string phone { get; set; }
        private string mail { get; set; }
        static int id = 0;

        //private bool n = false;
        //private bool p = false;
        //private bool m = false;

        public Person(string name, string phone, string mail)
        {
            this.name = name;
            this.phone = phone;
            this.mail = mail;
   //         id++;
        }
        public Person()
        {
            id++;
        }

        public void setName(string value)
        {
            this.name = value;
        }

        public void setPhone(string value)
        {
            this.phone = value;
        }

        public void setMail(string value)
        {
            this.mail = value;
        }

        public string getName()
        {
            return name;
        }

        public string getPhone()
        {
            return phone;
        }


        public string getMail()
        {
            return mail;
        }
        public string getId()
        {
            return id.ToString();
        }


    }
}
