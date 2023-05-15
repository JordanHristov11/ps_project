using System;
using System.Collections.Generic;
using System.Data;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
        static UserContext context = new UserContext();
        static LogInfoContext logInfo = new LogInfoContext();
        public static List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }
        private static List<User> _testUser = new List<User>();

        private static void ResetTestUserData()
        {
            if (!_testUser.Any())
            {
                User user = new User();
                user.username = "Simeon";
                user.password = "12345";
                user.facNum = "11111111";
                user.role = UserRoles.ADMIN;
                user.creationTime= DateTime.Now;
                user.expirationTime = DateTime.MaxValue;

                User user1 = new User();
                user1 = new User();
                user1.username = "Georgi";
                user1.password = "23456";
                user1.facNum = "2222222";
                user1.role = UserRoles.STUDENT;
                user1.creationTime = DateTime.Now;
                user1.expirationTime = DateTime.MaxValue;

                User user2 = new User();
                user2 = new User();
                user2.username = "Stanislav";
                user2.password = "34567";
                user2.facNum = "33333333";
                user2.role = UserRoles.STUDENT;
                user2.creationTime = DateTime.Now;
                user2.expirationTime = DateTime.MaxValue;

                _testUser.Add(user);
                _testUser.Add(user1);
                _testUser.Add(user2);
                

            }
        }
        public static void SetUserActiveTo(string username, DateTime dateTime)
        {
            /*foreach(User user in TestUsers)
            {
                if (username.Equals(user.username))
                {
                    user.expirationTime= dateTime;
                    Logger.LogActivity("Changed the account expiration of " + username);
                }
            }*/
            User usr = (from u in context.Users where u.username == username select u).First();
            usr.expirationTime= dateTime;
            context.SaveChanges();
            Log log = new Log();
            log.log = "Changed the account expiration of" + username;
            logInfo.Logs.Add(log);
            logInfo.SaveChanges();
/*            Logger.LogActivity("Changed the account expiration of " + username);
*/
        }

        public static void AssignUserRole(string username, UserRoles userrole)
        {
            /*foreach(User user in TestUsers)
            {
                if (username.Equals(user.username))
                {
                    user.role = userrole;
                    Logger.LogActivity("Changed role of " + username);
                }
            }*/
            User usr = (from u in context.Users where u.username == username select u).First();
            usr.role = userrole;
            context.SaveChanges();
            Logger.LogActivity("Changed role of " + username);

        }

        public static User IsUserPassCorrect(string username, string password)
        {
            User user = (from u in context.Users where u.username == username
                         && u.password == password select u).FirstOrDefault();
            
            return user;

        }
    }
}
