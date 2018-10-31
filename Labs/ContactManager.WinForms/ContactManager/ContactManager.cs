using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
 public   class ContactManagerrr
    {
        private String Name;
        private String Email,Subject,Message;




        public void setSubject(String subject) {
            this.Subject = subject;
        }
        public void SetMessage(String message) {
            this.Message = message;
        }
        public void setName(String name)
        {
            this.Name = name;
        }

        public void setEmail(String email)
        {
            this.Email = email;
        }

        public String getName() {
            return this.Name;
        }
        public String getEmail()
        {
            return this.Email;
        }

        public String getSubject() {
            return this.Subject;
        }
        public String getMessage() {
            return this.Message;
        }

    }
}
