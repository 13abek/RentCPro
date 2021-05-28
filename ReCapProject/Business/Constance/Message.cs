using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constance
{
    public static class Message
    {
        public static string Added="Operation Successfuly";
        public  static string Deleted="Deleted";
        public static string UserNotFound="User Not Found!";
        public static string PasswordError="Password invalid!";
        public  static string SuccessfulLogin="Login Successful";
        public static string UserAlreadyExists="User Already Exists!";
        public static string UserRegistered="Register Successful";
        public static string AccessTokenCreated="Token Created Successfuly";
        internal static string Updated="Updated Successfuly";
    }
}
