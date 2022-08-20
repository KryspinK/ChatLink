using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLink
{

    class User
    {
        private string firstName;
        private string secondName;
        private int id;

        public User(int id, String firstName, String secondName)
        {
            this.id = id;
            this.firstName = firstName;
            this.secondName = secondName;
          

        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getSecondName()
        {
            return secondName;
        }

        public void setSecondName(String secondName)
        {
            this.secondName = secondName;
        }

        public override String ToString()
        {
            return Convert.ToString(id);
        }




    }
}
