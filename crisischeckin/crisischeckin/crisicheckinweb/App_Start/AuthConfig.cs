﻿using System.Web.Security;
using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading;
using System.Web;
using WebMatrix.Data;
using WebMatrix.WebData;

namespace crisicheckinweb
{
    public class AuthConfig
    {
        private static SimpleMembershipInitializer _initializer;
        private static object _initializerLock = new object();
        private static bool _isInitialized;

        public static void Register()
        {
            LazyInitializer.EnsureInitialized(ref _initializer, ref _isInitialized, ref _initializerLock);
        }

        private class SimpleMembershipInitializer
        {
            public SimpleMembershipInitializer()
            {
                try
                {
                    if (!WebSecurity.Initialized)
                    {
                        WebSecurity.InitializeDatabaseConnection("CrisisCheckin", "User", "Id", "UserName", autoCreateTables: true);
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("The ASP.NET Simple Membership database could not be initialized. For more information, please see http://go.microsoft.com/fwlink/?LinkId=256588", ex);
                }
            }
        }

        public static void VerifyRolesAndDefaultAdminAccount()
        {
            if (!Roles.RoleExists(Constants.RoleAdmin))
            {
                Roles.CreateRole(Constants.RoleAdmin);
            }

            if (!Roles.RoleExists(Constants.RoleVolunteer))
            {
                Roles.CreateRole(Constants.RoleVolunteer);
            }

            if (!WebSecurity.UserExists(Constants.DefaultAdministratorUserName))
            {
                WebSecurity.CreateUserAndAccount(Constants.DefaultAdministratorUserName, Constants.DefaultAdministratorPassword, null, false);
            }
            if (WebSecurity.UserExists(Constants.DefaultAdministratorUserName) &&
                !Roles.IsUserInRole(Constants.DefaultAdministratorUserName, Constants.RoleAdmin))
            {
               Roles.AddUserToRole(Constants.DefaultAdministratorUserName, Constants.RoleAdmin); 
            }

            // Set up automated test user login
            if (!WebSecurity.UserExists(Constants.DefaultTestUserName))
            {
                WebSecurity.CreateUserAndAccount(Constants.DefaultTestUserName, Constants.DefaultTestUserPassword, null, false);
            }

            if (WebSecurity.UserExists(Constants.DefaultTestUserName) &&
                !Roles.IsUserInRole(Constants.DefaultTestUserName, Constants.RoleVolunteer))
            {
                Roles.AddUserToRole(Constants.DefaultTestUserName, Constants.RoleVolunteer);
            }
        }
    }
}