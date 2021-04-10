using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdev_finalproject
{
    class Teacher : User
    {
        private static int nextId = 0;

        public Teacher(string name, string password) : base(name, password)
        {
            
        }

        public override string generateId()
        {
            nextId = nextId + 1;
            return String.Format("T{0:0000}", nextId);
        }

        public static int NextId { get => nextId; set => nextId = value; }
    }
}

