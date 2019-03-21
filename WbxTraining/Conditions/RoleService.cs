using System;
using System.Collections.Generic; 

namespace WbxTraining.Conditions
{
    public class RoleService
    {
        public List<Role> roles;

        public RoleService()
        {
            roles = new List<Role>();
        }

        public void AddRole(Role role)
        {
            if (role != null)
            {
                if (!string.IsNullOrEmpty(role.Name))
                {
                    if (!IsEnable(role))
                    {
                        roles.Add(role);
                    }
                    else
                    {
                        throw new InvalidOperationException("role mus be enable");
                    }
                }
                else
                {
                    throw new ArgumentException("roles must have a name", "role");
                }
            }
            else
            {
                throw new ArgumentException("roles must have a name", "role");
            }
        }

        public bool IsEnable(Role role)
        {
            return role.IsAdmin && !role.IsBlocked;
        }
    }
}
