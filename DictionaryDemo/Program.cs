namespace DictionaryDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserService userService = new();
            //Add User
            userService.AddUser(1, "Rohan Bait");
            userService.AddUser(2, "Vinanti Bait");

            //Get UserName
            Console.WriteLine("Enter UserID to Search:-");
            int UserId = Convert.ToInt32(Console.ReadLine());
            string UserName = userService.GetUserName(UserId);
            Console.WriteLine($"User Name:- {UserName}");

            //Update User Name
            Console.WriteLine("Enter UserName update record:-");
            UserName = Console.ReadLine();
            userService.AddUser(UserId, UserName);
            UserName = userService.GetUserName(1);
            Console.WriteLine($"User Name:- {UserName}");

            //Remove User
            Console.WriteLine("Enter UserID to remove:-");
            UserId = Convert.ToInt32(Console.ReadLine());
            bool isRemoved = userService.RemoveUser(UserId);
            Console.WriteLine($"{UserId} Is User Removed :-{isRemoved}");
            Console.ReadLine();
        }
    }
}