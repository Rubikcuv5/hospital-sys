﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys
{
   public class userModel
    {
        private int id;
        private String name;
        private String last_name;
        private String password;
        private int status;
        private int user_type;
        private int specialty;
        private int departament;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Password { get => password; set => password = value; }
        public int Status { get => status; set => status = value; }
        public int User_type { get => user_type; set => user_type = value; }
        public int Specialty { get => specialty; set => specialty = value; }
        public int Departament { get => departament; set => departament = value; }
    }
}
