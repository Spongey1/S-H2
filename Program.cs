using System;
using System.Collections.Generic;

namespace S_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();

            messages.Add(new Message("John F. Kennedy", "James Bond", "James, it", "The Chosen one", "cc? "));
            messages.Add(new Message("Obama Care", "Steward", "The fond has broken down!", "The Fund", "cc?"));

            foreach (var msg in messages)
            {
                Console.WriteLine(msg.To); // Displays who send the message
            }
        }
    }
}
