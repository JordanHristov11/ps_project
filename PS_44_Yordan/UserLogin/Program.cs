using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class Program
    {
        public static void onError(string message) { Console.WriteLine("!!!" + message + "!!!"); }

        public static void Menu()
        {  
            Console.WriteLine("\nChoose an Option:");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Change of user role");
            Console.WriteLine("2: Change of user activity");
            Console.WriteLine("3: List of users:");
            Console.WriteLine("4: Show log activity:");
            Console.WriteLine("5: Show current activity:\n");

        }

        private static void MenuFunctionallty(User currentUser)
        {
            int option = 1;
            while (option != 0)
            {   
                Menu();
                option = Convert.ToInt16(Console.ReadLine());
                string userToChange;
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        if (RightsGranted.roleRights.Contains(RoleRight.USERSUPDATE))
                        {

                            Console.WriteLine("Enter username of user you want to change");
                            userToChange = Console.ReadLine();
                            Console.WriteLine("Enter with which role you want to change.");
                            string roleToChange = Console.ReadLine();
                            UserRoles role;
                            bool roleIsValid = Enum.TryParse(roleToChange, out role);
                            if (roleIsValid)
                            {
                                UserData.AssignUserRole(userToChange, role);

                            }
                        }
                        else
                        {
                            Console.WriteLine("You don't have permission to access that option");
                        }


                        break;
                    case 2:
                        if (RightsGranted.roleRights.Contains(RoleRight.USERSUPDATE))
                        {

                            Console.WriteLine("Enter username of user you want to change");
                            userToChange = Console.ReadLine();
                            Console.WriteLine("Enter with which role you want to change.");
                            string date = Console.ReadLine();
                            DateTime dt = Convert.ToDateTime(date);
                            UserData.SetUserActiveTo(userToChange, dt);
                        }
                        else
                        {
                            Console.WriteLine("You don't have permission to access that option");
                        }

                        break;

                    case 3:
                        if (RightsGranted.roleRights.Contains(RoleRight.USERREGULAR))
                        {
                            List<User> users = UserData.TestUsers;
                            foreach (User user in users)
                            {
                                Console.WriteLine(user.username);
                                Console.WriteLine(user.password);
                                Console.WriteLine(user.facNum);
                                Console.WriteLine(user.role);
                                switch (LoginValidation.currentUserRole)
                                {
                                    case UserRoles.ANONYMOUS:
                                        Console.WriteLine("Current user is with role anonymous.");
                                        break;
                                    case UserRoles.ADMIN:
                                        Console.WriteLine("Current user is with role admin.");
                                        break;
                                    case UserRoles.STUDENT:
                                        Console.WriteLine("Current user is with role student.");
                                        break;
                                    case UserRoles.PROFESSOR:
                                        Console.WriteLine("Current user is with role professor.");
                                        break;
                                    case UserRoles.INSPECTOR:
                                        Console.WriteLine("Current user is with role inspector.");
                                        break;

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You don't have permission to access that option");
                        }


                        break;
                    case 4:
                        if (RightsGranted.roleRights.Contains(RoleRight.LOGREADING) && currentUser.role.Equals(UserRoles.ADMIN)
                            || currentUser.role.Equals(UserRoles.PROFESSOR)
                            || currentUser.role.Equals(UserRoles.INSPECTOR))
                        {
                            StringBuilder sb = new StringBuilder();
                            IEnumerable<string> acts = Logger.ShowLogActivity();
                            foreach(string act in acts)
                            {
                                sb.Append(act);
                            }
                            Console.WriteLine(sb.ToString());
                        }
                        else
                        {
                            Console.WriteLine("You don't have permission to access that option");
                        }

                        break;
                    case 5:
                        if (RightsGranted.roleRights.Contains(RoleRight.LOGREADING) && currentUser.role.Equals(UserRoles.ADMIN)
                            || currentUser.role.Equals(UserRoles.PROFESSOR)
                            || currentUser.role.Equals(UserRoles.INSPECTOR))
                        {
                            Console.WriteLine("Insert filter by which to output the current session activities: \n"); 
                            string filter = Console.ReadLine();
                            StringBuilder sb = new StringBuilder();
                            IEnumerable<string> currentActs = Logger.ShowCurrentActivity(filter);
                            foreach (string act in currentActs)
                            {
                                sb.Append(act);
                            }
                            Console.WriteLine(sb.ToString());
                        }
                        else
                        {
                            Console.WriteLine("You don't have permission to access that option");
                        }

                        break;

                }
            }
           
        }
        public static void initialInsertInDb()
        {
            UserContext context = new UserContext();
            int querySize = context.Users.Count();
            if(querySize == 0)
            {
                foreach(User us in UserData.TestUsers){
                    context.Users.Add(us);
                }
                context.SaveChanges();
            }
        }
            static void Main(string[] args)
        {
            initialInsertInDb();
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            LoginValidation validation = new LoginValidation(username, password, onError);
            User user;
            if (validation.ValidateUserInput(out user))
            {
                Console.WriteLine(user.username);
                Console.WriteLine(user.password);
                Console.WriteLine(user.facNum);
                Console.WriteLine(user.role);
                switch (LoginValidation.currentUserRole)
                {
                    case UserRoles.ANONYMOUS:
                        Console.WriteLine("Current user is with role anonymous.");
                        break;
                    case UserRoles.ADMIN:
                        Console.WriteLine("Current user is with role admin.");
                        break;
                    case UserRoles.STUDENT:
                        Console.WriteLine("Current user is with role student.");
                        break;
                    case UserRoles.PROFESSOR:
                        Console.WriteLine("Current user is with role professor.");
                        break;
                    case UserRoles.INSPECTOR:
                        Console.WriteLine("Current user is with role inspector.");
                        break;

                }
                RightsGranted.rights(user);
                MenuFunctionallty(user);
               
            }
           
        }
    }
}
