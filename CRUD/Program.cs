using CRUD;

internal class Program
{
    private static void Main(string[] args)
    {
        List<user> list = new List<user>() 
        {
            //sampleData
            new user{Name="SD",Email="Assiut",Phone="011"},
            new user{Name="Unix",Email="Alex",Phone="012"},
            new user{Name="Java",Email="Cairo",Phone="013"},
            new user{Name="E-Learning",Email="Alex",Phone="014"}
        };
         user user = new user();  
        while (true)
        {
            Console.WriteLine("Welecome in my first task ");
            Console.WriteLine("what do you want ?\n 1) Add \n 2)Update  \n 3) Delete\n 4) display \n 5)Exit");
            int chos=int.Parse(Console.ReadLine());
            if (chos == 1) 
            {
                user.AddUser(list);
            }
            else if (chos == 2)
            {
                user.UpdateUser(list);

            }
            else if (chos == 3)
            {
                user.RemoveUser(list);
            }
            else if (chos == 4)
            {
                user.DisplayUser(list);
            }
            else if (chos == 5)
            {
                Environment.Exit(0);
            }
        }
    }
}