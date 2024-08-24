using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class user
    {
        public string Name { get; set; }
        public string Email{ get; set; }
        public string Phone { get; set; }

        public void AddUser(List<user> users) 
        {
            Console.WriteLine("=========== Add new user ==============");

            var user=new user();

            Console.WriteLine("please add your Name : ");
            user.Name = Console.ReadLine();

            Console.WriteLine("please add your Email : ");
            user.Email = Console.ReadLine();

            Console.WriteLine("please add your Phone : ");
            user.Phone = Console.ReadLine();

            users.Add(user);

            Console.WriteLine("=========== user information ==============");

            Console.WriteLine($"Name : {user.Name}");
            Console.WriteLine($"Email : {user.Email}");
            Console.WriteLine($"Phone : {user.Phone}");

        }

        public void UpdateUser(List<user> users)
        {
            Console.WriteLine("Enter phone number to find user : ");
            string findphone = Console.ReadLine();
            var founded = users.FirstOrDefault(x => x.Phone == findphone);
            if (founded != null)
            {
                Console.WriteLine("information of user ");
                Console.WriteLine($"Name :{founded.Name} ,\n" +
                                  $" Email : {founded.Email}\n" +
                                  $" and phone{founded.Phone}");
                up:
                Console.Write("what do you need to update ?\n 1) Name \n 2) Email \n 3) Phone");
                Console.WriteLine("select number :");
                int chos=int.Parse(Console.ReadLine());
                if (chos==1)
                {
                    Console.WriteLine("what is new name ? ");
                    string newname = Console.ReadLine();
                    founded.Name = newname;
                }
                else if (chos==2) 
                {
                    Console.WriteLine("what is new Email ? ");
                    string newEmail = Console.ReadLine();
                    founded.Email = newEmail;
                }
                else if(chos==3) 
                {
                    Console.WriteLine("what is new phone ? ");
                    string newphone = Console.ReadLine();
                    founded.Phone = newphone;
                }
                Console.WriteLine("do you want another update ? (Y/N)");
                char chos2=char.Parse(Console.ReadLine().ToLower());
                if (chos2 == 'y')
                {
                    goto up;
                }
                else
                {
                    Console.WriteLine("your updates are done ...");
                }
            }
            else 
            {
                Console.WriteLine("No user with this phone number ");
            }
        }

        public void RemoveUser(List<user> users)
        {
            Console.WriteLine("Enter phone number to find user : ");
            string findphone = Console.ReadLine();
            var founded = users.FirstOrDefault(x => x.Phone == findphone);
            if (founded != null) 
            {
                users.Remove(founded);
                Console.WriteLine("user is deleted");
            }
            else
            {
                Console.WriteLine("no user found");
                    
            }


        }

        public void DisplayUser(List<user> users)
        {
            int count = 1;
            foreach (user user in users)
            {
                if (users.Count == 0)
                {
                    Console.WriteLine("=================================");
                    Console.WriteLine("no users found");
                }
                else
                {
                    Console.WriteLine("=========== user information ==============");
                    Console.WriteLine($"user number :{count}");
                    Console.WriteLine($"Name : {user.Name}");
                    Console.WriteLine($"Email : {user.Email}");
                    Console.WriteLine($"Phone : {user.Phone}");
                    count++;
                }
            }
        }
    }
}
