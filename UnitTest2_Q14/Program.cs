using System;

namespace StructToClass
{
    // Author: Christine Espeleta
    // Purpose: Unit Test 2 Question #14. Convert the following code from using struct Friend to public class Friend and generate the same output
    // Restrictions: N/A

    // original struct
    /**
    struct Friend
{
    public string name;
    public string greeting;
    public DateTime birthdate;
    public string address;
}
    **/
    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
    }
    class Program
    {
        static void Main(string[] args)
        {
        Friend friend = new Friend();

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            Friend enemy = new Friend();

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}
