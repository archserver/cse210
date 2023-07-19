using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemical_Release_Pathing
{
    public class Person
    {
        private string _name;
        private string _contactNumber1;
        private string _contactNumber2;
        private string _email;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetContactNumber1()
        {
            return _contactNumber1;
        }

        public void SetContactNumber1(string contactNumber1)
        {
            _contactNumber1 = contactNumber1;
        }

        public string GetContactNumber2()
        {
            return _contactNumber2;
        }

        public void SetContactNumber2(string contactNumber2)
        {
            _contactNumber2 = contactNumber2;
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }
    }
}
