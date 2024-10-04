using System;

namespace HOTELMANAGEMENTSYSTEM_OOP.Model
{
    public class User
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }
        public UserType UserType { get; }

        public User(int id, string name, string email, string password, UserType userType)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            UserType = userType;
        }
    }

    public enum UserType
    {
        HotelAdmin,
        FrontDesk,
        HouseKeeping
    }
}
