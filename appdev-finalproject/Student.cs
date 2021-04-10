using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdev_finalproject
{
    class Student
    {
        public static void main(String[] args)
        {

            Admin admin = new Admin("Admin", "Bob");
            admin.addUser("id", "name", "password");
        }
    }
}
