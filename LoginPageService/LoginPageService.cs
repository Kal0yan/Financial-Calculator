using Business_Layer;
using DataAccess_Layer;
using System.ComponentModel.DataAnnotations;

namespace Service_Layer
{
    public class LoginPageService
    {
        private UserContext _userContext;
        private List<User> _users;

        public LoginPageService()
        {
            _userContext = new UserContext();
            _users = _userContext.ReadAll(true, false);
        }

        public string Login(string username, string password)
        {
            foreach(User user in _users)
            {
                if(user.Username == username)
                {
                    if(password == user.Password)
                    {
                        return user.Id.ToString();
                    }
                    else
                    {
                        return "Wrong password";
                    }
                }
            }

            return "The username you have entered is not used by any profile";
        }
    }
}
