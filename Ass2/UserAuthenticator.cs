using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2
{
    public class UserAuthenticator
    {
        private Dictionary<string, string> userAccounts;

        public UserAuthenticator()
        {
            userAccounts = new Dictionary<string, string>();
        }

        public bool RegisterUser(string username, string pwd)
        {
            if (!userAccounts.ContainsKey(username))
            {
                userAccounts[username] = pwd;
                return true;
            }
            return false;
        }

        public bool LoginUser(string username, string pwd)
        {
            if (userAccounts.ContainsKey(username) && userAccounts[username] == pwd)
            {
                return true;
            }
            return false;
        }

        public bool ResetPassword(string username, string newPwd)
        {
            if (userAccounts.ContainsKey(username))
            {
                userAccounts[username] = newPwd;
                return true;
            }
            return false;
        }
    }
}
    

