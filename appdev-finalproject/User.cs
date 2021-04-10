using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdev_finalproject
{
    abstract class User
    {
        private string id;
        private string name;
        private string password;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public abstract String generateId();

        public void addUser(string id, string name, string password)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("..\\..\\Users.csv", true))
                {
                    file.WriteLine(id + "," + name + "," + password);
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Error" + ex);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   id == user.id &&
                   name == user.name &&
                   password == user.password;
        }

        public override int GetHashCode()
        {
            int hashCode = -1780305970;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(password);
            return hashCode;
        }

        protected string Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }
        protected string Password { get => password; set => password = value; }
    }
}
