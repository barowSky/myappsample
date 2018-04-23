﻿namespace crisicheckinweb.Wrappers
{
    public interface IWebSecurityWrapper
    {
        int CurrentUserId { get; }

        string CurrentUserName { get; }

        int GetUserId(string userName);

        string CreateUser(string userName, string password, string[] roleNames, out int userId);

        bool ConfirmAccount(string token);

        bool ChangePassword(string userName, string currentPassword, string newPassword);

        string GeneratePasswordResetToken(string userName);

        bool ResetPassword(string passwordResetToken, string newPassword);

        bool Login(string userName, string password, bool persistCookie = false);

        void Logout();

        bool ValidateUser(string userName, string password);

        bool IsUserInRole(string roleName);

        bool IsUserInRole(string userName, string roleName);

        void AddUserToRole(string userName, string roleName);
    }
}
