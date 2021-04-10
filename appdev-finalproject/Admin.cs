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
            base.Id = generateId();
        }

        public override string generateId()
        {
            return String.Format("A%04d", nextId++);
        }

        public static int NextId { get => nextId; set => nextId = value; }
    }
}
