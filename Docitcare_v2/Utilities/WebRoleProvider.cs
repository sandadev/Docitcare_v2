using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Docitcare_v2.Persistence;

namespace Docitcare_v2.Utilities
{
    public class WebRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (var context = new DocitcareDbContext())
            {
                var result = (from user in context.UltraUsers
                              join rolemap in context.UltraRoleMappings on user.UltraUserId equals rolemap.UltraUserId
                              join role in context.UltraRole on rolemap.UltraRoleID equals role.UltraRoleID
                              where user.UserName == username
                              select role.UltraRoleName).ToArray();
                            
                return result;
            }

        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}