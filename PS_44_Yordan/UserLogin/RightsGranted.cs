using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class RightsGranted
    {
        public static List<RoleRight> roleRights = new List<RoleRight>();

        public static void rights(User user) {
            switch (user.role)
            {
                case UserRoles.STUDENT:
                    roleRights.Add(RoleRight.USERREGULAR);
                    break;
                case UserRoles.ADMIN:
                    roleRights.Add(RoleRight.USERREGULAR);
                    roleRights.Add(RoleRight.USERSUPDATE);
                    roleRights.Add(RoleRight.LOGREADING);
                    break;
                case UserRoles.ANONYMOUS:
                    break;
                case UserRoles.PROFESSOR:
                    roleRights.Add(RoleRight.USERREGULAR);
                    roleRights.Add(RoleRight.LOGREADING);
                    break;
                case UserRoles.INSPECTOR:
                    roleRights.Add(RoleRight.USERREGULAR);
                    roleRights.Add(RoleRight.LOGREADING);
                    break;
            }
        }


    }
}
