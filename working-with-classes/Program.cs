using System;
using static System.Console;

namespace WorkingWithClasses
{
    public enum UserStatus
    {
        Enabled,
        Disabled,
        Deleted,
    }

    class Person
    {
        string _name;
        int _age;
        public UserStatus userStatus = UserStatus.Enabled;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value < 0 || value > 120 ? throw new Exception("Invalid age") : value;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Person person = new Person();
                person.Name = "Ace";
                person.Age = 19;
                WriteLine(person.userStatus);
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
        }
    }
}
