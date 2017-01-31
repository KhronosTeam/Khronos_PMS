using Khronos_PMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.Util
{
    class AccountManagement
    {
        private static KhronosPMSEntities entities = new KhronosPMSEntities();
        private static bool CreateUser(string username, string password)
        {
            if (!entities.Users.Any(u => u.Username == username))
            {
                User user = new User();
                user.Username = username;
                user.Password = PasswordUtil.GenerateHash(password);
                user.Active = true;
                entities.Users.Add(user);
                entities.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool CreateAdmin(string username, string password, string firstname, string lastname)
        {
            if(CreateUser(username, password))
            {
                Admin admin = new Admin();
                admin.FirstName = firstname;
                admin.LastName = lastname;
                admin.User = entities.Users.First(u => u.Username == username);
                entities.Admins.Add(admin);
                entities.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool CreateWorker(string username, string password, string firstname, string lastname)
        {
            if(CreateUser(username, password))
            {
                Worker worker = new Worker();
                worker.FirstName = firstname;
                worker.LastName = lastname;
                worker.User= entities.Users.First(u => u.Username == username);
                entities.Workers.Add(worker);
                entities.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool CreateCustomer(string username, string password, string name)
        {
            if(CreateUser(username, password))
            {
                Customer customer = new Customer();
                customer.Name = name;
                customer.User = entities.Users.First(u => u.Username == username);
                entities.Customers.Add(customer);
                entities.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool ChangePassword(string username, string newPassword)
        {
            if (entities.Users.Any(u => u.Username == username))
            {
                User user = entities.Users.First(u => u.Username == username);
                user.Password = PasswordUtil.GenerateHash(newPassword);
                entities.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool Activate(string username, bool active)
        {
            if (entities.Users.Any(u => u.Username == username))
            {
                User user = entities.Users.First(u => u.Username == username);
                user.Active = active;
                entities.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<User> GetUsers()
        {
            return entities.Users.ToList();
        }

        public static List<string> GetUsernames()
        {
            return entities.Users.Select(u => u.Username).ToList();
        }
    }
}
