using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2c_
{
    public class UserSession
    {
        
        private static int OnlineUsers = 0;

       
        private static List<string> OnlineUserList = new List<string>();

        
        private string UserName;

        
        private string Role;

        
        public UserSession(string userName, string role)
        {
            UserName = userName;
            Role = role;
        }

       
        public static void DisplayOnlineUsers()
        {
            Console.WriteLine($"Total Online Users: {OnlineUsers}");
            if (OnlineUserList.Count > 0)
            {
                Console.WriteLine("Online User List:");
                foreach (var user in OnlineUserList)
                {
                    Console.WriteLine($" - {user}");
                }
            }
            else
            {
                Console.WriteLine("No users online.");
            }
        }

        
        public void Login()
        {
            OnlineUsers++;
            OnlineUserList.Add(UserName);
            Console.WriteLine($"{UserName} logged in. Role: {Role}. Online Users: {OnlineUsers}");
        }

        
        public void Logout()
        {
            if (OnlineUsers > 0 && OnlineUserList.Contains(UserName))
            {
                OnlineUsers--;
                OnlineUserList.Remove(UserName);
                Console.WriteLine($"{UserName} logged out. Online Users: {OnlineUsers}");
            }
            else
            {
                Console.WriteLine($"{UserName} is not logged in.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            UserSession user1 = new UserSession("Mehrshad", "Admin");
            UserSession user2 = new UserSession("Mamad", "User");
            UserSession user3 = new UserSession("Roham", "User");

            user1.Login(); 
            user2.Login(); 
            UserSession.DisplayOnlineUsers(); 

 
            user1.Logout(); 
            UserSession.DisplayOnlineUsers(); 

            
            user3.Login(); 
            UserSession.DisplayOnlineUsers();
        }
    }
}
