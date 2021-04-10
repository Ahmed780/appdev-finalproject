using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdev_finalproject
{
    class Admin : User
    {
        private static int nextId = 0;

        public Admin(string name, string password) : base(name, password)
        {
            
        }

        public override string generateId()
        {
            nextId = nextId + 1;
            return String.Format("A{0:0000}", nextId);
        }

        public static int NextId { get => nextId; set => nextId = value; }
    }
}
