using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        private string username;
        private string password;
        private string errorMessage;
        private ActionOnError actionOnError;


        public LoginValidation(string username, string password, ActionOnError actionOnError)
        {
            this.username = username;
            this.password = password;
            this.actionOnError = actionOnError;
        }
        public delegate void ActionOnError(string errorMsg);

        public static UserRoles currentUserRole { get; private set; }
        public static string currentUserName { get; private set; }
        public bool ValidateUserInput(out User user)
        {
            user = UserData.IsUserPassCorrect(username, password);

            if (user != null)
            {
                currentUserRole = user.role;
                currentUserName = user.username;
            }
            else
            {
                errorMessage = "User is null.";
                actionOnError(errorMessage);
                return false;
            }
            Boolean emptyUserName;
            emptyUserName = username.Equals(String.Empty);
            if(emptyUserName)
            {
                errorMessage = "There is no username.";
                currentUserRole = UserRoles.ANONYMOUS;
                actionOnError(errorMessage);
                return false;
            }
            Boolean emptyPassword;
            emptyPassword= password.Equals(String.Empty);
            if(emptyPassword)
            {
                errorMessage = "There is no password.";
                currentUserRole = UserRoles.ANONYMOUS;
                actionOnError(errorMessage);
                return false;
            }
            if(username.Length < 5) {
                errorMessage = "Username must be at least 5 characters.";
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
            if (password.Length < 5)
            {
                errorMessage = "Password must be at least 5 charaters.";
                currentUserRole = UserRoles.ANONYMOUS;
                actionOnError(errorMessage);
                return false;
            }
            Logger.LogActivity("Successful Login");
            return true;
        }
    }
}
