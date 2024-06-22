using Business_Layer;
using DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer
{
    public class SignUpPageService
    {
        private UserContext _userContext;
        private List<User> _users;

        public SignUpPageService()
        {
            _userContext = new UserContext();
            _users = _userContext.ReadAll(true, false);
        }
        public string Registration(string username, string password, float balance)
        {
            foreach (User user in _users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return "Profile already exists";
                }
            }

            User userToCreate = new User(username, password, balance);
            _userContext.Create(userToCreate);

            return "User has been created!";
        }
    }
}
