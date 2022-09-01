using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PartyInviteApp
{
    class Program
    {

        static void Main(string[] args)
        {
            // Store a list of friends in a list
            var friends = new List<string> {"Frank", "Joe", "Mikel", "Andy", "Maria", "Carlos", "Angelina"};
            // Console.WriteLine(getShortestName(friends));
            var party_friends = getPartyFriends(friends, 5);
            foreach (var name in party_friends)
            {
                Console.WriteLine(name);
            }

        }
        public static string getShortestName(List<string> friends_list)
        {
            string shortestName = friends_list[0];
            for(var i = 0; i < friends_list.Count; i++)
            {
                if (friends_list[i].Length < shortestName.Length)
                {
                    shortestName = friends_list[i];
                }
            }
            return shortestName;
        }


        // (access key-public) (static) (datatype-string) (function/method name- getPartyFriends(datatype))
        public static List<string> getPartyFriends(List<string> friends_list, int count)
        {
            if (friends_list == null)
            {
                throw new ArgumentNullException("List", "The list is empty");
            }
            if (count > friends_list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater or lower than elements in a list");
            }
            // Storing a list inside another list
            var buffer = new List<string>(friends_list);
            // Write a function to store/append those friends with the shortest names to a list
            // Initialize an empty party friends list
            var party_friends = new List<string>();

            while (party_friends.Count < count)
            {
                // Store a friend with short name
                var current_friend = getShortestName(buffer);
                // Add that friend to the party friends list
                party_friends.Add(current_friend);
                // Delete that current friend from the friends list
                buffer.Remove(current_friend);
                
            }
            return party_friends;
        }
    }
}