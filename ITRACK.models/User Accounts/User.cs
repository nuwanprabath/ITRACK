using ITRACK.models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models.User_Accounts
{
    class User 
    {
        public string UserID { get; set; }

        public string UserName  { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public string Email { get; set; }

        public string TeleNo { get; set; }


        public string Password { get; set; }

        public int UserLevel { get; set; }


        List<User> UserList = new List<User>();



        //public bool CreateUser() {

        //    try { }
        //    catch(){
            
        //    }
        
        //}

        public List<User> GetUser(User _user)
        {
            try {

                GenaricRepository<User> _repository = new GenaricRepository<User>(new ItrackContext());
                var userList = from user in _repository.GetAll().ToList()
                               where user.UserName == _user.UserName && user.Password == _user.Password

                               select new { user.UserName, user.UserID, user.Department, user.UserLevel, user.Password };
                 
                 

                return UserList;
                
            }catch(Exception ex)
            {
                return null;
            
            }
        }


     
    }
}
