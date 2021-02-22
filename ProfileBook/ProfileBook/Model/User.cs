using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProfileBook.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
       
        public string name { get; set; }
        [MaxLength(12)]
        public string password { get; set; }   
        public User()
        {

        }
    }

}
